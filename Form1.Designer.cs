namespace Supershop
{
    partial class Homepage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label11 = new Label();
            login_selectrole = new ComboBox();
            login_showpass = new CheckBox();
            exit = new Label();
            login = new Button();
            forgotpass = new LinkLabel();
            login_signup = new LinkLabel();
            login_password = new MaskedTextBox();
            login_username = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 173);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(395, 377);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(login_selectrole);
            panel1.Controls.Add(login_showpass);
            panel1.Controls.Add(exit);
            panel1.Controls.Add(login);
            panel1.Controls.Add(forgotpass);
            panel1.Controls.Add(login_signup);
            panel1.Controls.Add(login_password);
            panel1.Controls.Add(login_username);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(450, -11);
            panel1.Name = "panel1";
            panel1.Size = new Size(577, 659);
            panel1.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(45, 152);
            label11.Name = "label11";
            label11.Size = new Size(135, 21);
            label11.TabIndex = 13;
            label11.Text = "Select your role";
            label11.Click += label11_Click;
            // 
            // login_selectrole
            // 
            login_selectrole.ForeColor = SystemColors.WindowText;
            login_selectrole.FormattingEnabled = true;
            login_selectrole.Items.AddRange(new object[] { "Admin", "Manager", "Cashier", "Customer" });
            login_selectrole.Location = new Point(44, 184);
            login_selectrole.Name = "login_selectrole";
            login_selectrole.Size = new Size(313, 29);
            login_selectrole.TabIndex = 12;
            login_selectrole.SelectedIndexChanged += selectrole_SelectedIndexChanged;
            // 
            // login_showpass
            // 
            login_showpass.AutoSize = true;
            login_showpass.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_showpass.Location = new Point(288, 376);
            login_showpass.Name = "login_showpass";
            login_showpass.Size = new Size(69, 21);
            login_showpass.TabIndex = 11;
            login_showpass.Text = "Show ";
            login_showpass.UseVisualStyleBackColor = true;
            login_showpass.CheckedChanged += showpass_CheckedChanged;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.BorderStyle = BorderStyle.Fixed3D;
            exit.Cursor = Cursors.Hand;
            exit.Location = new Point(542, 20);
            exit.Name = "exit";
            exit.Size = new Size(22, 23);
            exit.TabIndex = 10;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // login
            // 
            login.Cursor = Cursors.Hand;
            login.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login.ForeColor = SystemColors.ActiveCaptionText;
            login.Location = new Point(46, 416);
            login.Name = "login";
            login.Size = new Size(186, 52);
            login.TabIndex = 9;
            login.Text = "Log In";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // forgotpass
            // 
            forgotpass.AutoSize = true;
            forgotpass.LinkColor = Color.White;
            forgotpass.Location = new Point(46, 526);
            forgotpass.Name = "forgotpass";
            forgotpass.Size = new Size(156, 21);
            forgotpass.TabIndex = 8;
            forgotpass.TabStop = true;
            forgotpass.Text = "Forgot Password?";
            // 
            // login_signup
            // 
            login_signup.AutoSize = true;
            login_signup.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_signup.LinkColor = Color.White;
            login_signup.Location = new Point(259, 490);
            login_signup.Name = "login_signup";
            login_signup.Size = new Size(63, 20);
            login_signup.TabIndex = 7;
            login_signup.TabStop = true;
            login_signup.Text = "Sign Up";
            login_signup.LinkClicked += linkLabel1_LinkClicked;
            // 
            // login_password
            // 
            login_password.Location = new Point(44, 342);
            login_password.Name = "login_password";
            login_password.Size = new Size(311, 28);
            login_password.TabIndex = 6;
            login_password.UseSystemPasswordChar = true;
            login_password.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // login_username
            // 
            login_username.Location = new Point(46, 258);
            login_username.Name = "login_username";
            login_username.Size = new Size(311, 28);
            login_username.TabIndex = 5;
            login_username.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 490);
            label5.Name = "label5";
            label5.Size = new Size(217, 21);
            label5.TabIndex = 4;
            label5.Text = "Don't have an account?";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 301);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 225);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(46, 123);
            label2.Name = "label2";
            label2.Size = new Size(347, 17);
            label2.TabIndex = 1;
            label2.Text = "Welcome Back! log in to your account to continue...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(46, 70);
            label1.Name = "label1";
            label1.Size = new Size(72, 27);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(50, 35);
            label6.Name = "label6";
            label6.Size = new Size(329, 34);
            label6.TabIndex = 6;
            label6.Text = "Welcome to Supershop";
            label6.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(79, 69);
            label7.Name = "label7";
            label7.Size = new Size(256, 27);
            label7.TabIndex = 7;
            label7.Text = "Management System!\r\n";
            label7.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(79, 112);
            label8.Name = "label8";
            label8.Size = new Size(291, 20);
            label8.TabIndex = 8;
            label8.Text = "Smart Smart Management Starts Here...\r\n";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(49, 132);
            label9.Name = "label9";
            label9.Size = new Size(371, 20);
            label9.TabIndex = 9;
            label9.Text = "Log in to monitor inventory, track sales, and keep \r\n";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(91, 152);
            label10.Name = "label10";
            label10.Size = new Size(244, 20);
            label10.TabIndex = 10;
            label10.Text = "your supermall running smoothly!";
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1024, 569);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Location = new Point(5, 5);
            Name = "Homepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private MaskedTextBox login_password;
        private MaskedTextBox login_username;
        private Label label5;
        private Label label4;
        private Label label3;
        private LinkLabel forgotpass;
        private LinkLabel login_signup;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button login;
        private Label exit;
        private CheckBox login_showpass;
        private Label label11;
        private ComboBox login_selectrole;
    }
}
