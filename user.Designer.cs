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
            panel1 = new Panel();
            addbtn = new Button();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            comboBox1 = new ComboBox();
            maskedTextBox4 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            Csncelbtn = new Button();
            Savebtn = new Button();
            tabPage2 = new TabPage();
            newpass = new Label();
            txtnewpass = new MaskedTextBox();
            txtrepass = new MaskedTextBox();
            label6 = new Label();
            label8 = new Label();
            txtusername = new MaskedTextBox();
            tabPage3 = new TabPage();
            currentpassword = new Label();
            txtcurrentpass = new MaskedTextBox();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(addbtn);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Font = new Font("Tw Cen MT Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 456);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1002, 84);
            panel1.TabIndex = 4;
            // 
            // addbtn
            // 
            addbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addbtn.BackColor = Color.Lavender;
            addbtn.FlatAppearance.BorderColor = Color.White;
            addbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            addbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            addbtn.FlatStyle = FlatStyle.Flat;
            addbtn.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addbtn.Location = new Point(1574, 27);
            addbtn.Margin = new Padding(4);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(88, 40);
            addbtn.TabIndex = 2;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(49, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 22);
            label1.TabIndex = 1;
            label1.Text = "Manage Accounts";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Tw Cen MT Condensed", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1002, 449);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.InactiveBorder;
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(maskedTextBox4);
            tabPage1.Controls.Add(maskedTextBox3);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(maskedTextBox1);
            tabPage1.Controls.Add(Csncelbtn);
            tabPage1.Controls.Add(Savebtn);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(994, 415);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Create Account";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(234, 242);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(439, 29);
            comboBox1.TabIndex = 17;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(234, 117);
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(439, 27);
            maskedTextBox4.TabIndex = 16;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(234, 175);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(439, 27);
            maskedTextBox3.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 242);
            label5.Name = "label5";
            label5.Size = new Size(41, 21);
            label5.TabIndex = 12;
            label5.Text = "Role:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 175);
            label4.Name = "label4";
            label4.Size = new Size(128, 21);
            label4.TabIndex = 11;
            label4.Text = "Re-Type Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 120);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 10;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 64);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 9;
            label2.Text = "Username:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(234, 64);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(439, 27);
            maskedTextBox1.TabIndex = 8;
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
            Csncelbtn.Location = new Point(763, 362);
            Csncelbtn.Name = "Csncelbtn";
            Csncelbtn.Size = new Size(105, 35);
            Csncelbtn.TabIndex = 7;
            Csncelbtn.Text = "Cancel";
            Csncelbtn.UseVisualStyleBackColor = false;
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
            Savebtn.Location = new Point(655, 362);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(102, 35);
            Savebtn.TabIndex = 6;
            Savebtn.Text = "Save";
            Savebtn.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.InactiveBorder;
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(button2);
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
            tabPage2.Size = new Size(994, 415);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Change Password";
            // 
            // newpass
            // 
            newpass.AutoSize = true;
            newpass.Location = new Point(175, 169);
            newpass.Name = "newpass";
            newpass.Size = new Size(107, 21);
            newpass.TabIndex = 24;
            newpass.Text = "New Password:";
            // 
            // txtnewpass
            // 
            txtnewpass.Location = new Point(318, 169);
            txtnewpass.Name = "txtnewpass";
            txtnewpass.Size = new Size(439, 27);
            txtnewpass.TabIndex = 23;
            // 
            // txtrepass
            // 
            txtrepass.Location = new Point(318, 234);
            txtrepass.Name = "txtrepass";
            txtrepass.Size = new Size(439, 27);
            txtrepass.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(175, 234);
            label6.Name = "label6";
            label6.Size = new Size(128, 21);
            label6.TabIndex = 20;
            label6.Text = "Re-Type Password:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(175, 52);
            label8.Name = "label8";
            label8.Size = new Size(77, 21);
            label8.TabIndex = 18;
            label8.Text = "Username:";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(318, 52);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(439, 27);
            txtusername.TabIndex = 17;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.InactiveBorder;
            tabPage3.Location = new Point(4, 30);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(994, 415);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Activate/Deactivate Account";
            // 
            // currentpassword
            // 
            currentpassword.AutoSize = true;
            currentpassword.Location = new Point(175, 105);
            currentpassword.Name = "currentpassword";
            currentpassword.Size = new Size(128, 21);
            currentpassword.TabIndex = 25;
            currentpassword.Text = "Current Password:";
            // 
            // txtcurrentpass
            // 
            txtcurrentpass.Location = new Point(318, 107);
            txtcurrentpass.Name = "txtcurrentpass";
            txtcurrentpass.Size = new Size(439, 27);
            txtcurrentpass.TabIndex = 26;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.Red;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(841, 351);
            button1.Name = "button1";
            button1.Size = new Size(105, 35);
            button1.TabIndex = 28;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.CornflowerBlue;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            button2.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(733, 351);
            button2.Name = "button2";
            button2.Size = new Size(102, 35);
            button2.TabIndex = 27;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            // 
            // user
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1002, 540);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "user";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "user";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button addbtn;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        public Button Csncelbtn;
        public Button Savebtn;
        private MaskedTextBox maskedTextBox4;
        private MaskedTextBox maskedTextBox3;
        private ComboBox comboBox1;
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
        public Button button1;
        public Button button2;
    }
}