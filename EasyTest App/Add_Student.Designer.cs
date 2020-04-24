namespace EasyTest_App
{
    partial class Add_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Student));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.InsertStudentBTN = new System.Windows.Forms.Button();
            this.StudentID_textbox = new System.Windows.Forms.TextBox();
            this.addBackBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(680, 202);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(400, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 2);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 28F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(244, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 73);
            this.label1.TabIndex = 9;
            this.label1.Text = "EasyTest";
            // 
            // InsertStudentBTN
            // 
            this.InsertStudentBTN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.InsertStudentBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertStudentBTN.Font = new System.Drawing.Font("Arial", 12F);
            this.InsertStudentBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InsertStudentBTN.Location = new System.Drawing.Point(400, 311);
            this.InsertStudentBTN.Name = "InsertStudentBTN";
            this.InsertStudentBTN.Size = new System.Drawing.Size(160, 55);
            this.InsertStudentBTN.TabIndex = 8;
            this.InsertStudentBTN.Text = "הכנס סטודנט";
            this.InsertStudentBTN.UseVisualStyleBackColor = false;
            this.InsertStudentBTN.Click += new System.EventHandler(this.InsertStudentBTN_Click);
            // 
            // StudentID_textbox
            // 
            this.StudentID_textbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.StudentID_textbox.Font = new System.Drawing.Font("Arial", 12F);
            this.StudentID_textbox.ForeColor = System.Drawing.Color.DimGray;
            this.StudentID_textbox.Location = new System.Drawing.Point(404, 215);
            this.StudentID_textbox.Name = "StudentID_textbox";
            this.StudentID_textbox.Size = new System.Drawing.Size(270, 35);
            this.StudentID_textbox.TabIndex = 7;
            this.StudentID_textbox.Text = "הכנס ת.ז סטודנט";
            this.StudentID_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.StudentID_textbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StudentID_textbox_MouseClick);
            this.StudentID_textbox.TextChanged += new System.EventHandler(this.StudentID_textbox_TextChanged);
            // 
            // addBackBTN
            // 
            this.addBackBTN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.addBackBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBackBTN.Font = new System.Drawing.Font("Arial", 12F);
            this.addBackBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addBackBTN.Location = new System.Drawing.Point(576, 311);
            this.addBackBTN.Name = "addBackBTN";
            this.addBackBTN.Size = new System.Drawing.Size(160, 55);
            this.addBackBTN.TabIndex = 12;
            this.addBackBTN.Text = "חזור";
            this.addBackBTN.UseVisualStyleBackColor = false;
            this.addBackBTN.Click += new System.EventHandler(this.addBackBTN_Click);
            // 
            // Add_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 489);
            this.Controls.Add(this.addBackBTN);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InsertStudentBTN);
            this.Controls.Add(this.StudentID_textbox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InsertStudentBTN;
        private System.Windows.Forms.TextBox StudentID_textbox;
        private System.Windows.Forms.Button addBackBTN;
    }
}