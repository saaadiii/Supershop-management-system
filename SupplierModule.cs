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
    public partial class SupplierModule : Form
    {
        SqlConnection conn = new SqlConnection();
        DBconnection dbcon = new DBconnection();

        supplier sup;

        public int SupplierID = 0;

        public SupplierModule(supplier s)
        {
            InitializeComponent();

            conn = new SqlConnection(dbcon.myconnection());
            sup = s;

            cancelbtn.Click += cancelbtn_Click;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtsupplier.Text) ||
                string.IsNullOrWhiteSpace(textadd.Text) ||
                string.IsNullOrWhiteSpace(textcontact.Text) ||
                string.IsNullOrWhiteSpace(textphn.Text) ||
                string.IsNullOrWhiteSpace(textemail.Text))
            {
                MessageBox.Show(
                    "Please fill in all fields except fax.",
                    "Missing Information");

                return false;
            }

            if (txtsupplier.Text.Trim().Length > 50 ||
                textphn.Text.Trim().Length > 50 ||
                textemail.Text.Trim().Length > 50 ||
                textfax.Text.Trim().Length > 50)
            {
                MessageBox.Show(
                    "Supplier name, phone, email and fax must " +
                    "each be 50 characters or fewer.");

                return false;
            }

           
            if (textcontact.Text.Trim().Length > 10)
            {
                MessageBox.Show(
                    "The contactperson column in your database " +
                    "allows a maximum of 10 characters.");

                textcontact.Focus();
                return false;
            }

            return true;
        }

        private void AddParameters(SqlCommand cmd)
        {
            cmd.Parameters.Add("@supplier", SqlDbType.VarChar, 50)
                .Value = txtsupplier.Text.Trim();

            cmd.Parameters.Add("@address", SqlDbType.Text)
                .Value = textadd.Text.Trim();

            cmd.Parameters.Add("@contactperson", SqlDbType.NChar, 10)
                .Value = textcontact.Text.Trim();

            cmd.Parameters.Add("@phone", SqlDbType.VarChar, 50)
                .Value = textphn.Text.Trim();

            cmd.Parameters.Add("@email", SqlDbType.VarChar, 50)
                .Value = textemail.Text.Trim();

            cmd.Parameters.Add("@fax", SqlDbType.VarChar, 50)
                .Value = string.IsNullOrWhiteSpace(textfax.Text)
                    ? (object)DBNull.Value
                    : textfax.Text.Trim();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            if (MessageBox.Show(
                "Save this supplier?",
                "Save Record",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO dbo.tbsupplier
                      (supplier, address, contactperson, phone, email, fax)
                      VALUES
                      (@supplier, @address, @contactperson,
                       @phone, @email, CONVERT(VARBINARY(50), @fax))",
                    conn))
                {
                    AddParameters(cmd);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
                return;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

            MessageBox.Show(
                "Supplier has been saved successfully.",
                "Success");

            Clear();
            sup.LoadSupplier();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (SupplierID == 0 || !ValidateInputs())
                return;

            if (MessageBox.Show(
                "Update this supplier?",
                "Update Record",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(
                    @"UPDATE dbo.tbsupplier
                      SET supplier = @supplier,
                          address = @address,
                          contactperson = @contactperson,
                          phone = @phone,
                          email = @email,
                          fax = CONVERT(VARBINARY(50), @fax)
                      WHERE ID = @id",
                    conn))
                {
                    AddParameters(cmd);

                    cmd.Parameters.Add("@id", SqlDbType.Int)
                        .Value = SupplierID;

                    int affected = cmd.ExecuteNonQuery();

                    if (affected == 0)
                    {
                        MessageBox.Show("This supplier no longer exists.");
                        return;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
                return;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

            MessageBox.Show(
                "Supplier has been updated successfully.",
                "Success");

            sup.LoadSupplier();
            Close();
        }

        private void Csncelbtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txtsupplier.Clear();
            textadd.Clear();
            textcontact.Clear();
            textphn.Clear();
            textemail.Clear();
            textfax.Clear();

            txtsupplier.Focus();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void productcodebtn_TextChanged(object sender, EventArgs e)
        {
        }

        private void textadd_TextChanged(object sender, EventArgs e)
        {
        }

        private void textcontact_TextChanged(object sender, EventArgs e)
        {
        }

        private void textphn_TextChanged(object sender, EventArgs e)
        {
        }

        private void textemail_TextChanged(object sender, EventArgs e)
        {
        }

        private void textfax_TextChanged(object sender, EventArgs e)
        {
        }
    }
}