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
    public partial class Product : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;

        DBconnection db = new DBconnection();

        public Product()
        {
            InitializeComponent();

            conn = new SqlConnection(db.myconnection());

            dgvproduct.Columns["ID"].Visible = false;

            LoadProduct();
        }

        public void LoadProduct(string search = "")
        {
            dgvproduct.Rows.Clear();

            int i = 0;

            string query = @"
                SELECT 
                    p.id,
                    p.pcode,
                    p.bcode,
                    p.pdes,
                    b.Brand,
                    c.catagory,
                    p.price,
                    p.reorder
                FROM tbProduct p
                LEFT JOIN tbBrand b ON p.bid = b.ID
                LEFT JOIN tbcatagory c ON p.cid = c.id
                WHERE
                    p.pcode LIKE @search
                    OR p.bcode LIKE @search
                    OR p.pdes LIKE @search
                    OR b.Brand LIKE @search
                    OR c.catagory LIKE @search
                ORDER BY p.id";

            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                conn.Open();

                cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue(
                    "@search",
                    "%" + search + "%"
                );

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    i++;

                    dgvproduct.Rows.Add(
                        dr["id"].ToString(),
                        i,
                        dr["pcode"].ToString(),
                        dr["bcode"].ToString(),
                        dr["pdes"].ToString(),
                        dr["Brand"].ToString(),
                        dr["catagory"].ToString(),
                        dr["price"].ToString(),
                        dr["reorder"].ToString()
                    );
                }

                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            productModule module = new productModule(this);

            module.ProductID = 0;

            module.Savebtn.Visible = true;
            module.updatebtn.Visible = false;

            module.ShowDialog();

            LoadProduct(textSearch.Text.Trim());
        }

        private void dgvproduct_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            string col = dgvproduct.Columns[e.ColumnIndex].Name;

            if (col == "Edit")
            {
                productModule module = new productModule(this);

                module.ProductID = Convert.ToInt32(
                    dgvproduct.Rows[e.RowIndex]
                    .Cells["ID"]
                    .Value
                );

                module.Savebtn.Visible = false;
                module.updatebtn.Visible = true;

                module.ShowDialog();

                LoadProduct(textSearch.Text.Trim());
            }

            else if (col == "Delete")
            {
                if (MessageBox.Show(
                    "Do you want to delete this product?",
                    "Confirmation Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    try
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }

                        conn.Open();

                        cmd = new SqlCommand(
                            "DELETE FROM tbProduct WHERE id = @id",
                            conn
                        );

                        cmd.Parameters.AddWithValue(
                            "@id",
                            dgvproduct.Rows[e.RowIndex]
                            .Cells["ID"]
                            .Value
                        );

                        cmd.ExecuteNonQuery();

                        conn.Close();

                        MessageBox.Show(
                            "Product deleted successfully.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        LoadProduct(textSearch.Text.Trim());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );

                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct(textSearch.Text.Trim());
        }
    }
}

