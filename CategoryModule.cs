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
    public partial class CategoryModule : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnection dbcon = new DBconnection();

        Category cat;

        public int CategoryID = 0;

        public CategoryModule(Category c)
        {
            InitializeComponent();
            conn = new SqlConnection(dbcon.myconnection());
            cat = c;
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(
                    "Save this category?",
                    "Save Record",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();

                    cmd = new SqlCommand(
                        "INSERT INTO tbcatagory(catagory) VALUES(@catagory)",
                        conn);

                    cmd.Parameters.AddWithValue("@catagory", textbtn.Text);

                    cmd.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show(
                        "Category has been saved successfully.",
                        "Success");

                    Clear();
                    cat.LoadCategory();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(
                    "Update this category?",
                    "Update Record",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();

                    cmd = new SqlCommand(
                        "UPDATE tbcatagory SET catagory=@catagory WHERE id=@id",
                        conn);

                    cmd.Parameters.AddWithValue("@catagory", textbtn.Text);
                    cmd.Parameters.AddWithValue("@id", CategoryID);

                    cmd.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show(
                        "Category has been updated successfully.",
                        "Success");

                    this.Dispose();
                    cat.LoadCategory();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void Csncelbtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            textbtn.Clear();
            Savebtn.Enabled = true;
            updatebtn.Visible = false;
            textbtn.Focus();
        }

        private void crossbtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textbtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void CategoryModule_Load(object sender, EventArgs e)
        {

        }
    }
}