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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "שלום עליזה";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "יצירת בחינה חדשה";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSearchExam
            // 
            this.buttonSearchExam.Location = new System.Drawing.Point(419, 168);
            this.buttonSearchExam.Name = "buttonSearchExam";
            this.buttonSearchExam.Size = new System.Drawing.Size(131, 45);
            this.buttonSearchExam.TabIndex = 2;
            this.buttonSearchExam.Text = "חיפוש בחינה";
            this.buttonSearchExam.UseVisualStyleBackColor = true;
            this.buttonSearchExam.Click += new System.EventHandler(this.ButtonSearchExam_Click);
            // 
            // buttonAddProctor
            // 
            this.buttonAddProctor.Location = new System.Drawing.Point(419, 234);
            this.buttonAddProctor.Name = "buttonAddProctor";
            this.buttonAddProctor.Size = new System.Drawing.Size(131, 48);
            this.buttonAddProctor.TabIndex = 3;
            this.buttonAddProctor.Text = "הוספת משגיח חדש";
            this.buttonAddProctor.UseVisualStyleBackColor = true;
            this.buttonAddProctor.Click += new System.EventHandler(this.ButtonAddProctor_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(562, 313);
            this.Controls.Add(this.buttonAddProctor);
            this.Controls.Add(this.buttonSearchExam);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSearchExam;
        private System.Windows.Forms.Button buttonAddProctor;
    }
}