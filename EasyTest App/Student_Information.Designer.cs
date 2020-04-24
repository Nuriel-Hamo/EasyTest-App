namespace EasyTest_App
{
    partial class Student_Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Information));
            this.FirstNameLABEL = new System.Windows.Forms.Label();
            this.IdLABEL = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FirstNameAnsLABEL = new System.Windows.Forms.Label();
            this.IdAnsLABEL = new System.Windows.Forms.Label();
            this.nootbookBTN = new System.Windows.Forms.Button();
            this.StudentInformation_backBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mailANS = new System.Windows.Forms.Label();
            this.phoneANS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstNameLABEL
            // 
            this.FirstNameLABEL.AutoSize = true;
            this.FirstNameLABEL.BackColor = System.Drawing.Color.Transparent;
            this.FirstNameLABEL.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLABEL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FirstNameLABEL.Location = new System.Drawing.Point(668, 45);
            this.FirstNameLABEL.Name = "FirstNameLABEL";
            this.FirstNameLABEL.Size = new System.Drawing.Size(100, 29);
            this.FirstNameLABEL.TabIndex = 0;
            this.FirstNameLABEL.Text = ":שם מלא";
            // 
            // IdLABEL
            // 
            this.IdLABEL.AutoSize = true;
            this.IdLABEL.BackColor = System.Drawing.Color.Transparent;
            this.IdLABEL.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLABEL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IdLABEL.Location = new System.Drawing.Point(633, 94);
            this.IdLABEL.Name = "IdLABEL";
            this.IdLABEL.Size = new System.Drawing.Size(140, 29);
            this.IdLABEL.TabIndex = 3;
            this.IdLABEL.Text = ":תעודת זהות";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FirstNameAnsLABEL
            // 
            this.FirstNameAnsLABEL.AutoSize = true;
            this.FirstNameAnsLABEL.BackColor = System.Drawing.Color.Transparent;
            this.FirstNameAnsLABEL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameAnsLABEL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FirstNameAnsLABEL.Location = new System.Drawing.Point(533, 47);
            this.FirstNameAnsLABEL.Name = "FirstNameAnsLABEL";
            this.FirstNameAnsLABEL.Size = new System.Drawing.Size(129, 27);
            this.FirstNameAnsLABEL.TabIndex = 5;
            this.FirstNameAnsLABEL.Text = "000000000";
            this.FirstNameAnsLABEL.Visible = false;
            // 
            // IdAnsLABEL
            // 
            this.IdAnsLABEL.AutoSize = true;
            this.IdAnsLABEL.BackColor = System.Drawing.Color.Transparent;
            this.IdAnsLABEL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdAnsLABEL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IdAnsLABEL.Location = new System.Drawing.Point(498, 96);
            this.IdAnsLABEL.Name = "IdAnsLABEL";
            this.IdAnsLABEL.Size = new System.Drawing.Size(129, 27);
            this.IdAnsLABEL.TabIndex = 6;
            this.IdAnsLABEL.Text = "000000000";
            this.IdAnsLABEL.Visible = false;
            this.IdAnsLABEL.Click += new System.EventHandler(this.IdAnsLABEL_Click);
            // 
            // nootbookBTN
            // 
            this.nootbookBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.nootbookBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nootbookBTN.Location = new System.Drawing.Point(302, 369);
            this.nootbookBTN.Name = "nootbookBTN";
            this.nootbookBTN.Size = new System.Drawing.Size(218, 55);
            this.nootbookBTN.TabIndex = 7;
            this.nootbookBTN.Text = "המשך";
            this.nootbookBTN.UseVisualStyleBackColor = false;
            this.nootbookBTN.Click += new System.EventHandler(this.nootbookBTN_Click);
            // 
            // StudentInformation_backBTN
            // 
            this.StudentInformation_backBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.StudentInformation_backBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentInformation_backBTN.Location = new System.Drawing.Point(550, 369);
            this.StudentInformation_backBTN.Name = "StudentInformation_backBTN";
            this.StudentInformation_backBTN.Size = new System.Drawing.Size(218, 55);
            this.StudentInformation_backBTN.TabIndex = 8;
            this.StudentInformation_backBTN.Text = "חזור";
            this.StudentInformation_backBTN.UseVisualStyleBackColor = false;
            this.StudentInformation_backBTN.Click += new System.EventHandler(this.StudentInformation_backBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(680, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = ":פלאפון";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(707, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = ":מייל";
            // 
            // mailANS
            // 
            this.mailANS.AutoSize = true;
            this.mailANS.BackColor = System.Drawing.Color.Transparent;
            this.mailANS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailANS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mailANS.Location = new System.Drawing.Point(416, 181);
            this.mailANS.Name = "mailANS";
            this.mailANS.Size = new System.Drawing.Size(285, 27);
            this.mailANS.TabIndex = 11;
            this.mailANS.Text = "000000000000000000000";
            this.mailANS.Visible = false;
            // 
            // phoneANS
            // 
            this.phoneANS.AutoSize = true;
            this.phoneANS.BackColor = System.Drawing.Color.Transparent;
            this.phoneANS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneANS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.phoneANS.Location = new System.Drawing.Point(533, 139);
            this.phoneANS.Name = "phoneANS";
            this.phoneANS.Size = new System.Drawing.Size(142, 27);
            this.phoneANS.TabIndex = 12;
            this.phoneANS.Text = "0000000000";
            this.phoneANS.Visible = false;
            // 
            // Student_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 471);
            this.Controls.Add(this.phoneANS);
            this.Controls.Add(this.mailANS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentInformation_backBTN);
            this.Controls.Add(this.nootbookBTN);
            this.Controls.Add(this.IdAnsLABEL);
            this.Controls.Add(this.FirstNameAnsLABEL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.IdLABEL);
            this.Controls.Add(this.FirstNameLABEL);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student_Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Student_Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLABEL;
        private System.Windows.Forms.Label IdLABEL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label FirstNameAnsLABEL;
        private System.Windows.Forms.Label IdAnsLABEL;
        private System.Windows.Forms.Button nootbookBTN;
        private System.Windows.Forms.Button StudentInformation_backBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mailANS;
        private System.Windows.Forms.Label phoneANS;
    }
}