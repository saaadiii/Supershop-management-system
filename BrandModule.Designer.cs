namespace Supershop
{
    partial class BrandModule
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
            button1 = new Button();
            label1 = new Label();
            textbtn = new TextBox();
            Savebtn = new Button();
            label2 = new Label();
            Csncelbtn = new Button();
            updatebtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(617, 54);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(575, 12);
            button1.Name = "button1";
            button1.Size = new Size(30, 27);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(133, 22);
            label1.TabIndex = 0;
            label1.Text = "Brand Module";
            // 
            // textbtn
            // 
            textbtn.BackColor = Color.WhiteSmoke;
            textbtn.Location = new Point(138, 89);
            textbtn.Name = "textbtn";
            textbtn.Size = new Size(467, 27);
            textbtn.TabIndex = 1;
            textbtn.TextChanged += textbtn_TextChanged;
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
            Savebtn.Location = new Point(286, 137);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(102, 35);
            Savebtn.TabIndex = 2;
            Savebtn.Text = "Save";
            Savebtn.UseVisualStyleBackColor = false;
            Savebtn.Click += Savebtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 89);
            label2.Name = "label2";
            label2.Size = new Size(125, 22);
            label2.TabIndex = 3;
            label2.Text = "Brand Name:";
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
            Csncelbtn.Location = new Point(394, 137);
            Csncelbtn.Name = "Csncelbtn";
            Csncelbtn.Size = new Size(105, 35);
            Csncelbtn.TabIndex = 4;
            Csncelbtn.Text = "Cancel";
            Csncelbtn.UseVisualStyleBackColor = false;
            Csncelbtn.Click += Csncelbtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.DarkSeaGreen;
            updatebtn.FlatAppearance.BorderSize = 2;
            updatebtn.FlatAppearance.MouseDownBackColor = Color.LawnGreen;
            updatebtn.FlatAppearance.MouseOverBackColor = Color.LawnGreen;
            updatebtn.FlatStyle = FlatStyle.Flat;
            updatebtn.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updatebtn.ForeColor = SystemColors.ButtonHighlight;
            updatebtn.Location = new Point(505, 137);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(100, 35);
            updatebtn.TabIndex = 5;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // BrandModule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(617, 184);
            Controls.Add(updatebtn);
            Controls.Add(Csncelbtn);
            Controls.Add(label2);
            Controls.Add(Savebtn);
            Controls.Add(textbtn);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BrandModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BrandModule";
            Load += BrandModule_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        public TextBox textbtn;
        public Button Savebtn;
        public Button Csncelbtn;
        public Button updatebtn;
    }
}