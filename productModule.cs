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
    public partial class productModule : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;

        DBconnection db = new DBconnection();

        Product prod;

        public int ProductID = 0;

        public productModule(Product p)
        {
            InitializeComponent();

            conn = new SqlConnection(db.myconnection());
            prod = p;
        }

        private void productModule_Load(object sender, EventArgs e)
        {
            LoadBrand();
            LoadCategory();

            brandcombobox.SelectedIndex = -1;
            brandcombobox.Text = "";

            categorycombobox.SelectedIndex = -1;
            categorycombobox.Text = "";

            if (ProductID > 0)
            {
                LoadProductForUpdate();
            }
        }

        public void LoadBrand()
        {
            try
            {
                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT ID, Brand FROM tbBrand",
                    conn
                );

                da.Fill(dt);

                brandcombobox.DataSource = dt;
                brandcombobox.DisplayMember = "Brand";
                brandcombobox.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadCategory()
        {
            try
            {
                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT id, catagory FROM tbcatagory",
                    conn
                );

                da.Fill(dt);

                categorycombobox.DataSource = dt;
                categorycombobox.DisplayMember = "catagory";
                categorycombobox.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadProductForUpdate()
        {
            try
            {
                conn.Open();

                string query = @"
                    SELECT 
                        pcode,
                        bcode,
                        pdes,
                        bid,
                        cid,
                        price,
                        reorder
                    FROM tbProduct
                    WHERE id=@id";

                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", ProductID);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    productcodebtn.Text = dr["pcode"].ToString();
                    barcodebox.Text = dr["bcode"].ToString();
                    descriptionbox.Text = dr["pdes"].ToString();
                    pricebox.Text = dr["price"].ToString();

                    reordernumericupdown.Value =
                        Convert.ToDecimal(dr["reorder"]);

                    brandcombobox.SelectedValue =
                        Convert.ToInt32(dr["bid"]);

                    categorycombobox.SelectedValue =
                        Convert.ToInt32(dr["cid"]);
                }

                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private bool ValidateProductInput()
        {
            if (productcodebtn.Text.Trim() == "")
            {
                MessageBox.Show("Product code cannot be empty");
                productcodebtn.Focus();
                return false;
            }

            if (descriptionbox.Text.Trim() == "")
            {
                MessageBox.Show("Description cannot be empty");
                descriptionbox.Focus();
                return false;
            }

            if (pricebox.Text.Trim() == "")
            {
                MessageBox.Show("Price cannot be empty");
                pricebox.Focus();
                return false;
            }

            decimal price;

            if (!decimal.TryParse(pricebox.Text.Trim(), out price))
            {
                MessageBox.Show("Please enter a valid price");
                pricebox.Focus();
                return false;
            }

            if (brandcombobox.SelectedIndex == -1 || brandcombobox.SelectedValue == null)
            {
                MessageBox.Show("Please select a brand");
                brandcombobox.Focus();
                return false;
            }

            if (categorycombobox.SelectedIndex == -1 || categorycombobox.SelectedValue == null)
            {
                MessageBox.Show("Please select a category");
                categorycombobox.Focus();
                return false;
            }

            return true;
        }

        public void ClearFields()
        {
            productcodebtn.Clear();
            barcodebox.Clear();
            descriptionbox.Clear();
            pricebox.Clear();

            reordernumericupdown.Value = 0;

            brandcombobox.SelectedIndex = -1;
            brandcombobox.Text = "";

            categorycombobox.SelectedIndex = -1;
            categorycombobox.Text = "";

            productcodebtn.Focus();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (!ValidateProductInput())
                return;

            if (MessageBox.Show(
                "Do you want to save this product?",
                "Confirmation Save",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                conn.Open();

                string query = @"
                    INSERT INTO tbProduct
                    (pcode, bcode, pdes, bid, cid, price, qty, reorder)
                    VALUES
                    (@pcode, @bcode, @pdes, @bid, @cid, @price, 0, @reorder)";

                cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@pcode", productcodebtn.Text.Trim());
                cmd.Parameters.AddWithValue("@bcode", barcodebox.Text.Trim());
                cmd.Parameters.AddWithValue("@pdes", descriptionbox.Text.Trim());

                cmd.Parameters.AddWithValue("@bid",
                    Convert.ToInt32(brandcombobox.SelectedValue));

                cmd.Parameters.AddWithValue("@cid",
                    Convert.ToInt32(categorycombobox.SelectedValue));

                cmd.Parameters.AddWithValue("@price",
                    Convert.ToDecimal(pricebox.Text.Trim()));

                cmd.Parameters.AddWithValue("@reorder",
                    Convert.ToInt32(reordernumericupdown.Value));

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Product saved successfully");

                prod.LoadProduct();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (ProductID == 0)
            {
                MessageBox.Show("No product selected");
                return;
            }

            if (!ValidateProductInput())
                return;

            if (MessageBox.Show(
                "Do you want to update this product?",
                "Confirmation Edit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                conn.Open();

                string query = @"
                    UPDATE tbProduct SET
                        pcode=@pcode,
                        bcode=@bcode,
                        pdes=@pdes,
                        bid=@bid,
                        cid=@cid,
                        price=@price,
                        reorder=@reorder
                    WHERE id=@id";

                cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", ProductID);
                cmd.Parameters.AddWithValue("@pcode", productcodebtn.Text.Trim());
                cmd.Parameters.AddWithValue("@bcode", barcodebox.Text.Trim());
                cmd.Parameters.AddWithValue("@pdes", descriptionbox.Text.Trim());

                cmd.Parameters.AddWithValue("@bid",
                    Convert.ToInt32(brandcombobox.SelectedValue));

                cmd.Parameters.AddWithValue("@cid",
                    Convert.ToInt32(categorycombobox.SelectedValue));

                cmd.Parameters.AddWithValue("@price",
                    Convert.ToDecimal(pricebox.Text.Trim()));

                cmd.Parameters.AddWithValue("@reorder",
                    Convert.ToInt32(reordernumericupdown.Value));

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Product updated successfully");

                prod.LoadProduct();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Csncelbtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}