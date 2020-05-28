namespace EasyTest_App
{
    partial class ExtraTimeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtraTimeForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.FirstNameLABEL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Radio1 = new System.Windows.Forms.RadioButton();
            this.Radio2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 246);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 84);
            this.button1.TabIndex = 4;
            this.button1.Text = "עדכן";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 246);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 84);
            this.button2.TabIndex = 5;
            this.button2.Text = "חזור";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FirstNameLABEL
            // 
            this.FirstNameLABEL.AutoSize = true;
            this.FirstNameLABEL.BackColor = System.Drawing.Color.Transparent;
            this.FirstNameLABEL.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLABEL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FirstNameLABEL.Location = new System.Drawing.Point(453, 23);
            this.FirstNameLABEL.Name = "FirstNameLABEL";
            this.FirstNameLABEL.Size = new System.Drawing.Size(283, 29);
            this.FirstNameLABEL.TabIndex = 6;
            this.FirstNameLABEL.Text = ":אנא בחר הארכת זמן רצויה";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(616, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = ":זמן נבחר";
            // 
            // Radio1
            // 
            this.Radio1.AutoSize = true;
            this.Radio1.BackColor = System.Drawing.Color.Transparent;
            this.Radio1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Radio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.Radio1.ForeColor = System.Drawing.Color.Transparent;
            this.Radio1.Location = new System.Drawing.Point(487, 117);
            this.Radio1.Name = "Radio1";
            this.Radio1.Size = new System.Drawing.Size(103, 24);
            this.Radio1.TabIndex = 22;
            this.Radio1.TabStop = true;
            this.Radio1.Text = "רבע שעה";
            this.Radio1.UseVisualStyleBackColor = false;
            // 
            // Radio2
            // 
            this.Radio2.AutoSize = true;
            this.Radio2.BackColor = System.Drawing.Color.Transparent;
            this.Radio2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Radio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.Radio2.ForeColor = System.Drawing.Color.Transparent;
            this.Radio2.Location = new System.Drawing.Point(353, 117);
            this.Radio2.Name = "Radio2";
            this.Radio2.Size = new System.Drawing.Size(99, 24);
            this.Radio2.TabIndex = 23;
            this.Radio2.TabStop = true;
            this.Radio2.Text = "חצי שעה";
            this.Radio2.UseVisualStyleBackColor = false;
            // 
            // ExtraTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(738, 394);
            this.Controls.Add(this.Radio2);
            this.Controls.Add(this.Radio1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstNameLABEL);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ExtraTimeForm";
            this.Text = "ExtraTimeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label FirstNameLABEL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Radio1;
        private System.Windows.Forms.RadioButton Radio2;
    }
}