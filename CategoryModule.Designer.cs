namespace Supershop
{
    partial class CategoryModule
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
            crossbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            textbtn = new TextBox();
            Savebtn = new Button();
            Csncelbtn = new Button();
            updatebtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(crossbtn);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(606, 54);
            panel1.TabIndex = 1;
         
            // 
            // crossbtn
            // 
            crossbtn.FlatStyle = FlatStyle.Flat;
            crossbtn.ForeColor = SystemColors.ButtonHighlight;
            crossbtn.Location = new Point(564, 12);
            crossbtn.Name = "crossbtn";
            crossbtn.Size = new Size(30, 27);
            crossbtn.TabIndex = 1;
            crossbtn.Text = "X";
            crossbtn.UseVisualStyleBackColor = true;
            crossbtn.Click += crossbtn_Click;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 90);
            label2.Name = "label2";
            label2.Size = new Size(157, 22);
            label2.TabIndex = 4;
            label2.Text = "Category Name:";
            // 
            // textbtn
            // 
            textbtn.BackColor = Color.WhiteSmoke;
            textbtn.Location = new Point(171, 89);
            textbtn.Name = "textbtn";
            textbtn.Size = new Size(423, 27);
            textbtn.TabIndex = 5;
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
            Savebtn.Location = new Point(275, 131);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(102, 35);
            Savebtn.TabIndex = 6;
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
            Csncelbtn.Location = new Point(383, 131);
            Csncelbtn.Name = "Csncelbtn";
            Csncelbtn.Size = new Size(105, 35);
            Csncelbtn.TabIndex = 7;
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
            updatebtn.Location = new Point(494, 131);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(100, 35);
            updatebtn.TabIndex = 8;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // CategoryModule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(606, 178);
            Controls.Add(updatebtn);
            Controls.Add(Csncelbtn);
            Controls.Add(Savebtn);
            Controls.Add(textbtn);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoryModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoryModule";
            Load += CategoryModule_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button crossbtn;
        private Label label1;
        private Label label2;
        public TextBox textbtn;
        public Button Savebtn;
        public Button Csncelbtn;
        public Button updatebtn;
    }
}