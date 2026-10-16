namespace Supershop
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            panel1 = new Panel();
            panel2 = new Panel();
            label7 = new Label();
            signup_email = new MaskedTextBox();
            signup_showpass = new CheckBox();
            exit = new Label();
            sign_up = new Button();
            signup_login = new LinkLabel();
            signup_password = new MaskedTextBox();
            signup_username = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            admin = new RadioButton();
            manager = new RadioButton();
            cashier = new RadioButton();
            customer = new RadioButton();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(469, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(540, 593);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateBlue;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(signup_email);
            panel2.Controls.Add(signup_showpass);
            panel2.Controls.Add(exit);
            panel2.Controls.Add(sign_up);
            panel2.Controls.Add(signup_login);
            panel2.Controls.Add(signup_password);
            panel2.Controls.Add(signup_username);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.ForeColor = SystemColors.ButtonHighlight;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(577, 659);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 206);
            label7.Name = "label7";
            label7.Size = new Size(52, 21);
            label7.TabIndex = 13;
            label7.Text = "Email";
            // 
            // signup_email
            // 
            signup_email.Location = new Point(55, 249);
            signup_email.Name = "signup_email";
            signup_email.Size = new Size(316, 28);
            signup_email.TabIndex = 12;
            signup_email.MaskInputRejected += email_MaskInputRejected;
            // 
            // signup_showpass
            // 
            signup_showpass.AutoSize = true;
            signup_showpass.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_showpass.Location = new Point(302, 376);
            signup_showpass.Name = "signup_showpass";
            signup_showpass.Size = new Size(69, 21);
            signup_showpass.TabIndex = 11;
            signup_showpass.Text = "Show ";
            signup_showpass.UseVisualStyleBackColor = true;
            signup_showpass.CheckedChanged += showpass_CheckedChanged;
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
            // 
            // sign_up
            // 
            sign_up.Cursor = Cursors.Hand;
            sign_up.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sign_up.ForeColor = SystemColors.ActiveCaptionText;
            sign_up.Location = new Point(55, 423);
            sign_up.Name = "sign_up";
            sign_up.Size = new Size(186, 52);
            sign_up.TabIndex = 9;
            sign_up.Text = "Sign Up";
            sign_up.UseVisualStyleBackColor = true;
            sign_up.Click += sign_Click;
            // 
            // signup_login
            // 
            signup_login.AutoSize = true;
            signup_login.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_login.LinkColor = Color.White;
            signup_login.Location = new Point(282, 501);
            signup_login.Name = "signup_login";
            signup_login.Size = new Size(52, 20);
            signup_login.TabIndex = 7;
            signup_login.TabStop = true;
            signup_login.Text = "Log in";
            signup_login.LinkClicked += linkLabel1_LinkClicked;
            // 
            // signup_password
            // 
            signup_password.Location = new Point(51, 342);
            signup_password.Name = "signup_password";
            signup_password.Size = new Size(316, 28);
            signup_password.TabIndex = 6;
            signup_password.UseSystemPasswordChar = true;
            signup_password.MaskInputRejected += Password_MaskInputRejected;
            // 
            // signup_username
            // 
            signup_username.Location = new Point(55, 153);
            signup_username.Name = "signup_username";
            signup_username.Size = new Size(316, 28);
            signup_username.TabIndex = 5;
            signup_username.MaskInputRejected += username_MaskInputRejected;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 501);
            label5.Name = "label5";
            label5.Size = new Size(237, 21);
            label5.TabIndex = 4;
            label5.Text = "Already have an account?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 303);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(53, 112);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(51, 64);
            label1.Name = "label1";
            label1.Size = new Size(95, 27);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(97, 37);
            label2.Name = "label2";
            label2.Size = new Size(274, 54);
            label2.TabIndex = 1;
            label2.Text = "Your journy starts here...\r\nTake the first step!";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(121, 127);
            label6.Name = "label6";
            label6.Size = new Size(53, 21);
            label6.TabIndex = 2;
            label6.Text = "Role:";
            // 
            // admin
            // 
            admin.AutoSize = true;
            admin.Location = new Point(180, 127);
            admin.Name = "admin";
            admin.Size = new Size(74, 24);
            admin.TabIndex = 3;
            admin.TabStop = true;
            admin.Text = "Admin";
            admin.UseVisualStyleBackColor = true;
            admin.CheckedChanged += admin_CheckedChanged;
            // 
            // manager
            // 
            manager.AutoSize = true;
            manager.Location = new Point(180, 157);
            manager.Name = "manager";
            manager.Size = new Size(89, 24);
            manager.TabIndex = 4;
            manager.TabStop = true;
            manager.Text = "Manager";
            manager.UseVisualStyleBackColor = true;
            manager.CheckedChanged += manager_CheckedChanged;
            // 
            // cashier
            // 
            cashier.AutoSize = true;
            cashier.Location = new Point(180, 187);
            cashier.Name = "cashier";
            cashier.Size = new Size(78, 24);
            cashier.TabIndex = 5;
            cashier.TabStop = true;
            cashier.Text = "Cashier";
            cashier.UseVisualStyleBackColor = true;
            cashier.CheckedChanged += cashier_CheckedChanged;
            // 
            // customer
            // 
            customer.AutoSize = true;
            customer.Location = new Point(180, 217);
            customer.Name = "customer";
            customer.Size = new Size(93, 24);
            customer.TabIndex = 6;
            customer.TabStop = true;
            customer.Text = "Customer";
            customer.UseVisualStyleBackColor = true;
            customer.CheckedChanged += customer_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(80, 284);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 287);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1006, 569);
            Controls.Add(pictureBox1);
            Controls.Add(customer);
            Controls.Add(cashier);
            Controls.Add(manager);
            Controls.Add(admin);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private CheckBox signup_showpass;
        private Label exit;
        private Button sign_up;
        private LinkLabel signup_login;
        private MaskedTextBox signup_password;
        private MaskedTextBox signup_username;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label6;
        private RadioButton admin;
        private RadioButton manager;
        private RadioButton cashier;
        private RadioButton customer;
        private PictureBox pictureBox1;
        private Label label7;
        private MaskedTextBox signup_email;
    }
}