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
    public partial class BrandModule : Form
    {
        SqlConnection connStr = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnection DBconn = new DBconnection();

        Brand brand;

        public int BrandID = 0;

        public BrandModule(Brand br)
        {
            InitializeComponent();

            connStr = new SqlConnection(DBconn.myconnection());

            brand = br;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (textbtn.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Please enter brand name.",
                    "Warning");

                return;
            }

            DialogResult result = MessageBox.Show(
                "Do you want to save this brand?",
                "Confirm Save",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                connStr.Open();

                string query =
                    "INSERT INTO dbo.tbBrand (Brand) VALUES (@Brand)";

                cmd = new SqlCommand(query, connStr);

                cmd.Parameters.AddWithValue(
                    "@Brand",
                    textbtn.Text.Trim());

                cmd.ExecuteNonQuery();

                brand.LoadBrand();

                MessageBox.Show(
                    "Brand saved successfully.",
                    "Success");

                textbtn.Clear();
                textbtn.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Save failed: " + ex.Message,
                    "Error");
            }
            finally
            {
                connStr.Close();
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (BrandID == 0)
            {
                MessageBox.Show(
                    "Please select a brand to update first.",
                    "Warning");

                return;
            }

            if (textbtn.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Please enter brand name.",
                    "Warning");

                return;
            }

            DialogResult result = MessageBox.Show(
                "Do you want to update this brand?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                connStr.Open();

                string query =
                    "UPDATE dbo.tbBrand SET Brand=@Brand WHERE ID=@ID";

                cmd = new SqlCommand(query, connStr);

                cmd.Parameters.AddWithValue(
                    "@Brand",
                    textbtn.Text.Trim());

                cmd.Parameters.AddWithValue(
                    "@ID",
                    BrandID);

                cmd.ExecuteNonQuery();

                brand.LoadBrand();

                MessageBox.Show(
                    "Brand updated successfully.",
                    "Success");

                textbtn.Clear();

                BrandID = 0;

                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Update failed: " + ex.Message,
                    "Error");
            }
            finally
            {
                connStr.Close();
            }
        }

        private void Csncelbtn_Click(object sender, EventArgs e)
        {
            textbtn.Clear();
            textbtn.Focus();
        }

        private void BrandModule_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textbtn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}