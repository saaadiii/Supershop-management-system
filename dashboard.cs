using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Supershop
{
    public partial class dashboard : Form

    {
        SqlConnection connStr = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnection DBconn = new DBconnection();

        public dashboard()
        {
            InitializeComponent();
            customizedesign();
            connStr = new SqlConnection(DBconn.myconnection());
            connStr.Open();
        }

        #region panelSlide
        private void customizedesign()
        {
            panelsubproduct.Visible = false;
            panelsubrecord.Visible = false;
            panelsubstock.Visible = false;
            panelsubsetting.Visible = false;
        }

        private void hidesubmenu()
        {
            if (panelsubproduct.Visible == true)
                panelsubproduct.Visible = false;
            if (panelsubrecord.Visible == true)
                panelsubrecord.Visible = false;
            if (panelsubsetting.Visible == true)
                panelsubsetting.Visible = false;
            if (panelsubstock.Visible == true)
                panelsubstock.Visible = false;
        }
        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        #endregion panelSlide

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            lbltittle.Text = childForm.Text;

            panelmain.Controls.Clear();
            panelmain.Controls.Add(childForm);

            childForm.BringToFront();
            childForm.Show();
        }
        private void product_Click(object sender, EventArgs e)
        {
            showsubmenu(panelsubproduct);
        }

        private void stock_Click(object sender, EventArgs e)
        {
            showsubmenu(panelsubstock);
        }

        private void dashboardbutton_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void supplier_Click(object sender, EventArgs e)
        {
          
            hidesubmenu();
            openChildForm(new Supershop.supplier());
        }
        

        private void Record_Click(object sender, EventArgs e)
        {
            showsubmenu(panelsubrecord);
        }

        private void settings_Click(object sender, EventArgs e)
        {
            showsubmenu(panelsubsetting);

        }

        private void logout_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void productlist_Click(object sender, EventArgs e)
        {
            openChildForm(new Product());
        }

        private void catagory_Click(object sender, EventArgs e)
        {
            openChildForm(new Category());
        }

        private void brand_Click(object sender, EventArgs e)
        {
            openChildForm(new Brand());
        }

        private void instock_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void stockadjustment_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }

        private void soldlist_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void history_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void user_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            openChildForm(new user());
        }

        private void posrecord_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void panelmain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbltittle_Click(object sender, EventArgs e)
        {

        }
    }
}
