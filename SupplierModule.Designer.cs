namespace Supershop
{
    partial class SupplierModule
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
            updatebtn = new Button();
            Csncelbtn = new Button();
            Savebtn = new Button();
            label2 = new Label();
            txtsupplier = new TextBox();
            cancelbtn = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textadd = new TextBox();
            textcontact = new TextBox();
            textphn = new TextBox();
            textemail = new TextBox();
            textfax = new TextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
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
            updatebtn.Location = new Point(536, 396);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(100, 35);
            updatebtn.TabIndex = 37;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
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
            Csncelbtn.Location = new Point(425, 396);
            Csncelbtn.Name = "Csncelbtn";
            Csncelbtn.Size = new Size(105, 35);
            Csncelbtn.TabIndex = 36;
            Csncelbtn.Text = "Clear";
            Csncelbtn.UseVisualStyleBackColor = false;
            Csncelbtn.Click += Csncelbtn_Click;
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
            Savebtn.Location = new Point(317, 396);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(102, 35);
            Savebtn.TabIndex = 35;
            Savebtn.Text = "Save";
            Savebtn.UseVisualStyleBackColor = false;
            Savebtn.Click += Savebtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(20, 107);
            label2.Name = "label2";
            label2.Size = new Size(144, 22);
            label2.TabIndex = 22;
            label2.Text = "Supplier Name:";
            label2.Click += label2_Click;
            // 
            // txtsupplier
            // 
            txtsupplier.BackColor = Color.WhiteSmoke;
            txtsupplier.Location = new Point(178, 107);
            txtsupplier.Name = "txtsupplier";
            txtsupplier.Size = new Size(443, 26);
            txtsupplier.TabIndex = 21;
            txtsupplier.TextChanged += productcodebtn_TextChanged;
            // 
            // cancelbtn
            // 
            cancelbtn.FlatStyle = FlatStyle.Flat;
            cancelbtn.ForeColor = SystemColors.ButtonHighlight;
            cancelbtn.Location = new Point(673, 25);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(30, 27);
            cancelbtn.TabIndex = 2;
            cancelbtn.Text = "X";
            cancelbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(39, 30);
            label1.Name = "label1";
            label1.Size = new Size(152, 22);
            label1.TabIndex = 1;
            label1.Text = "Supplier Module";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(cancelbtn);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-27, -13);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 73);
            panel1.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(22, 204);
            label3.Name = "label3";
            label3.Size = new Size(150, 22);
            label3.TabIndex = 38;
            label3.Text = "Contact Person:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(20, 153);
            label4.Name = "label4";
            label4.Size = new Size(86, 22);
            label4.TabIndex = 39;
            label4.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(22, 265);
            label5.Name = "label5";
            label5.Size = new Size(99, 22);
            label5.TabIndex = 40;
            label5.Text = "Phone no.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(20, 321);
            label6.Name = "label6";
            label6.Size = new Size(61, 22);
            label6.TabIndex = 41;
            label6.Text = "Email:";
            // 
            // textadd
            // 
            textadd.BackColor = Color.WhiteSmoke;
            textadd.Location = new Point(178, 152);
            textadd.Name = "textadd";
            textadd.Size = new Size(443, 26);
            textadd.TabIndex = 42;
            textadd.TextChanged += textadd_TextChanged;
            // 
            // textcontact
            // 
            textcontact.BackColor = Color.WhiteSmoke;
            textcontact.Location = new Point(178, 203);
            textcontact.Name = "textcontact";
            textcontact.Size = new Size(443, 26);
            textcontact.TabIndex = 43;
            textcontact.TextChanged += textcontact_TextChanged;
            // 
            // textphn
            // 
            textphn.BackColor = Color.WhiteSmoke;
            textphn.Location = new Point(178, 261);
            textphn.Name = "textphn";
            textphn.Size = new Size(443, 26);
            textphn.TabIndex = 44;
            textphn.TextChanged += textphn_TextChanged;
            // 
            // textemail
            // 
            textemail.BackColor = Color.WhiteSmoke;
            textemail.Location = new Point(178, 317);
            textemail.Name = "textemail";
            textemail.Size = new Size(212, 26);
            textemail.TabIndex = 45;
            textemail.TextChanged += textemail_TextChanged;
            // 
            // textfax
            // 
            textfax.BackColor = Color.WhiteSmoke;
            textfax.Location = new Point(448, 317);
            textfax.Name = "textfax";
            textfax.Size = new Size(173, 26);
            textfax.TabIndex = 46;
            textfax.TextChanged += textfax_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(396, 321);
            label7.Name = "label7";
            label7.Size = new Size(46, 22);
            label7.TabIndex = 47;
            label7.Text = "Fax:";
            // 
            // SupplierModule
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(688, 443);
            Controls.Add(label7);
            Controls.Add(textfax);
            Controls.Add(textemail);
            Controls.Add(textphn);
            Controls.Add(textcontact);
            Controls.Add(textadd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(updatebtn);
            Controls.Add(Csncelbtn);
            Controls.Add(Savebtn);
            Controls.Add(label2);
            Controls.Add(txtsupplier);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SupplierModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SupplierModule";
           
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button updatebtn;
        public Button Csncelbtn;
        public Button Savebtn;
        private Label label2;
        public TextBox txtsupplier;
        private Button cancelbtn;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        public TextBox textadd;
        public TextBox textcontact;
        public TextBox textphn;
        public TextBox textemail;
        public TextBox textfax;
        private Label label7;
    }
}