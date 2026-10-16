using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Net.Sockets;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Supershop
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showpass.Checked == false)
            {

                login_password.UseSystemPasswordChar = true;
            }
            else
            {
                login_password.UseSystemPasswordChar = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup sForm = new Signup();
            sForm.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            

        }

        private void login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(login_username.Text) ||
         string.IsNullOrWhiteSpace(login_password.Text))
            {
                MessageBox.Show("Username and Password required!");
                return;
            }

            if (login_selectrole.SelectedItem == null)
            {
                MessageBox.Show("Please select a role!");
                return;
            }

            string role = login_selectrole.SelectedItem.ToString();

            string tableName = role;

            
            string connStr = @"Data Source=Sadia\SQLEXPRESS;Initial Catalog=Supershop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            string query = $"SELECT COUNT(*) FROM {tableName} WHERE Username=@Username AND Password=@Password";

            using (SqlConnection con = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Username", login_username.Text);
                cmd.Parameters.AddWithValue("@Password", login_password.Text);

                con.Open();
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show($"{role} login successful!");

                    // Role-based navigation (optional)
                    /*
                    if (role == "Admin")
                        new AdminDashboard().Show();
                    else if (role == "Manager")
                        new ManagerDashboard().Show();
                    else if (role == "Cashier")
                        new CashierDashboard().Show();
                    else
                        new CustomerDashboard().Show();
                    */


                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }
            }
        }




        private void selectrole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
