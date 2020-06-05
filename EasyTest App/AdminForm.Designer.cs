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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemExamManage = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemProctorManage = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "הוספת בחינה חדשה";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSearchExam
            // 
            this.buttonSearchExam.Location = new System.Drawing.Point(157, 229);
            this.buttonSearchExam.Name = "buttonSearchExam";
            this.buttonSearchExam.Size = new System.Drawing.Size(131, 45);
            this.buttonSearchExam.TabIndex = 2;
            this.buttonSearchExam.Text = "מחק בחינה";
            this.buttonSearchExam.UseVisualStyleBackColor = true;
            this.buttonSearchExam.Click += new System.EventHandler(this.ButtonSearchExam_Click);
            // 
            // buttonAddProctor
            // 
            this.buttonAddProctor.Location = new System.Drawing.Point(157, 152);
            this.buttonAddProctor.Name = "buttonAddProctor";
            this.buttonAddProctor.Size = new System.Drawing.Size(131, 48);
            this.buttonAddProctor.TabIndex = 3;
            this.buttonAddProctor.Text = "עדכן בחינה קיימת";
            this.buttonAddProctor.UseVisualStyleBackColor = true;
            this.buttonAddProctor.Click += new System.EventHandler(this.ButtonAddProctor_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemExamManage,
            this.ToolStripMenuItemProctorManage,
            this.ToolStripMenuItemSearch});
            this.menuStrip1.Location = new System.Drawing.Point(435, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(127, 313);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemExamManage
            // 
            this.ToolStripMenuItemExamManage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ToolStripMenuItemExamManage.Name = "ToolStripMenuItemExamManage";
            this.ToolStripMenuItemExamManage.Size = new System.Drawing.Size(114, 25);
            this.ToolStripMenuItemExamManage.Text = "ניהול בחינות";
            this.ToolStripMenuItemExamManage.Click += new System.EventHandler(this.ToolStripMenuItemExamManage_Click);
            // 
            // ToolStripMenuItemProctorManage
            // 
            this.ToolStripMenuItemProctorManage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ToolStripMenuItemProctorManage.Name = "ToolStripMenuItemProctorManage";
            this.ToolStripMenuItemProctorManage.Size = new System.Drawing.Size(114, 25);
            this.ToolStripMenuItemProctorManage.Text = "ניהול משגיחים";
            this.ToolStripMenuItemProctorManage.Click += new System.EventHandler(this.ToolStripMenuItemProctorManage_Click);
            // 
            // ToolStripMenuItemSearch
            // 
            this.ToolStripMenuItemSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ToolStripMenuItemSearch.Name = "ToolStripMenuItemSearch";
            this.ToolStripMenuItemSearch.Size = new System.Drawing.Size(114, 25);
            this.ToolStripMenuItemSearch.Text = "חיפוש";
            this.ToolStripMenuItemSearch.Click += new System.EventHandler(this.ToolStripMenuItemSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(499, 263);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(562, 313);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonAddProctor);
            this.Controls.Add(this.buttonSearchExam);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}