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
            this.ניהולבחינותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.הוספהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.עדכוןToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.מחיקהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "שלום עליזה";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 167);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "יצירת בחינה חדשה";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSearchExam
            // 
            this.buttonSearchExam.Location = new System.Drawing.Point(271, 268);
            this.buttonSearchExam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSearchExam.Name = "buttonSearchExam";
            this.buttonSearchExam.Size = new System.Drawing.Size(196, 69);
            this.buttonSearchExam.TabIndex = 2;
            this.buttonSearchExam.Text = "חיפוש בחינה";
            this.buttonSearchExam.UseVisualStyleBackColor = true;
            this.buttonSearchExam.Click += new System.EventHandler(this.ButtonSearchExam_Click);
            // 
            // buttonAddProctor
            // 
            this.buttonAddProctor.Location = new System.Drawing.Point(271, 370);
            this.buttonAddProctor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddProctor.Name = "buttonAddProctor";
            this.buttonAddProctor.Size = new System.Drawing.Size(196, 74);
            this.buttonAddProctor.TabIndex = 3;
            this.buttonAddProctor.Text = "הוספת משגיח חדש";
            this.buttonAddProctor.UseVisualStyleBackColor = true;
            this.buttonAddProctor.Click += new System.EventHandler(this.ButtonAddProctor_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ניהולבחינותToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(654, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(189, 482);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ניהולבחינותToolStripMenuItem
            // 
            this.ניהולבחינותToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.הוספהToolStripMenuItem,
            this.עדכוןToolStripMenuItem,
            this.מחיקהToolStripMenuItem});
            this.ניהולבחינותToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ניהולבחינותToolStripMenuItem.Name = "ניהולבחינותToolStripMenuItem";
            this.ניהולבחינותToolStripMenuItem.Size = new System.Drawing.Size(173, 36);
            this.ניהולבחינותToolStripMenuItem.Text = "ניהול בחינות";
            // 
            // הוספהToolStripMenuItem
            // 
            this.הוספהToolStripMenuItem.Name = "הוספהToolStripMenuItem";
            this.הוספהToolStripMenuItem.Size = new System.Drawing.Size(270, 40);
            this.הוספהToolStripMenuItem.Text = "הוספה";
            // 
            // עדכוןToolStripMenuItem
            // 
            this.עדכוןToolStripMenuItem.Name = "עדכוןToolStripMenuItem";
            this.עדכוןToolStripMenuItem.Size = new System.Drawing.Size(270, 40);
            this.עדכוןToolStripMenuItem.Text = "עדכון";
            // 
            // מחיקהToolStripMenuItem
            // 
            this.מחיקהToolStripMenuItem.Name = "מחיקהToolStripMenuItem";
            this.מחיקהToolStripMenuItem.Size = new System.Drawing.Size(270, 40);
            this.מחיקהToolStripMenuItem.Text = "מחיקה";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 482);
            this.Controls.Add(this.buttonAddProctor);
            this.Controls.Add(this.buttonSearchExam);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSearchExam;
        private System.Windows.Forms.Button buttonAddProctor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ניהולבחינותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem הוספהToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem עדכוןToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem מחיקהToolStripMenuItem;
    }
}