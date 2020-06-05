namespace EasyTest_App
{
    partial class Main_Screen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Screen));
            this.AddStudentBTN = new System.Windows.Forms.Button();
            this.ReportBTN = new System.Windows.Forms.Button();
            this.ExtraTimeBTN = new System.Windows.Forms.Button();
            this.EndExamBTN = new System.Windows.Forms.Button();
            this.BeginExamBTN = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddStudentBTN
            // 
            this.AddStudentBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddStudentBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStudentBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudentBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddStudentBTN.Location = new System.Drawing.Point(378, 60);
            this.AddStudentBTN.Margin = new System.Windows.Forms.Padding(2);
            this.AddStudentBTN.Name = "AddStudentBTN";
            this.AddStudentBTN.Size = new System.Drawing.Size(134, 28);
            this.AddStudentBTN.TabIndex = 0;
            this.AddStudentBTN.Text = "הוספת סטודנט חדש";
            this.AddStudentBTN.UseVisualStyleBackColor = false;
            this.AddStudentBTN.Click += new System.EventHandler(this.AddStudentBTN_Click);
            // 
            // ReportBTN
            // 
            this.ReportBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.ReportBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ReportBTN.Location = new System.Drawing.Point(378, 99);
            this.ReportBTN.Margin = new System.Windows.Forms.Padding(2);
            this.ReportBTN.Name = "ReportBTN";
            this.ReportBTN.Size = new System.Drawing.Size(134, 28);
            this.ReportBTN.TabIndex = 1;
            this.ReportBTN.Text = "דיווח למדור בחינות";
            this.ReportBTN.UseVisualStyleBackColor = false;
            this.ReportBTN.Click += new System.EventHandler(this.ReportBTN_Click);
            // 
            // ExtraTimeBTN
            // 
            this.ExtraTimeBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.ExtraTimeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExtraTimeBTN.Enabled = false;
            this.ExtraTimeBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraTimeBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExtraTimeBTN.Location = new System.Drawing.Point(378, 139);
            this.ExtraTimeBTN.Margin = new System.Windows.Forms.Padding(2);
            this.ExtraTimeBTN.Name = "ExtraTimeBTN";
            this.ExtraTimeBTN.Size = new System.Drawing.Size(134, 28);
            this.ExtraTimeBTN.TabIndex = 2;
            this.ExtraTimeBTN.Text = "הזן הארכת זמן";
            this.ExtraTimeBTN.UseVisualStyleBackColor = false;
            this.ExtraTimeBTN.Click += new System.EventHandler(this.ExtraTimeBTN_Click);
            // 
            // EndExamBTN
            // 
            this.EndExamBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.EndExamBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EndExamBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndExamBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EndExamBTN.Location = new System.Drawing.Point(21, 250);
            this.EndExamBTN.Margin = new System.Windows.Forms.Padding(2);
            this.EndExamBTN.Name = "EndExamBTN";
            this.EndExamBTN.Size = new System.Drawing.Size(100, 28);
            this.EndExamBTN.TabIndex = 4;
            this.EndExamBTN.Text = "סיים בחינה";
            this.EndExamBTN.UseVisualStyleBackColor = false;
            this.EndExamBTN.Click += new System.EventHandler(this.EndExamBTN_Click);
            // 
            // BeginExamBTN
            // 
            this.BeginExamBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.BeginExamBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BeginExamBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeginExamBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BeginExamBTN.Location = new System.Drawing.Point(176, 250);
            this.BeginExamBTN.Margin = new System.Windows.Forms.Padding(2);
            this.BeginExamBTN.Name = "BeginExamBTN";
            this.BeginExamBTN.Size = new System.Drawing.Size(100, 28);
            this.BeginExamBTN.TabIndex = 5;
            this.BeginExamBTN.Text = "התחל בחינה";
            this.BeginExamBTN.UseVisualStyleBackColor = false;
            this.BeginExamBTN.Click += new System.EventHandler(this.BeginExamBTN_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(369, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 7;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelName.Location = new System.Drawing.Point(440, 26);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 13);
            this.labelName.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(28, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 116);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(443, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Main_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(520, 306);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BeginExamBTN);
            this.Controls.Add(this.EndExamBTN);
            this.Controls.Add(this.ExtraTimeBTN);
            this.Controls.Add(this.ReportBTN);
            this.Controls.Add(this.AddStudentBTN);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Screen";
            this.Activated += new System.EventHandler(this.Main_Screen_Activated);
            this.Load += new System.EventHandler(this.Main_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddStudentBTN;
        private System.Windows.Forms.Button ReportBTN;
        private System.Windows.Forms.Button ExtraTimeBTN;
        private System.Windows.Forms.Button EndExamBTN;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BeginExamBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}