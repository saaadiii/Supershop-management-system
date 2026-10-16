namespace Supershop
{
    partial class productModule
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
            panel1 = new Panel();
            cancelbtn = new Button();
            label1 = new Label();
            productcodebtn = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            barcodebox = new TextBox();
            descriptionbox = new TextBox();
            brandcombobox = new ComboBox();
            categorycombobox = new ComboBox();
            pricebox = new TextBox();
            reordernumericupdown = new NumericUpDown();
            Savebtn = new Button();
            Csncelbtn = new Button();
            updatebtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reordernumericupdown).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Controls.Add(cancelbtn);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 73);
            panel1.TabIndex = 0;
            // 
            // cancelbtn
            // 
            cancelbtn.FlatStyle = FlatStyle.Flat;
            cancelbtn.ForeColor = SystemColors.ButtonHighlight;
            cancelbtn.Location = new Point(670, 17);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(30, 27);
            cancelbtn.TabIndex = 2;
            cancelbtn.Text = "X";
            cancelbtn.UseVisualStyleBackColor = true;
            cancelbtn.Click += cancelbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(29, 31);
            label1.Name = "label1";
            label1.Size = new Size(150, 22);
            label1.TabIndex = 1;
            label1.Text = "Product Module";
            // 
            // productcodebtn
            // 
            productcodebtn.BackColor = Color.WhiteSmoke;
            productcodebtn.Location = new Point(170, 109);
            productcodebtn.Name = "productcodebtn";
            productcodebtn.Size = new Size(186, 27);
            productcodebtn.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(26, 110);
            label2.Name = "label2";
            label2.Size = new Size(138, 22);
            label2.TabIndex = 4;
            label2.Text = "Product Code:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(378, 218);
            label3.Name = "label3";
            label3.Size = new Size(98, 22);
            label3.TabIndex = 5;
            label3.Text = "Category:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(98, 218);
            label4.Name = "label4";
            label4.Size = new Size(66, 22);
            label4.TabIndex = 6;
            label4.Text = "Brand:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(50, 164);
            label5.Name = "label5";
            label5.Size = new Size(114, 22);
            label5.TabIndex = 7;
            label5.Text = "Description:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(378, 109);
            label6.Name = "label6";
            label6.Size = new Size(91, 22);
            label6.TabIndex = 8;
            label6.Text = "Barcode:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(105, 284);
            label7.Name = "label7";
            label7.Size = new Size(59, 22);
            label7.TabIndex = 9;
            label7.Text = "Price:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(378, 284);
            label8.Name = "label8";
            label8.Size = new Size(147, 22);
            label8.TabIndex = 10;
            label8.Text = "Re-Order Level:";
            // 
            // barcodebox
            // 
            barcodebox.BackColor = Color.WhiteSmoke;
            barcodebox.Location = new Point(496, 105);
            barcodebox.Name = "barcodebox";
            barcodebox.Size = new Size(163, 27);
            barcodebox.TabIndex = 11;
            // 
            // descriptionbox
            // 
            descriptionbox.BackColor = Color.WhiteSmoke;
            descriptionbox.Location = new Point(170, 164);
            descriptionbox.Name = "descriptionbox";
            descriptionbox.Size = new Size(489, 27);
            descriptionbox.TabIndex = 12;
            // 
            // brandcombobox
            // 
            brandcombobox.FormattingEnabled = true;
            brandcombobox.Location = new Point(170, 218);
            brandcombobox.Name = "brandcombobox";
            brandcombobox.Size = new Size(186, 28);
            brandcombobox.TabIndex = 13;
            // 
            // categorycombobox
            // 
            categorycombobox.FormattingEnabled = true;
            categorycombobox.Location = new Point(496, 218);
            categorycombobox.Name = "categorycombobox";
            categorycombobox.Size = new Size(163, 28);
            categorycombobox.TabIndex = 14;
            // 
            // pricebox
            // 
            pricebox.BackColor = Color.WhiteSmoke;
            pricebox.Location = new Point(170, 284);
            pricebox.Name = "pricebox";
            pricebox.Size = new Size(186, 27);
            pricebox.TabIndex = 15;
            // 
            // reordernumericupdown
            // 
            reordernumericupdown.Location = new Point(531, 284);
            reordernumericupdown.Name = "reordernumericupdown";
            reordernumericupdown.Size = new Size(128, 27);
            reordernumericupdown.TabIndex = 16;
            // 
            // Savebtn
            // 
            Savebtn.BackColor = Color.CornflowerBlue;
            Savebtn.FlatAppearance.BorderSize = 2;
            Savebtn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            Savebtn.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            Savebtn.FlatStyle = FlatStyle.Flat;
            Savebtn.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Savebtn.ForeColor = SystemColors.ButtonHighlight;
            Savebtn.Location = new Point(340, 357);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(102, 35);
            Savebtn.TabIndex = 17;
            Savebtn.Text = "Save";
            Savebtn.UseVisualStyleBackColor = false;
            Savebtn.Click += Savebtn_Click;
            // 
            // Csncelbtn
            // 
            Csncelbtn.BackColor = Color.Crimson;
            Csncelbtn.FlatAppearance.BorderSize = 2;
            Csncelbtn.FlatAppearance.MouseDownBackColor = Color.Red;
            Csncelbtn.FlatAppearance.MouseOverBackColor = Color.Red;
            Csncelbtn.FlatStyle = FlatStyle.Flat;
            Csncelbtn.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Csncelbtn.ForeColor = SystemColors.ButtonHighlight;
            Csncelbtn.Location = new Point(448, 357);
            Csncelbtn.Name = "Csncelbtn";
            Csncelbtn.Size = new Size(105, 35);
            Csncelbtn.TabIndex = 18;
            Csncelbtn.Text = "Clear";
            Csncelbtn.UseVisualStyleBackColor = false;
            Csncelbtn.Click += Csncelbtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.MediumAquamarine;
            updatebtn.FlatAppearance.BorderSize = 2;
            updatebtn.FlatAppearance.MouseDownBackColor = Color.LawnGreen;
            updatebtn.FlatAppearance.MouseOverBackColor = Color.LawnGreen;
            updatebtn.FlatStyle = FlatStyle.Flat;
            updatebtn.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updatebtn.ForeColor = SystemColors.ButtonHighlight;
            updatebtn.Location = new Point(559, 357);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(100, 35);
            updatebtn.TabIndex = 19;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // productModule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(709, 431);
            Controls.Add(updatebtn);
            Controls.Add(Csncelbtn);
            Controls.Add(Savebtn);
            Controls.Add(reordernumericupdown);
            Controls.Add(pricebox);
            Controls.Add(categorycombobox);
            Controls.Add(brandcombobox);
            Controls.Add(descriptionbox);
            Controls.Add(barcodebox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(productcodebtn);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "productModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "productModule";
            Load += productModule_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)reordernumericupdown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        public TextBox productcodebtn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        public TextBox barcodebox;
        public TextBox descriptionbox;
        private ComboBox brandcombobox;
        private ComboBox categorycombobox;
        public TextBox pricebox;
        public NumericUpDown reordernumericupdown;
        public Button Savebtn;
        public Button Csncelbtn;
        public Button updatebtn;
        private Button cancelbtn;
    }
}