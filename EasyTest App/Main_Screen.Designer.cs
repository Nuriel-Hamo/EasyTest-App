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
            this.BeginExamBTN = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimerLBL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateLBL = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.toiletError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.finishError = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.toiletError)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finishError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // AddStudentBTN
            // 
            this.AddStudentBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(75)))), ((int)(((byte)(174)))));
            this.AddStudentBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStudentBTN.FlatAppearance.BorderSize = 0;
            this.AddStudentBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudentBTN.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.AddStudentBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddStudentBTN.Image = ((System.Drawing.Image)(resources.GetObject("AddStudentBTN.Image")));
            this.AddStudentBTN.Location = new System.Drawing.Point(0, 201);
            this.AddStudentBTN.Name = "AddStudentBTN";
            this.AddStudentBTN.Size = new System.Drawing.Size(379, 202);
            this.AddStudentBTN.TabIndex = 0;
            this.AddStudentBTN.Text = "הוספת סטודנט";
            this.AddStudentBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddStudentBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddStudentBTN.UseVisualStyleBackColor = false;
            this.AddStudentBTN.Click += new System.EventHandler(this.AddStudentBTN_Click);
            // 
            // ReportBTN
            // 
            this.ReportBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(75)))), ((int)(((byte)(174)))));
            this.ReportBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportBTN.FlatAppearance.BorderSize = 0;
            this.ReportBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportBTN.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.ReportBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReportBTN.Image = ((System.Drawing.Image)(resources.GetObject("ReportBTN.Image")));
            this.ReportBTN.Location = new System.Drawing.Point(0, 606);
            this.ReportBTN.Name = "ReportBTN";
            this.ReportBTN.Size = new System.Drawing.Size(379, 202);
            this.ReportBTN.TabIndex = 1;
            this.ReportBTN.Text = "דיווח למדור בחינות";
            this.ReportBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ReportBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ReportBTN.UseVisualStyleBackColor = false;
            this.ReportBTN.Click += new System.EventHandler(this.ReportBTN_Click);
            // 
            // ExtraTimeBTN
            // 
            this.ExtraTimeBTN.BackColor = System.Drawing.Color.Transparent;
            this.ExtraTimeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExtraTimeBTN.Enabled = false;
            this.ExtraTimeBTN.FlatAppearance.BorderSize = 0;
            this.ExtraTimeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExtraTimeBTN.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.ExtraTimeBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExtraTimeBTN.Image = ((System.Drawing.Image)(resources.GetObject("ExtraTimeBTN.Image")));
            this.ExtraTimeBTN.Location = new System.Drawing.Point(0, 398);
            this.ExtraTimeBTN.Name = "ExtraTimeBTN";
            this.ExtraTimeBTN.Size = new System.Drawing.Size(379, 202);
            this.ExtraTimeBTN.TabIndex = 2;
            this.ExtraTimeBTN.Text = "הזן הארכת זמן";
            this.ExtraTimeBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExtraTimeBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ExtraTimeBTN.UseVisualStyleBackColor = false;
            this.ExtraTimeBTN.Click += new System.EventHandler(this.ExtraTimeBTN_Click);
            // 
            // BeginExamBTN
            // 
            this.BeginExamBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.BeginExamBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BeginExamBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BeginExamBTN.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.BeginExamBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BeginExamBTN.Location = new System.Drawing.Point(400, 915);
            this.BeginExamBTN.Name = "BeginExamBTN";
            this.BeginExamBTN.Size = new System.Drawing.Size(744, 133);
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
            // TimerLBL
            // 
            this.TimerLBL.AutoSize = true;
            this.TimerLBL.BackColor = System.Drawing.Color.Transparent;
            this.TimerLBL.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLBL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TimerLBL.Location = new System.Drawing.Point(615, 780);
            this.TimerLBL.Name = "TimerLBL";
            this.TimerLBL.Size = new System.Drawing.Size(314, 96);
            this.TimerLBL.TabIndex = 7;
            this.TimerLBL.Text = "00:00:00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(395, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 178);
            this.panel1.TabIndex = 10;
            // 
            // dateLBL
            // 
            this.dateLBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateLBL.AutoSize = true;
            this.dateLBL.BackColor = System.Drawing.Color.Transparent;
            this.dateLBL.Font = new System.Drawing.Font("Yu Gothic UI", 20F);
            this.dateLBL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateLBL.Location = new System.Drawing.Point(12, 9);
            this.dateLBL.Name = "dateLBL";
            this.dateLBL.Size = new System.Drawing.Size(231, 54);
            this.dateLBL.TabIndex = 16;
            this.dateLBL.Text = "00/00/0000";
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.labelName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelName.Location = new System.Drawing.Point(182, 48);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(192, 48);
            this.labelName.TabIndex = 8;
            this.labelName.Text = ".שמחה כהן";
            // 
            // toiletError
            // 
            this.toiletError.BlinkRate = 1000;
            this.toiletError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.toiletError.ContainerControl = this;
            this.toiletError.Icon = ((System.Drawing.Icon)(resources.GetObject("toiletError.Icon")));
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Location = new System.Drawing.Point(167, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(50, 50);
            this.panel3.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "סטודנט נבחן";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "סטודנט הגיש";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(167, 61);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 50);
            this.panel4.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "סטודנט בשירותים";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Green;
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Location = new System.Drawing.Point(167, 117);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(50, 50);
            this.panel5.TabIndex = 21;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.labelName);
            this.panel6.Controls.Add(this.AddStudentBTN);
            this.panel6.Controls.Add(this.ReportBTN);
            this.panel6.Controls.Add(this.ExtraTimeBTN);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1541, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(379, 1080);
            this.panel6.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(253, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 48);
            this.label4.TabIndex = 9;
            this.label4.Text = "!שלום";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(21, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 178);
            this.panel2.TabIndex = 24;
            // 
            // finishError
            // 
            this.finishError.ContainerControl = this;
            this.finishError.Icon = ((System.Drawing.Icon)(resources.GetObject("finishError.Icon")));
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(180, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 26);
            this.label5.TabIndex = 23;
            this.label5.Text = ":מקרא";
            // 
            // Main_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dateLBL);
            this.Controls.Add(this.TimerLBL);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BeginExamBTN);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Main_Screen_Activated);
            this.Load += new System.EventHandler(this.Main_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toiletError)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finishError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddStudentBTN;
        private System.Windows.Forms.Button ReportBTN;
        private System.Windows.Forms.Button ExtraTimeBTN;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimerLBL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BeginExamBTN;
        private System.Windows.Forms.Label dateLBL;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider finishError;
        private System.Windows.Forms.ErrorProvider toiletError;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}