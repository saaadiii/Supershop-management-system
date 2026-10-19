namespace Supershop
{
    partial class user
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            role = new ComboBox();
            pass = new MaskedTextBox();
            retypepass = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            username = new MaskedTextBox();
            Cancelbtn = new Button();
            Savebtn = new Button();
            tabPage2 = new TabPage();
            textBox2 = new TextBox();
            cancel = new Button();
            save = new Button();
            txtcurrentpass = new MaskedTextBox();
            currentpassword = new Label();
            newpass = new Label();
            txtnewpass = new MaskedTextBox();
            txtrepass = new MaskedTextBox();
            label6 = new Label();
            label8 = new Label();
            txtusername = new MaskedTextBox();
            tabPage3 = new TabPage();
            textBox1 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Font = new Font("Tw Cen MT Condensed", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, -2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1002, 542);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Lavender;
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(role);
            tabPage1.Controls.Add(pass);
            tabPage1.Controls.Add(retypepass);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(username);
            tabPage1.Controls.Add(Cancelbtn);
            tabPage1.Controls.Add(Savebtn);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(994, 508);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Create Account";
            // 
            // role
            // 
            role.ForeColor = SystemColors.ActiveCaptionText;
            role.FormattingEnabled = true;
            role.Items.AddRange(new object[] { "Admin", "Cashier" });
            role.Location = new Point(287, 300);
            role.Name = "role";
            role.Size = new Size(439, 29);
            role.TabIndex = 17;
            role.SelectedIndexChanged += role_SelectedIndexChanged;
            // 
            // pass
            // 
            pass.ForeColor = SystemColors.ActiveCaptionText;
            pass.Location = new Point(287, 175);
            pass.Name = "pass";
            pass.Size = new Size(439, 27);
            pass.TabIndex = 16;
            pass.MaskInputRejected += pass_MaskInputRejected;
            // 
            // retypepass
            // 
            retypepass.ForeColor = SystemColors.ActiveCaptionText;
            retypepass.Location = new Point(287, 233);
            retypepass.Name = "retypepass";
            retypepass.Size = new Size(439, 27);
            retypepass.TabIndex = 15;
            retypepass.MaskInputRejected += retypepass_MaskInputRejected;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT Condensed", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(144, 300);
            label5.Name = "label5";
            label5.Size = new Size(45, 23);
            label5.TabIndex = 12;
            label5.Text = "Role:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT Condensed", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(144, 233);
            label4.Name = "label4";
            label4.Size = new Size(141, 23);
            label4.TabIndex = 11;
            label4.Text = "Re-Type Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT Condensed", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(144, 178);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 10;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT Condensed", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(144, 122);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 9;
            label2.Text = "Username:";
            // 
            // username
            // 
            username.ForeColor = SystemColors.ActiveCaptionText;
            username.Location = new Point(287, 122);
            username.Name = "username";
            username.Size = new Size(439, 27);
            username.TabIndex = 8;
            username.MaskInputRejected += username_MaskInputRejected;
            // 
            // Cancelbtn
            // 
            Cancelbtn.BackColor = Color.Crimson;
            Cancelbtn.FlatAppearance.BorderSize = 2;
            Cancelbtn.FlatAppearance.MouseDownBackColor = Color.Red;
            Cancelbtn.FlatAppearance.MouseOverBackColor = Color.Red;
            Cancelbtn.FlatStyle = FlatStyle.Flat;
            Cancelbtn.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancelbtn.ForeColor = SystemColors.ButtonHighlight;
            Cancelbtn.Location = new Point(621, 418);
            Cancelbtn.Name = "Cancelbtn";
            Cancelbtn.Size = new Size(105, 35);
            Cancelbtn.TabIndex = 7;
            Cancelbtn.Text = "Cancel";
            Cancelbtn.UseVisualStyleBackColor = false;
            Cancelbtn.Click += Cancelbtn_Click;
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
            Savebtn.Location = new Point(513, 418);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(102, 35);
            Savebtn.TabIndex = 6;
            Savebtn.Text = "Save";
            Savebtn.UseVisualStyleBackColor = false;
            Savebtn.Click += Savebtn_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Lavender;
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(cancel);
            tabPage2.Controls.Add(save);
            tabPage2.Controls.Add(txtcurrentpass);
            tabPage2.Controls.Add(currentpassword);
            tabPage2.Controls.Add(newpass);
            tabPage2.Controls.Add(txtnewpass);
            tabPage2.Controls.Add(txtrepass);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(txtusername);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(994, 508);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Change Password";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Lavender;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.ActiveCaptionText;
            textBox2.Location = new Point(392, 43);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 25);
            textBox2.TabIndex = 0;
            textBox2.Text = "Manage Accounts";
            // 
            // cancel
            // 
            cancel.BackColor = Color.Crimson;
            cancel.FlatAppearance.BorderSize = 2;
            cancel.FlatAppearance.MouseDownBackColor = Color.Red;
            cancel.FlatAppearance.MouseOverBackColor = Color.Red;
            cancel.FlatStyle = FlatStyle.Flat;
            cancel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancel.ForeColor = SystemColors.ButtonHighlight;
            cancel.Location = new Point(629, 419);
            cancel.Name = "cancel";
            cancel.Size = new Size(105, 35);
            cancel.TabIndex = 28;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = false;
            cancel.Click += cancel_Click;
            // 
            // save
            // 
            save.BackColor = Color.CornflowerBlue;
            save.FlatAppearance.BorderSize = 2;
            save.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            save.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            save.FlatStyle = FlatStyle.Flat;
            save.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            save.ForeColor = SystemColors.ButtonHighlight;
            save.Location = new Point(521, 419);
            save.Name = "save";
            save.Size = new Size(102, 35);
            save.TabIndex = 27;
            save.Text = "Save";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            // 
            // txtcurrentpass
            // 
            txtcurrentpass.ForeColor = SystemColors.ActiveCaptionText;
            txtcurrentpass.Location = new Point(347, 175);
            txtcurrentpass.Name = "txtcurrentpass";
            txtcurrentpass.Size = new Size(387, 27);
            txtcurrentpass.TabIndex = 26;
            txtcurrentpass.MaskInputRejected += txtcurrentpass_MaskInputRejected;
            // 
            // currentpassword
            // 
            currentpassword.AutoSize = true;
            currentpassword.Font = new Font("Tw Cen MT Condensed", 12F, FontStyle.Bold);
            currentpassword.ForeColor = SystemColors.ActiveCaptionText;
            currentpassword.Location = new Point(141, 178);
            currentpassword.Name = "currentpassword";
            currentpassword.Size = new Size(139, 23);
            currentpassword.TabIndex = 25;
            currentpassword.Text = "Current Password:";
            // 
            // newpass
            // 
            newpass.AutoSize = true;
            newpass.Font = new Font("Tw Cen MT Condensed", 12F, FontStyle.Bold);
            newpass.ForeColor = SystemColors.ActiveCaptionText;
            newpass.Location = new Point(141, 234);
            newpass.Name = "newpass";
            newpass.Size = new Size(117, 23);
            newpass.TabIndex = 24;
            newpass.Text = "New Password:";
            // 
            // txtnewpass
            // 
            txtnewpass.ForeColor = SystemColors.ActiveCaptionText;
            txtnewpass.Location = new Point(347, 228);
            txtnewpass.Name = "txtnewpass";
            txtnewpass.Size = new Size(387, 27);
            txtnewpass.TabIndex = 23;
            txtnewpass.MaskInputRejected += txtnewpass_MaskInputRejected;
            // 
            // txtrepass
            // 
            txtrepass.ForeColor = SystemColors.ActiveCaptionText;
            txtrepass.Location = new Point(347, 290);
            txtrepass.Name = "txtrepass";
            txtrepass.Size = new Size(387, 27);
            txtrepass.TabIndex = 21;
            txtrepass.MaskInputRejected += txtrepass_MaskInputRejected;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT Condensed", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(141, 290);
            label6.Name = "label6";
            label6.Size = new Size(141, 23);
            label6.TabIndex = 20;
            label6.Text = "Re-Type Password:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT Condensed", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(141, 124);
            label8.Name = "label8";
            label8.Size = new Size(85, 23);
            label8.TabIndex = 18;
            label8.Text = "Username:";
            // 
            // txtusername
            // 
            txtusername.ForeColor = SystemColors.ActiveCaptionText;
            txtusername.Location = new Point(347, 121);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(387, 27);
            txtusername.TabIndex = 17;
            txtusername.MaskInputRejected += txtusername_MaskInputRejected;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.InactiveBorder;
            tabPage3.Location = new Point(4, 30);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(994, 508);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Activate/Deactivate Account";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Lavender;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ActiveCaptionText;
            textBox1.Location = new Point(388, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 25);
            textBox1.TabIndex = 18;
            textBox1.Text = "Manage Accounts";
            // 
            // user
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1002, 540);
            Controls.Add(tabControl1);
            Name = "user";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "user";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private MaskedTextBox username;
        public Button Cancelbtn;
        public Button Savebtn;
        private MaskedTextBox pass;
        private MaskedTextBox retypepass;
        private ComboBox role;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox txtrepass;
        private Label label6;
        private Label label7;
        private Label label8;
        private MaskedTextBox txtusername;
        private Label newpass;
        private MaskedTextBox txtnewpass;
        private Label currentpassword;
        private MaskedTextBox txtcurrentpass;
        public Button cancel;
        public Button save;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}