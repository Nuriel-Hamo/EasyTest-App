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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstNameLABEL
            // 
            this.FirstNameLABEL.AutoSize = true;
            this.FirstNameLABEL.BackColor = System.Drawing.Color.Transparent;
            this.FirstNameLABEL.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLABEL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FirstNameLABEL.Location = new System.Drawing.Point(445, 29);
            this.FirstNameLABEL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstNameLABEL.Name = "FirstNameLABEL";
            this.FirstNameLABEL.Size = new System.Drawing.Size(68, 19);
            this.FirstNameLABEL.TabIndex = 0;
            this.FirstNameLABEL.Text = ":שם מלא";
            // 
            // IdLABEL
            // 
            this.IdLABEL.AutoSize = true;
            this.IdLABEL.BackColor = System.Drawing.Color.Transparent;
            this.IdLABEL.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLABEL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IdLABEL.Location = new System.Drawing.Point(422, 61);
            this.IdLABEL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdLABEL.Name = "IdLABEL";
            this.IdLABEL.Size = new System.Drawing.Size(95, 19);
            this.IdLABEL.TabIndex = 3;
            this.IdLABEL.Text = ":תעודת זהות";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 153);
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
            this.FirstNameAnsLABEL.Location = new System.Drawing.Point(365, 29);
            this.FirstNameAnsLABEL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstNameAnsLABEL.Name = "FirstNameAnsLABEL";
            this.FirstNameAnsLABEL.Size = new System.Drawing.Size(73, 18);
            this.FirstNameAnsLABEL.TabIndex = 5;
            this.FirstNameAnsLABEL.Text = "אסף בושרי";
            this.FirstNameAnsLABEL.Visible = false;
            // 
            // IdAnsLABEL
            // 
            this.IdAnsLABEL.AutoSize = true;
            this.IdAnsLABEL.BackColor = System.Drawing.Color.Transparent;
            this.IdAnsLABEL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdAnsLABEL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IdAnsLABEL.Location = new System.Drawing.Point(332, 62);
            this.IdAnsLABEL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdAnsLABEL.Name = "IdAnsLABEL";
            this.IdAnsLABEL.Size = new System.Drawing.Size(89, 18);
            this.IdAnsLABEL.TabIndex = 6;
            this.IdAnsLABEL.Text = "000000000";
            this.IdAnsLABEL.Visible = false;
            this.IdAnsLABEL.Click += new System.EventHandler(this.IdAnsLABEL_Click);
            // 
            // nootbookBTN
            // 
            this.nootbookBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.nootbookBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nootbookBTN.Location = new System.Drawing.Point(201, 240);
            this.nootbookBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nootbookBTN.Name = "nootbookBTN";
            this.nootbookBTN.Size = new System.Drawing.Size(145, 36);
            this.nootbookBTN.TabIndex = 7;
            this.nootbookBTN.Text = "המשך";
            this.nootbookBTN.UseVisualStyleBackColor = false;
            this.nootbookBTN.Click += new System.EventHandler(this.nootbookBTN_Click);
            // 
            // StudentInformation_backBTN
            // 
            this.StudentInformation_backBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.StudentInformation_backBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentInformation_backBTN.Location = new System.Drawing.Point(367, 240);
            this.StudentInformation_backBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentInformation_backBTN.Name = "StudentInformation_backBTN";
            this.StudentInformation_backBTN.Size = new System.Drawing.Size(145, 36);
            this.StudentInformation_backBTN.TabIndex = 8;
            this.StudentInformation_backBTN.Text = "חזור";
            this.StudentInformation_backBTN.UseVisualStyleBackColor = false;
            this.StudentInformation_backBTN.Click += new System.EventHandler(this.StudentInformation_backBTN_Click);
            // 
            // Student_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(520, 306);
            this.Controls.Add(this.StudentInformation_backBTN);
            this.Controls.Add(this.nootbookBTN);
            this.Controls.Add(this.IdAnsLABEL);
            this.Controls.Add(this.FirstNameAnsLABEL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.IdLABEL);
            this.Controls.Add(this.FirstNameLABEL);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}