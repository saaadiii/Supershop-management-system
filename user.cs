using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Supershop
{

    using Microsoft.Data.SqlClient;
    using System;
    using System.Data;
    using System.Windows.Forms;

   
        public partial class user : Form
        {
            SqlConnection connStr = new SqlConnection();
            DBconnection DBconn = new DBconnection();

            public user()
            {
                InitializeComponent();

                connStr = new SqlConnection(DBconn.myconnection());
            }

            // CREATE ACCOUNT TAB

            private void username_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
            {
            }

            private void pass_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
            {
            }

            private void retypepass_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
            {
            }

            private void role_SelectedIndexChanged(object sender, EventArgs e)
            {
            }

            // SAVE ACCOUNT
            private void Savebtn_Click(object sender, EventArgs e)
            {
                if (username.Text.Trim() == "" ||
                    pass.Text == "" ||
                    retypepass.Text == "" ||
                    role.Text == "")
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                if (pass.Text != retypepass.Text)
                {
                    MessageBox.Show("Passwords do not match.");
                    retypepass.Focus();
                    return;
                }

                try
                {
                    using (SqlConnection con =
                        new SqlConnection(DBconn.myconnection()))
                    {
                        con.Open();

                        string checkQuery =
                            "SELECT COUNT(*) FROM dbo.tbuseracc " +
                            "WHERE username = @username";

                        using (SqlCommand checkCmd =
                            new SqlCommand(checkQuery, con))
                        {
                            checkCmd.Parameters.Add("@username",
                                SqlDbType.VarChar, 50).Value =
                                username.Text.Trim();

                            int count = Convert.ToInt32(
                                checkCmd.ExecuteScalar());

                            if (count > 0)
                            {
                                MessageBox.Show("Username already exists.");
                                return;
                            }
                        }

                        string query =
                            "INSERT INTO dbo.tbuseracc " +
                            "(username, password, role, isactive) " +
                            "VALUES (@username, @password, @role, @isactive)";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.Add("@username",
                                SqlDbType.VarChar, 50).Value =
                                username.Text.Trim();

                            cmd.Parameters.Add("@password",
                                SqlDbType.VarChar, 50).Value = pass.Text;

                            cmd.Parameters.Add("@role",
                                SqlDbType.VarChar, 50).Value = role.Text;

                            cmd.Parameters.Add("@isactive",
                                SqlDbType.VarChar, 50).Value = "true";

                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Account created successfully!");

                    username.Clear();
                    pass.Clear();
                    retypepass.Clear();
                    role.SelectedIndex = -1;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Database Error");
                }
            }

            // CANCEL ACCOUNT CREATION
            private void Cancelbtn_Click(object sender, EventArgs e)
            {
                username.Clear();
                pass.Clear();
                retypepass.Clear();
                role.SelectedIndex = -1;
            }

            // CHANGE PASSWORD TAB

            private void txtusername_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
            {
            }

            private void txtcurrentpass_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
            {
            }

            private void txtnewpass_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
            {
            }

            private void txtrepass_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
            {
            }

            // SAVE NEW PASSWORD
            private void save_Click(object sender, EventArgs e)
            {
                if (txtusername.Text.Trim() == "" ||
                    txtcurrentpass.Text == "" ||
                    txtnewpass.Text == "" ||
                    txtrepass.Text == "")
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                if (txtnewpass.Text != txtrepass.Text)
                {
                    MessageBox.Show("New passwords do not match.");
                    txtrepass.Focus();
                    return;
                }

                if (txtcurrentpass.Text == txtnewpass.Text)
                {
                    MessageBox.Show(
                        "The new password must be different from the current password.");
                    return;
                }

                try
                {
                    using (SqlConnection con =
                        new SqlConnection(DBconn.myconnection()))
                    {
                        con.Open();

                        string query =
                            "UPDATE dbo.tbuseracc " +
                            "SET password = @newpassword " +
                            "WHERE username = @username " +
                            "AND password = @currentpassword " +
                            "AND isactive = @isactive";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.Add("@newpassword",
                                SqlDbType.VarChar, 50).Value =
                                txtnewpass.Text;

                            cmd.Parameters.Add("@username",
                                SqlDbType.VarChar, 50).Value =
                                txtusername.Text.Trim();

                            cmd.Parameters.Add("@currentpassword",
                                SqlDbType.VarChar, 50).Value =
                                txtcurrentpass.Text;

                            cmd.Parameters.Add("@isactive",
                                SqlDbType.VarChar, 50).Value = "true";

                            int rows = cmd.ExecuteNonQuery();

                            if (rows > 0)
                            {
                                MessageBox.Show(
                                    "Password changed successfully!");

                                txtusername.Clear();
                                txtcurrentpass.Clear();
                                txtnewpass.Clear();
                                txtrepass.Clear();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Invalid username or current password, " +
                                    "or the account is inactive.");
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Database Error");
                }
            }

            // CANCEL PASSWORD CHANGE
            private void cancel_Click(object sender, EventArgs e)
            {
                txtusername.Clear();
                txtcurrentpass.Clear();
                txtnewpass.Clear();
                txtrepass.Clear();
            }
        }
    }
