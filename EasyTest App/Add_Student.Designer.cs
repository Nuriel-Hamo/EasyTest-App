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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1220, 644);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(572, 735);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 2);
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
            this.InsertStudentBTN.FlatAppearance.BorderSize = 0;
            this.InsertStudentBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertStudentBTN.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.InsertStudentBTN.ForeColor = System.Drawing.Color.Azure;
            this.InsertStudentBTN.Location = new System.Drawing.Point(572, 841);
            this.InsertStudentBTN.Name = "InsertStudentBTN";
            this.InsertStudentBTN.Size = new System.Drawing.Size(740, 135);
            this.InsertStudentBTN.TabIndex = 8;
            this.InsertStudentBTN.Text = "הכנס סטודנט";
            this.InsertStudentBTN.UseVisualStyleBackColor = false;
            this.InsertStudentBTN.Click += new System.EventHandler(this.InsertStudentBTN_Click);
            // 
            // StudentID_textbox
            // 
            this.StudentID_textbox.BackColor = System.Drawing.Color.White;
            this.StudentID_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentID_textbox.Font = new System.Drawing.Font("Arial", 18F);
            this.StudentID_textbox.ForeColor = System.Drawing.Color.DimGray;
            this.StudentID_textbox.Location = new System.Drawing.Point(569, 675);
            this.StudentID_textbox.Multiline = true;
            this.StudentID_textbox.Name = "StudentID_textbox";
            this.StudentID_textbox.Size = new System.Drawing.Size(659, 54);
            this.StudentID_textbox.TabIndex = 7;
            this.StudentID_textbox.Text = "הכנס ת.ז סטודנט";
            this.StudentID_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.StudentID_textbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StudentID_textbox_MouseClick);
            this.StudentID_textbox.TextChanged += new System.EventHandler(this.StudentID_textbox_TextChanged);
            // 
            // addBackBTN
            // 
            this.addBackBTN.BackColor = System.Drawing.Color.Transparent;
            this.addBackBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBackBTN.FlatAppearance.BorderSize = 0;
            this.addBackBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBackBTN.Font = new System.Drawing.Font("Yu Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBackBTN.ForeColor = System.Drawing.Color.DimGray;
            this.addBackBTN.Image = ((System.Drawing.Image)(resources.GetObject("addBackBTN.Image")));
            this.addBackBTN.Location = new System.Drawing.Point(1663, 926);
            this.addBackBTN.Name = "addBackBTN";
            this.addBackBTN.Size = new System.Drawing.Size(257, 157);
            this.addBackBTN.TabIndex = 12;
            this.addBackBTN.Text = "מסך ראשי";
            this.addBackBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addBackBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addBackBTN.UseVisualStyleBackColor = false;
            this.addBackBTN.Click += new System.EventHandler(this.addBackBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(791, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(802, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 45);
            this.label2.TabIndex = 16;
            this.label2.Text = "תהליך אימות וזיהוי";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 26F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(746, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(393, 73);
            this.label3.TabIndex = 15;
            this.label3.Text = "הוספת סטודנט";
            // 
            // Add_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InsertStudentBTN);
            this.Controls.Add(this.StudentID_textbox);
            this.Controls.Add(this.addBackBTN);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Add_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}