using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Supershop
{
    public partial class supplier : Form
    {
        SqlConnection connStr = new SqlConnection();
        DBconnection DBconn = new DBconnection();

        public supplier()
        {
            InitializeComponent();

            connStr = new SqlConnection(DBconn.myconnection());

            dgvsupplier.CellContentClick -= dgvsupplier_CellContentClick;
            dgvsupplier.CellContentClick += dgvsupplier_CellContentClick;

            LoadSupplier();
        }

        public void LoadSupplier()
        {
            try
            {
                int i = 0;

                dgvsupplier.Rows.Clear();

                connStr.Open();

                using (SqlCommand cmd = new SqlCommand(
                    @"SELECT ID, supplier, address, contactperson,
                             phone, email,
                             CONVERT(VARCHAR(50), fax) AS fax
                      FROM dbo.tbsupplier
                      ORDER BY ID",
                    connStr))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        i++;

                        // Your supplier grid order:
                        // ID, No, Supplier, Address, Contact Person,
                        // Phone, Email, Fax, Edit, Delete.
                        dgvsupplier.Rows.Add(
                            dr["ID"].ToString(),
                            i,
                            dr["supplier"].ToString(),
                            dr["address"].ToString(),
                            dr["contactperson"].ToString().Trim(),
                            dr["phone"].ToString(),
                            dr["email"].ToString(),
                            dr["fax"].ToString()
                        );
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
            }
            finally
            {
                if (connStr.State == ConnectionState.Open)
                    connStr.Close();
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            using (SupplierModule moduleform = new SupplierModule(this))
            {
                moduleform.Savebtn.Visible = true;
                moduleform.updatebtn.Visible = false;

                moduleform.ShowDialog();
            }
        }

        private void dgvsupplier_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            DataGridViewRow row = dgvsupplier.Rows[e.RowIndex];

            if (row.IsNewRow || row.Cells[0].Value == null)
                return;

            string colName = dgvsupplier.Columns[e.ColumnIndex].Name;

            if (colName == "Delete")
            {
                if (MessageBox.Show(
                    "Are you sure you want to delete this supplier?",
                    "Delete Supplier",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }

                try
                {
                    connStr.Open();

                    using (SqlCommand cmd = new SqlCommand(
                        "DELETE FROM dbo.tbsupplier WHERE ID = @id",
                        connStr))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value =
                            Convert.ToInt32(row.Cells[0].Value);

                        int affected = cmd.ExecuteNonQuery();

                        MessageBox.Show(
                            affected > 0
                                ? "Supplier deleted successfully."
                                : "This supplier was already removed.",
                            "Supplier");
                    }
                }
                catch (SqlException ex) when (ex.Number == 547)
                {
                    MessageBox.Show(
                        "This supplier is used by other records " +
                        "and cannot be deleted.",
                        "Cannot Delete");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Database Error");
                }
                finally
                {
                    if (connStr.State == ConnectionState.Open)
                        connStr.Close();
                }

                LoadSupplier();
            }
            else if (colName == "Edit")
            {
                using (SupplierModule moduleform = new SupplierModule(this))
                {
                    moduleform.SupplierID =
                        Convert.ToInt32(row.Cells[0].Value);

                    moduleform.txtsupplier.Text =
                        Convert.ToString(row.Cells[2].Value);

                    moduleform.textadd.Text =
                        Convert.ToString(row.Cells[3].Value);

                    moduleform.textcontact.Text =
                        Convert.ToString(row.Cells[4].Value);

                    moduleform.textphn.Text =
                        Convert.ToString(row.Cells[5].Value);

                    moduleform.textemail.Text =
                        Convert.ToString(row.Cells[6].Value);

                    moduleform.textfax.Text =
                        Convert.ToString(row.Cells[7].Value);

                    moduleform.Savebtn.Visible = false;
                    moduleform.updatebtn.Visible = true;

                    moduleform.ShowDialog();
                }
            }
        }
    }
}