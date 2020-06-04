namespace EasyTest_App
{
    partial class AdminUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUpdateForm));
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelTxt = new System.Windows.Forms.Label();
            this.textBoxExamID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.Transparent;
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirm.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.buttonConfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonConfirm.Location = new System.Drawing.Point(529, 633);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(425, 126);
            this.buttonConfirm.TabIndex = 0;
            this.buttonConfirm.Text = "אשר";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBack.Location = new System.Drawing.Point(984, 633);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(425, 126);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "חזור";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelTxt
            // 
            this.labelTxt.AutoSize = true;
            this.labelTxt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTxt.Font = new System.Drawing.Font("Yu Gothic UI", 24F);
            this.labelTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTxt.Location = new System.Drawing.Point(409, 237);
            this.labelTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTxt.Name = "labelTxt";
            this.labelTxt.Size = new System.Drawing.Size(1108, 65);
            this.labelTxt.TabIndex = 2;
            this.labelTxt.Text = "אנא הזן מספר ת.ז של משגיח הבחינה שברצונך לעדכן";
            // 
            // textBoxExamID
            // 
            this.textBoxExamID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExamID.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.textBoxExamID.Location = new System.Drawing.Point(721, 405);
            this.textBoxExamID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxExamID.Multiline = true;
            this.textBoxExamID.Name = "textBoxExamID";
            this.textBoxExamID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxExamID.Size = new System.Drawing.Size(484, 54);
            this.textBoxExamID.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1898, 1024);
            this.panel1.TabIndex = 4;
            // 
            // AdminUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.textBoxExamID);
            this.Controls.Add(this.labelTxt);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminUpdateForm";
            this.Text = "AdminUpdateForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminUpdateForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminUpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelTxt;
        private System.Windows.Forms.TextBox textBoxExamID;
        private System.Windows.Forms.Panel panel1;
    }
}