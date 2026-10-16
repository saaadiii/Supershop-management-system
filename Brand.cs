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
    public partial class Brand : Form
    {


        SqlConnection connStr = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        DBconnection DBconn = new DBconnection();

        public Brand()
        {
            InitializeComponent();
            connStr = new SqlConnection(DBconn.myconnection());
            LoadBrand();
        }

        public void LoadBrand()
        {
            int i = 0;

            dgvbrand.Rows.Clear();

            connStr.Open();

            cmd = new SqlCommand("SELECT * FROM dbo.tbBrand ORDER BY ID", connStr);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                i++;

                dgvbrand.Rows.Add(
                    i,
                    dr["ID"].ToString(),
                    dr["Brand"].ToString()
                );
            }

            dr.Close();
            connStr.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvbrand.Columns[e.ColumnIndex].Name;

            if (colName == "Delete")
            {
                if (MessageBox.Show(
                    "Are you sure you want to delete this brand?",
                    "Delete Brand",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connStr.Open();

                    cmd = new SqlCommand(
                        "DELETE FROM dbo.tbBrand WHERE ID=@ID",
                        connStr);

                    cmd.Parameters.AddWithValue(
                        "@ID",
                        dgvbrand.Rows[e.RowIndex].Cells[1].Value.ToString());

                    cmd.ExecuteNonQuery();

                    connStr.Close();

                    MessageBox.Show(
                        "Brand deleted successfully.",
                        "Success");

                    LoadBrand();
                }
            }
            else if (colName == "Edit")
            {
                BrandModule moduleform = new BrandModule(this);

                moduleform.BrandID =
                    Convert.ToInt32(dgvbrand.Rows[e.RowIndex].Cells[1].Value);

                moduleform.textbtn.Text =
                    dgvbrand.Rows[e.RowIndex].Cells[2].Value.ToString();

                moduleform.Savebtn.Visible = false;
                moduleform.updatebtn.Visible = true;

                moduleform.ShowDialog();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            BrandModule moduleform = new BrandModule(this);

            moduleform.Savebtn.Visible = true;
            moduleform.updatebtn.Visible = false;

            moduleform.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Brand_Load(object sender, EventArgs e)
        {

        }
    }
}