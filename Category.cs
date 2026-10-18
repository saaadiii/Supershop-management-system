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
    public partial class Category : Form
    {
        SqlConnection connStr = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        DBconnection DBconn = new DBconnection();

        public Category()
        {
            InitializeComponent();
            connStr = new SqlConnection(DBconn.myconnection());
            LoadCategory();
        }

        public void LoadCategory()
        {
            int i = 0;

            dgvcategory.Rows.Clear();

            connStr.Open();

            cmd = new SqlCommand(
                "SELECT * FROM dbo.tbcatagory ORDER BY id",
                connStr);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                i++;

                dgvcategory.Rows.Add(
                    i,
                    dr["id"].ToString(),
                    dr["catagory"].ToString()
                );
            }

            dr.Close();
            connStr.Close();
        }

        private void dgvcategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvcategory.Columns[e.ColumnIndex].Name;

            if (colName == "Delete")
            {
                if (MessageBox.Show(
                    "Are you sure you want to delete this category?",
                    "Delete Category",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connStr.Open();

                    cmd = new SqlCommand(
                        "DELETE FROM dbo.tbcatagory WHERE id=@id",
                        connStr);

                    cmd.Parameters.AddWithValue(
                        "@id",
                        dgvcategory.Rows[e.RowIndex].Cells[1].Value.ToString());

                    cmd.ExecuteNonQuery();

                    connStr.Close();

                    MessageBox.Show(
                        "Category deleted successfully.",
                        "Success");

                    LoadCategory();
                }
            }
            else if (colName == "Edit")
            {
                CategoryModule moduleform = new CategoryModule(this);

                moduleform.CategoryID =
                    Convert.ToInt32(
                        dgvcategory.Rows[e.RowIndex].Cells[1].Value);

                moduleform.textbtn.Text =
                    dgvcategory.Rows[e.RowIndex].Cells[2].Value.ToString();

                moduleform.Savebtn.Visible = false;
                moduleform.updatebtn.Visible = true;

                moduleform.ShowDialog();
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            CategoryModule moduleform = new CategoryModule(this);

            moduleform.Savebtn.Visible = true;
            moduleform.updatebtn.Visible = false;

            moduleform.ShowDialog();
        }

        private void Category_Load(object sender, EventArgs e)
        {

        }
    }
}


