namespace EasyTest_App
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSearchExam = new System.Windows.Forms.Button();
            this.buttonAddProctor = new System.Windows.Forms.Button();
            this.ExamsBTN = new System.Windows.Forms.Button();
            this.reportAlertLBL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BTNSearch = new System.Windows.Forms.Button();
            this.BTNEventM = new System.Windows.Forms.Button();
            this.BTNProctorManage = new System.Windows.Forms.Button();
            this.BTNExamManage = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLineExam = new System.Windows.Forms.Panel();
            this.panelLineProctors = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 24F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(85)))), ((int)(((byte)(108)))));
            this.label1.Location = new System.Drawing.Point(1577, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "שלום עליזה";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(158)))), ((int)(((byte)(165)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(976, 390);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(379, 202);
            this.button1.TabIndex = 1;
            this.button1.Text = "הוספת בחינה חדשה";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSearchExam
            // 
            this.buttonSearchExam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(158)))), ((int)(((byte)(165)))));
            this.buttonSearchExam.FlatAppearance.BorderSize = 0;
            this.buttonSearchExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchExam.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.buttonSearchExam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearchExam.Location = new System.Drawing.Point(563, 620);
            this.buttonSearchExam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSearchExam.Name = "buttonSearchExam";
            this.buttonSearchExam.Size = new System.Drawing.Size(379, 202);
            this.buttonSearchExam.TabIndex = 2;
            this.buttonSearchExam.Text = "מחק בחינה";
            this.buttonSearchExam.UseVisualStyleBackColor = false;
            this.buttonSearchExam.Click += new System.EventHandler(this.ButtonSearchExam_Click);
            // 
            // buttonAddProctor
            // 
            this.buttonAddProctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddProctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(158)))), ((int)(((byte)(165)))));
            this.buttonAddProctor.FlatAppearance.BorderSize = 0;
            this.buttonAddProctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProctor.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.buttonAddProctor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddProctor.Location = new System.Drawing.Point(563, 390);
            this.buttonAddProctor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddProctor.Name = "buttonAddProctor";
            this.buttonAddProctor.Size = new System.Drawing.Size(379, 202);
            this.buttonAddProctor.TabIndex = 3;
            this.buttonAddProctor.Text = "עדכן בחינה קיימת";
            this.buttonAddProctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAddProctor.UseVisualStyleBackColor = false;
            this.buttonAddProctor.Click += new System.EventHandler(this.ButtonAddProctor_Click);
            // 
            // ExamsBTN
            // 
            this.ExamsBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExamsBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
            this.ExamsBTN.FlatAppearance.BorderSize = 0;
            this.ExamsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExamsBTN.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.ExamsBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExamsBTN.Location = new System.Drawing.Point(976, 620);
            this.ExamsBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExamsBTN.Name = "ExamsBTN";
            this.ExamsBTN.Size = new System.Drawing.Size(379, 202);
            this.ExamsBTN.TabIndex = 4;
            this.ExamsBTN.Text = "סיכום בחינות";
            this.ExamsBTN.UseVisualStyleBackColor = false;
            this.ExamsBTN.Click += new System.EventHandler(this.ExamsBTN_Click);
            // 
            // reportAlertLBL
            // 
            this.reportAlertLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reportAlertLBL.BackColor = System.Drawing.Color.Transparent;
            this.reportAlertLBL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportAlertLBL.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.reportAlertLBL.ForeColor = System.Drawing.Color.Red;
            this.reportAlertLBL.Location = new System.Drawing.Point(1357, 158);
            this.reportAlertLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reportAlertLBL.Name = "reportAlertLBL";
            this.reportAlertLBL.Size = new System.Drawing.Size(563, 63);
            this.reportAlertLBL.TabIndex = 6;
            this.reportAlertLBL.Text = "מערכת התראות";
            this.reportAlertLBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reportAlertLBL.Visible = false;
            this.reportAlertLBL.Click += new System.EventHandler(this.reportAlertLBL_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelLineProctors);
            this.panel1.Controls.Add(this.panelLineExam);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.BTNSearch);
            this.panel1.Controls.Add(this.BTNEventM);
            this.panel1.Controls.Add(this.reportAlertLBL);
            this.panel1.Controls.Add(this.BTNProctorManage);
            this.panel1.Controls.Add(this.BTNExamManage);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 228);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(-12, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1938, 2);
            this.panel2.TabIndex = 17;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1837, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BTNSearch
            // 
            this.BTNSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNSearch.BackColor = System.Drawing.Color.White;
            this.BTNSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNSearch.FlatAppearance.BorderSize = 0;
            this.BTNSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BTNSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BTNSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSearch.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.BTNSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(85)))), ((int)(((byte)(108)))));
            this.BTNSearch.Image = ((System.Drawing.Image)(resources.GetObject("BTNSearch.Image")));
            this.BTNSearch.Location = new System.Drawing.Point(620, 23);
            this.BTNSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.Size = new System.Drawing.Size(171, 231);
            this.BTNSearch.TabIndex = 11;
            this.BTNSearch.Text = "חיפוש";
            this.BTNSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNSearch.UseVisualStyleBackColor = false;
            this.BTNSearch.Click += new System.EventHandler(this.BTNSearch_Click);
            // 
            // BTNEventM
            // 
            this.BTNEventM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNEventM.BackColor = System.Drawing.Color.White;
            this.BTNEventM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNEventM.FlatAppearance.BorderSize = 0;
            this.BTNEventM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BTNEventM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BTNEventM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNEventM.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.BTNEventM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(85)))), ((int)(((byte)(108)))));
            this.BTNEventM.Image = ((System.Drawing.Image)(resources.GetObject("BTNEventM.Image")));
            this.BTNEventM.Location = new System.Drawing.Point(791, 23);
            this.BTNEventM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNEventM.Name = "BTNEventM";
            this.BTNEventM.Size = new System.Drawing.Size(170, 222);
            this.BTNEventM.TabIndex = 10;
            this.BTNEventM.Text = "דיווחים";
            this.BTNEventM.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNEventM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNEventM.UseVisualStyleBackColor = false;
            this.BTNEventM.Click += new System.EventHandler(this.BTNEventM_Click);
            // 
            // BTNProctorManage
            // 
            this.BTNProctorManage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNProctorManage.BackColor = System.Drawing.Color.White;
            this.BTNProctorManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNProctorManage.FlatAppearance.BorderSize = 0;
            this.BTNProctorManage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BTNProctorManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BTNProctorManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNProctorManage.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.BTNProctorManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(85)))), ((int)(((byte)(108)))));
            this.BTNProctorManage.Image = ((System.Drawing.Image)(resources.GetObject("BTNProctorManage.Image")));
            this.BTNProctorManage.Location = new System.Drawing.Point(961, 33);
            this.BTNProctorManage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNProctorManage.Name = "BTNProctorManage";
            this.BTNProctorManage.Size = new System.Drawing.Size(186, 207);
            this.BTNProctorManage.TabIndex = 9;
            this.BTNProctorManage.Text = "משגיחים";
            this.BTNProctorManage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNProctorManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNProctorManage.UseVisualStyleBackColor = false;
            this.BTNProctorManage.Click += new System.EventHandler(this.BTNProctorManage_Click);
            // 
            // BTNExamManage
            // 
            this.BTNExamManage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNExamManage.BackColor = System.Drawing.Color.White;
            this.BTNExamManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNExamManage.FlatAppearance.BorderSize = 0;
            this.BTNExamManage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BTNExamManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BTNExamManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNExamManage.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.BTNExamManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(85)))), ((int)(((byte)(108)))));
            this.BTNExamManage.Image = ((System.Drawing.Image)(resources.GetObject("BTNExamManage.Image")));
            this.BTNExamManage.Location = new System.Drawing.Point(1147, 36);
            this.BTNExamManage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNExamManage.Name = "BTNExamManage";
            this.BTNExamManage.Size = new System.Drawing.Size(167, 207);
            this.BTNExamManage.TabIndex = 8;
            this.BTNExamManage.Text = "בחינות";
            this.BTNExamManage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNExamManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNExamManage.UseVisualStyleBackColor = false;
            this.BTNExamManage.Click += new System.EventHandler(this.BTNExamManage_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-296, 742);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(673, 648);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1513, -67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(673, 648);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panelLineExam
            // 
            this.panelLineExam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLineExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
            this.panelLineExam.Location = new System.Drawing.Point(1153, 221);
            this.panelLineExam.Name = "panelLineExam";
            this.panelLineExam.Size = new System.Drawing.Size(150, 4);
            this.panelLineExam.TabIndex = 18;
            this.panelLineExam.Visible = false;
            // 
            // panelLineProctors
            // 
            this.panelLineProctors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLineProctors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
            this.panelLineProctors.Location = new System.Drawing.Point(977, 221);
            this.panelLineProctors.Name = "panelLineProctors";
            this.panelLineProctors.Size = new System.Drawing.Size(150, 4);
            this.panelLineProctors.TabIndex = 19;
            this.panelLineProctors.Visible = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1050);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ExamsBTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAddProctor);
            this.Controls.Add(this.buttonSearchExam);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSearchExam;
        private System.Windows.Forms.Button buttonAddProctor;
        private System.Windows.Forms.Label reportAlertLBL;
        private System.Windows.Forms.Button ExamsBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNSearch;
        private System.Windows.Forms.Button BTNEventM;
        private System.Windows.Forms.Button BTNProctorManage;
        private System.Windows.Forms.Button BTNExamManage;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelLineProctors;
        private System.Windows.Forms.Panel panelLineExam;
    }
}