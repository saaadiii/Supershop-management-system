namespace Supershop
{
    partial class supplier
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supplier));
            dgvsupplier = new DataGridView();
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            ID = new DataGridViewTextBoxColumn();
            No = new DataGridViewTextBoxColumn();
            Pcode = new DataGridViewTextBoxColumn();
            Barcode = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Brand = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dgvsupplier).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvsupplier
            // 
            dgvsupplier.AllowUserToAddRows = false;
            dgvsupplier.BackgroundColor = SystemColors.InactiveBorder;
            dgvsupplier.ColumnHeadersHeight = 30;
            dgvsupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvsupplier.Columns.AddRange(new DataGridViewColumn[] { ID, No, Pcode, Barcode, Description, Brand, Category, Price, Edit, Delete });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Lavender;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvsupplier.DefaultCellStyle = dataGridViewCellStyle1;
            dgvsupplier.Dock = DockStyle.Fill;
            dgvsupplier.EnableHeadersVisualStyles = false;
            dgvsupplier.Location = new Point(0, 0);
            dgvsupplier.Name = "dgvsupplier";
            dgvsupplier.RowHeadersVisible = false;
            dgvsupplier.RowHeadersWidth = 51;
            dgvsupplier.Size = new Size(1020, 519);
            dgvsupplier.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 519);
            panel1.Name = "panel1";
            panel1.Size = new Size(1020, 88);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Lavender;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(923, 28);
            button1.Name = "button1";
            button1.Size = new Size(70, 42);
            button1.TabIndex = 2;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(39, 28);
            label1.Name = "label1";
            label1.Size = new Size(160, 22);
            label1.TabIndex = 1;
            label1.Text = "Manage Supplier";
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Visible = false;
            ID.Width = 125;
            // 
            // No
            // 
            No.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            No.HeaderText = "No";
            No.MinimumWidth = 6;
            No.Name = "No";
            No.Width = 58;
            // 
            // Pcode
            // 
            Pcode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Pcode.HeaderText = "Supplier";
            Pcode.MinimumWidth = 6;
            Pcode.Name = "Pcode";
            Pcode.Visible = false;
            Pcode.Width = 93;
            // 
            // Barcode
            // 
            Barcode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Barcode.HeaderText = "Address";
            Barcode.MinimumWidth = 6;
            Barcode.Name = "Barcode";
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Description.HeaderText = "Contact Person";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.Width = 136;
            // 
            // Brand
            // 
            Brand.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Brand.HeaderText = "Phone";
            Brand.MinimumWidth = 6;
            Brand.Name = "Brand";
            Brand.Width = 79;
            // 
            // Category
            // 
            Category.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Category.HeaderText = "Email";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.Width = 75;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Price.HeaderText = "Fax";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 59;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "";
            Edit.Image = (Image)resources.GetObject("Edit.Image");
            Edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Width = 6;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Width = 6;
            // 
            // supplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1020, 607);
            ControlBox = false;
            Controls.Add(dgvsupplier);
            Controls.Add(panel1);
            Name = "supplier";
            Text = "Supplier";
            ((System.ComponentModel.ISupportInitialize)dgvsupplier).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvsupplier;
        private Panel panel1;
        private Button button1;
        private Label label1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn Pcode;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}