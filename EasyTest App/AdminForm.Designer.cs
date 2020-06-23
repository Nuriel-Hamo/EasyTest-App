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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSearchExam = new System.Windows.Forms.Button();
            this.buttonAddProctor = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemExamManage = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemProctorManage = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.EventM = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportAlertLBL = new System.Windows.Forms.Label();
            this.ExamsBTN = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 50F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(563, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 128);
            this.label1.TabIndex = 0;
            this.label1.Text = "שלום עליזה";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 0);
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
            this.buttonSearchExam.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearchExam.FlatAppearance.BorderSize = 0;
            this.buttonSearchExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchExam.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.buttonSearchExam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearchExam.Location = new System.Drawing.Point(-1, 403);
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
            this.buttonAddProctor.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddProctor.FlatAppearance.BorderSize = 0;
            this.buttonAddProctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProctor.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.buttonAddProctor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddProctor.Location = new System.Drawing.Point(0, 202);
            this.buttonAddProctor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddProctor.Name = "buttonAddProctor";
            this.buttonAddProctor.Size = new System.Drawing.Size(379, 202);
            this.buttonAddProctor.TabIndex = 3;
            this.buttonAddProctor.Text = "עדכן בחינה קיימת";
            this.buttonAddProctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAddProctor.UseVisualStyleBackColor = false;
            this.buttonAddProctor.Click += new System.EventHandler(this.ButtonAddProctor_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemExamManage,
            this.ToolStripMenuItemProctorManage,
            this.ToolStripMenuItemSearch,
            this.EventM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1898, 61);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemExamManage
            // 
            this.ToolStripMenuItemExamManage.Font = new System.Drawing.Font("Yu Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemExamManage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToolStripMenuItemExamManage.Name = "ToolStripMenuItemExamManage";
            this.ToolStripMenuItemExamManage.Size = new System.Drawing.Size(236, 55);
            this.ToolStripMenuItemExamManage.Text = "ניהול בחינות";
            this.ToolStripMenuItemExamManage.Click += new System.EventHandler(this.ToolStripMenuItemExamManage_Click);
            // 
            // ToolStripMenuItemProctorManage
            // 
            this.ToolStripMenuItemProctorManage.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.ToolStripMenuItemProctorManage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToolStripMenuItemProctorManage.Name = "ToolStripMenuItemProctorManage";
            this.ToolStripMenuItemProctorManage.Size = new System.Drawing.Size(268, 55);
            this.ToolStripMenuItemProctorManage.Text = "ניהול משגיחים";
            this.ToolStripMenuItemProctorManage.Click += new System.EventHandler(this.ToolStripMenuItemProctorManage_Click);
            // 
            // ToolStripMenuItemSearch
            // 
            this.ToolStripMenuItemSearch.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.ToolStripMenuItemSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToolStripMenuItemSearch.Name = "ToolStripMenuItemSearch";
            this.ToolStripMenuItemSearch.Size = new System.Drawing.Size(135, 55);
            this.ToolStripMenuItemSearch.Text = "חיפוש";
            this.ToolStripMenuItemSearch.Click += new System.EventHandler(this.ToolStripMenuItemSearch_Click);
            // 
            // EventM
            // 
            this.EventM.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.EventM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EventM.Name = "EventM";
            this.EventM.Size = new System.Drawing.Size(251, 55);
            this.EventM.Text = "ניהול אירועים";
            this.EventM.Click += new System.EventHandler(this.EventM_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.ExamsBTN);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonAddProctor);
            this.panel1.Controls.Add(this.buttonSearchExam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1519, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 963);
            this.panel1.TabIndex = 5;
            // 
            // reportAlertLBL
            // 
            this.reportAlertLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reportAlertLBL.BackColor = System.Drawing.Color.Transparent;
            this.reportAlertLBL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportAlertLBL.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.reportAlertLBL.ForeColor = System.Drawing.Color.Red;
            this.reportAlertLBL.Location = new System.Drawing.Point(3, 231);
            this.reportAlertLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reportAlertLBL.Name = "reportAlertLBL";
            this.reportAlertLBL.Size = new System.Drawing.Size(1040, 63);
            this.reportAlertLBL.TabIndex = 6;
            this.reportAlertLBL.Text = "מערכת התראות";
            this.reportAlertLBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reportAlertLBL.Visible = false;
            this.reportAlertLBL.Click += new System.EventHandler(this.reportAlertLBL_Click);
            // 
            // ExamsBTN
            // 
            this.ExamsBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExamsBTN.BackColor = System.Drawing.Color.Transparent;
            this.ExamsBTN.FlatAppearance.BorderSize = 0;
            this.ExamsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExamsBTN.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.ExamsBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExamsBTN.Location = new System.Drawing.Point(0, 615);
            this.ExamsBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExamsBTN.Name = "ExamsBTN";
            this.ExamsBTN.Size = new System.Drawing.Size(379, 202);
            this.ExamsBTN.TabIndex = 4;
            this.ExamsBTN.Text = "סיכום בחינות";
            this.ExamsBTN.UseVisualStyleBackColor = false;
            this.ExamsBTN.Click += new System.EventHandler(this.ExamsBTN_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.reportAlertLBL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSearchExam;
        private System.Windows.Forms.Button buttonAddProctor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExamManage;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemProctorManage;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label reportAlertLBL;
        private System.Windows.Forms.ToolStripMenuItem EventM;
        private System.Windows.Forms.Button ExamsBTN;
    }
}