using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
 using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace Supershop
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide();
        }

        private void email_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void username_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Password_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (signup_showpass.Checked == false)
            {

                signup_password.UseSystemPasswordChar = true;
            }
            else
            {
                signup_password.UseSystemPasswordChar = false;
            }
        }

        private void sign_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(signup_username.Text) ||
                string.IsNullOrWhiteSpace(signup_password.Text) ||
                string.IsNullOrWhiteSpace(signup_email.Text))
            {
                MessageBox.Show("Username, Email & Password required!");
                return;
            }

            
            string tableName = "";

            if (admin.Checked)
                tableName = "Admin";
            else if (manager.Checked)
                tableName = "Manager";
            else if (cashier.Checked)
                tableName = "Cashier";
            else if (customer.Checked)
                tableName = "Customer";
            else
            {
                MessageBox.Show("Please select a role!");
                return;
            }

            
            string connStr = @"Data Source=Sadia\SQLEXPRESS;Initial Catalog=Supershop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

          
            string checkQuery = $"SELECT COUNT(*) FROM {tableName} WHERE Username = @Username";

            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();

               
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                {
                    checkCmd.Parameters.AddWithValue("@Username", signup_username.Text);

                    int exists = (int)checkCmd.ExecuteScalar();

                    if (exists > 0)
                    {
                        MessageBox.Show("Username already exists!");
                        return;
                    }
                }

                
                string insertQuery = $"INSERT INTO {tableName} (Username, Email, Password) VALUES (@Username, @Email, @Password)";

                using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                {
                    insertCmd.Parameters.AddWithValue("@Username", signup_username.Text);
                    insertCmd.Parameters.AddWithValue("@Email", signup_email.Text);
                    insertCmd.Parameters.AddWithValue("@Password", signup_password.Text);

                    insertCmd.ExecuteNonQuery();
                }
            }

          
            MessageBox.Show($"{tableName} signup successful!");
        }


        private void admin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void manager_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cashier_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void customer_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
