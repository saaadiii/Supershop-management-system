namespace Supershop
{
    partial class dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelishide = new FlowLayoutPanel();
            panellogo = new Panel();
            label1 = new Label();
            dashboardbutton = new Button();
            product = new Button();
            panelsubproduct = new Panel();
            brand = new Button();
            catagory = new Button();
            productlist = new Button();
            stock = new Button();
            panelsubstock = new Panel();
            stockadjustment = new Button();
            instock = new Button();
            supplier = new Button();
            Record = new Button();
            panelsubrecord = new Panel();
            history = new Button();
            soldlist = new Button();
            settings = new Button();
            panelsubsetting = new Panel();
            posrecord = new Button();
            user = new Button();
            logout = new Button();
            paneltitle = new Panel();
            lbltittle = new Label();
            panelmain = new Panel();
            panelishide.SuspendLayout();
            panellogo.SuspendLayout();
            panelsubproduct.SuspendLayout();
            panelsubstock.SuspendLayout();
            panelsubrecord.SuspendLayout();
            panelsubsetting.SuspendLayout();
            paneltitle.SuspendLayout();
            SuspendLayout();
            // 
            // panelishide
            // 
            panelishide.Controls.Add(panellogo);
            panelishide.Controls.Add(dashboardbutton);
            panelishide.Controls.Add(product);
            panelishide.Controls.Add(panelsubproduct);
            panelishide.Controls.Add(stock);
            panelishide.Controls.Add(panelsubstock);
            panelishide.Controls.Add(supplier);
            panelishide.Controls.Add(Record);
            panelishide.Controls.Add(panelsubrecord);
            panelishide.Controls.Add(settings);
            panelishide.Controls.Add(panelsubsetting);
            panelishide.Controls.Add(logout);
            panelishide.Dock = DockStyle.Left;
            panelishide.Location = new Point(0, 0);
            panelishide.Name = "panelishide";
            panelishide.Size = new Size(199, 614);
            panelishide.TabIndex = 0;
            // 
            // panellogo
            // 
            panellogo.Controls.Add(label1);
            panellogo.Location = new Point(3, 3);
            panellogo.Name = "panellogo";
            panellogo.Size = new Size(201, 107);
            panellogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 73);
            label1.Name = "label1";
            label1.Size = new Size(125, 22);
            label1.TabIndex = 0;
            label1.Text = "Administrator";
            // 
            // dashboardbutton
            // 
            dashboardbutton.Dock = DockStyle.Top;
            dashboardbutton.FlatAppearance.BorderSize = 0;
            dashboardbutton.FlatStyle = FlatStyle.Flat;
            dashboardbutton.Location = new Point(3, 116);
            dashboardbutton.Name = "dashboardbutton";
            dashboardbutton.Size = new Size(201, 38);
            dashboardbutton.TabIndex = 1;
            dashboardbutton.Text = "Dashboard";
            dashboardbutton.TextAlign = ContentAlignment.MiddleLeft;
            dashboardbutton.UseVisualStyleBackColor = true;
            dashboardbutton.Click += dashboardbutton_Click;
            // 
            // product
            // 
            product.Dock = DockStyle.Top;
            product.FlatAppearance.BorderSize = 0;
            product.FlatStyle = FlatStyle.Flat;
            product.Location = new Point(3, 160);
            product.Name = "product";
            product.Size = new Size(201, 49);
            product.TabIndex = 2;
            product.Text = "Product";
            product.TextAlign = ContentAlignment.MiddleLeft;
            product.UseVisualStyleBackColor = true;
            product.Click += product_Click;
            // 
            // panelsubproduct
            // 
            panelsubproduct.BackColor = Color.SlateBlue;
            panelsubproduct.Controls.Add(brand);
            panelsubproduct.Controls.Add(catagory);
            panelsubproduct.Controls.Add(productlist);
            panelsubproduct.Dock = DockStyle.Top;
            panelsubproduct.Location = new Point(3, 215);
            panelsubproduct.Name = "panelsubproduct";
            panelsubproduct.Size = new Size(198, 131);
            panelsubproduct.TabIndex = 3;
            // 
            // brand
            // 
            brand.Dock = DockStyle.Top;
            brand.FlatAppearance.BorderSize = 0;
            brand.FlatStyle = FlatStyle.Flat;
            brand.Location = new Point(0, 90);
            brand.Name = "brand";
            brand.Padding = new Padding(0, 0, 40, 0);
            brand.Size = new Size(198, 45);
            brand.TabIndex = 5;
            brand.Text = "Brand";
            brand.UseVisualStyleBackColor = true;
            brand.Click += brand_Click;
            // 
            // catagory
            // 
            catagory.Dock = DockStyle.Top;
            catagory.FlatAppearance.BorderSize = 0;
            catagory.FlatStyle = FlatStyle.Flat;
            catagory.Location = new Point(0, 48);
            catagory.Name = "catagory";
            catagory.Padding = new Padding(0, 0, 17, 0);
            catagory.Size = new Size(198, 42);
            catagory.TabIndex = 4;
            catagory.Text = "Catagory";
            catagory.UseVisualStyleBackColor = true;
            catagory.Click += catagory_Click;
            // 
            // productlist
            // 
            productlist.Dock = DockStyle.Top;
            productlist.FlatAppearance.BorderSize = 0;
            productlist.FlatStyle = FlatStyle.Flat;
            productlist.Location = new Point(0, 0);
            productlist.Name = "productlist";
            productlist.Size = new Size(198, 48);
            productlist.TabIndex = 3;
            productlist.Text = "Product List";
            productlist.UseVisualStyleBackColor = true;
            productlist.Click += productlist_Click;
            // 
            // stock
            // 
            stock.Dock = DockStyle.Top;
            stock.FlatAppearance.BorderSize = 0;
            stock.FlatStyle = FlatStyle.Flat;
            stock.Location = new Point(3, 352);
            stock.Name = "stock";
            stock.Size = new Size(201, 47);
            stock.TabIndex = 4;
            stock.Text = "Stock";
            stock.TextAlign = ContentAlignment.MiddleLeft;
            stock.UseVisualStyleBackColor = true;
            stock.Click += stock_Click;
            // 
            // panelsubstock
            // 
            panelsubstock.BackColor = Color.SlateBlue;
            panelsubstock.Controls.Add(stockadjustment);
            panelsubstock.Controls.Add(instock);
            panelsubstock.Dock = DockStyle.Top;
            panelsubstock.Location = new Point(3, 405);
            panelsubstock.Name = "panelsubstock";
            panelsubstock.Size = new Size(198, 92);
            panelsubstock.TabIndex = 5;
            // 
            // stockadjustment
            // 
            stockadjustment.Dock = DockStyle.Top;
            stockadjustment.FlatAppearance.BorderSize = 0;
            stockadjustment.FlatStyle = FlatStyle.Flat;
            stockadjustment.Location = new Point(0, 46);
            stockadjustment.Name = "stockadjustment";
            stockadjustment.Size = new Size(198, 46);
            stockadjustment.TabIndex = 4;
            stockadjustment.Text = "Stock Adjustment";
            stockadjustment.UseVisualStyleBackColor = true;
            stockadjustment.Click += stockadjustment_Click;
            // 
            // instock
            // 
            instock.Dock = DockStyle.Top;
            instock.FlatAppearance.BorderSize = 0;
            instock.FlatStyle = FlatStyle.Flat;
            instock.Location = new Point(0, 0);
            instock.Name = "instock";
            instock.Size = new Size(198, 46);
            instock.TabIndex = 3;
            instock.Text = "In Stock";
            instock.UseVisualStyleBackColor = true;
            instock.Click += instock_Click;
            // 
            // supplier
            // 
            supplier.Dock = DockStyle.Top;
            supplier.FlatAppearance.BorderSize = 0;
            supplier.FlatStyle = FlatStyle.Flat;
            supplier.Location = new Point(3, 503);
            supplier.Name = "supplier";
            supplier.Size = new Size(201, 49);
            supplier.TabIndex = 6;
            supplier.Text = "Supplier";
            supplier.TextAlign = ContentAlignment.MiddleLeft;
            supplier.UseVisualStyleBackColor = true;
            supplier.Click += supplier_Click;
            // 
            // Record
            // 
            Record.Dock = DockStyle.Top;
            Record.FlatAppearance.BorderSize = 0;
            Record.FlatStyle = FlatStyle.Flat;
            Record.Location = new Point(3, 558);
            Record.Name = "Record";
            Record.Size = new Size(201, 47);
            Record.TabIndex = 7;
            Record.Text = "Record";
            Record.TextAlign = ContentAlignment.MiddleLeft;
            Record.UseVisualStyleBackColor = true;
            Record.Click += Record_Click;
            // 
            // panelsubrecord
            // 
            panelsubrecord.BackColor = Color.SlateBlue;
            panelsubrecord.Controls.Add(history);
            panelsubrecord.Controls.Add(soldlist);
            panelsubrecord.Dock = DockStyle.Top;
            panelsubrecord.Location = new Point(3, 611);
            panelsubrecord.Name = "panelsubrecord";
            panelsubrecord.Size = new Size(198, 86);
            panelsubrecord.TabIndex = 8;
            // 
            // history
            // 
            history.Dock = DockStyle.Top;
            history.FlatAppearance.BorderSize = 0;
            history.FlatStyle = FlatStyle.Flat;
            history.Location = new Point(0, 38);
            history.Name = "history";
            history.Padding = new Padding(0, 0, 17, 0);
            history.Size = new Size(198, 48);
            history.TabIndex = 4;
            history.Text = "History";
            history.UseVisualStyleBackColor = true;
            history.Click += history_Click;
            // 
            // soldlist
            // 
            soldlist.Dock = DockStyle.Top;
            soldlist.FlatAppearance.BorderSize = 0;
            soldlist.FlatStyle = FlatStyle.Flat;
            soldlist.Location = new Point(0, 0);
            soldlist.Name = "soldlist";
            soldlist.Padding = new Padding(0, 0, 15, 0);
            soldlist.Size = new Size(198, 38);
            soldlist.TabIndex = 3;
            soldlist.Text = "Sold list";
            soldlist.UseVisualStyleBackColor = true;
            soldlist.Click += soldlist_Click;
            // 
            // settings
            // 
            settings.Dock = DockStyle.Top;
            settings.FlatAppearance.BorderSize = 0;
            settings.FlatStyle = FlatStyle.Flat;
            settings.Location = new Point(3, 703);
            settings.Name = "settings";
            settings.Size = new Size(201, 49);
            settings.TabIndex = 9;
            settings.Text = "Settings";
            settings.TextAlign = ContentAlignment.MiddleLeft;
            settings.UseVisualStyleBackColor = true;
            settings.Click += settings_Click;
            // 
            // panelsubsetting
            // 
            panelsubsetting.BackColor = Color.SlateBlue;
            panelsubsetting.Controls.Add(posrecord);
            panelsubsetting.Controls.Add(user);
            panelsubsetting.Dock = DockStyle.Top;
            panelsubsetting.Location = new Point(3, 758);
            panelsubsetting.Name = "panelsubsetting";
            panelsubsetting.Size = new Size(198, 86);
            panelsubsetting.TabIndex = 10;
            // 
            // posrecord
            // 
            posrecord.Dock = DockStyle.Top;
            posrecord.FlatAppearance.BorderSize = 0;
            posrecord.FlatStyle = FlatStyle.Flat;
            posrecord.Location = new Point(0, 38);
            posrecord.Name = "posrecord";
            posrecord.Padding = new Padding(20, 0, 0, 0);
            posrecord.Size = new Size(198, 48);
            posrecord.TabIndex = 4;
            posrecord.Text = "POS Record";
            posrecord.UseVisualStyleBackColor = true;
            posrecord.Click += posrecord_Click;
            // 
            // user
            // 
            user.Dock = DockStyle.Top;
            user.FlatAppearance.BorderSize = 0;
            user.FlatStyle = FlatStyle.Flat;
            user.Location = new Point(0, 0);
            user.Name = "user";
            user.Padding = new Padding(0, 0, 40, 0);
            user.Size = new Size(198, 38);
            user.TabIndex = 3;
            user.Text = "User";
            user.UseVisualStyleBackColor = true;
            user.Click += user_Click;
            // 
            // logout
            // 
            logout.Dock = DockStyle.Top;
            logout.FlatAppearance.BorderSize = 0;
            logout.FlatStyle = FlatStyle.Flat;
            logout.Location = new Point(3, 850);
            logout.Name = "logout";
            logout.Size = new Size(201, 50);
            logout.TabIndex = 11;
            logout.Text = "Log Out";
            logout.TextAlign = ContentAlignment.MiddleLeft;
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // paneltitle
            // 
            paneltitle.BackColor = Color.DarkSlateBlue;
            paneltitle.Controls.Add(lbltittle);
            paneltitle.Dock = DockStyle.Top;
            paneltitle.Location = new Point(199, 0);
            paneltitle.Name = "paneltitle";
            paneltitle.Size = new Size(885, 48);
            paneltitle.TabIndex = 1;
            // 
            // lbltittle
            // 
            lbltittle.AutoSize = true;
            lbltittle.Location = new Point(383, 9);
            lbltittle.Name = "lbltittle";
            lbltittle.Size = new Size(48, 22);
            lbltittle.TabIndex = 0;
            lbltittle.Text = "Tittle";
            lbltittle.Click += lbltittle_Click;
            // 
            // panelmain
            // 
            panelmain.BackColor = Color.White;
            panelmain.Dock = DockStyle.Fill;
            panelmain.ForeColor = SystemColors.ActiveCaptionText;
            panelmain.Location = new Point(199, 48);
            panelmain.Name = "panelmain";
            panelmain.Size = new Size(885, 566);
            panelmain.TabIndex = 2;
            panelmain.Paint += panelmain_Paint;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(1084, 614);
            Controls.Add(panelmain);
            Controls.Add(paneltitle);
            Controls.Add(panelishide);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonHighlight;
            Margin = new Padding(4, 3, 4, 3);
            Name = "dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboard";
            panelishide.ResumeLayout(false);
            panellogo.ResumeLayout(false);
            panellogo.PerformLayout();
            panelsubproduct.ResumeLayout(false);
            panelsubstock.ResumeLayout(false);
            panelsubrecord.ResumeLayout(false);
            panelsubsetting.ResumeLayout(false);
            paneltitle.ResumeLayout(false);
            paneltitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panelishide;
        private Panel panellogo;
        private Panel paneltitle;
        private Button dashboardbutton;
        private Panel panelmain;
        private Button product;
        private Panel panelsubproduct;
        private Button brand;
        private Button catagory;
        private Button productlist;
        private Button stock;
        private Panel panelsubstock;
        private Button stockadjustment;
        private Button instock;
        private Button supplier;
        private Button Record;
        private Panel panelsubrecord;
        private Button history;
        private Button soldlist;
        private Button settings;
        private Panel panelsubsetting;
        private Button posrecord;
        private Button user;
        private Button logout;
        private Label label1;
        private Label lbltittle;
    }
}