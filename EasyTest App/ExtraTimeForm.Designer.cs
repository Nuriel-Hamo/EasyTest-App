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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(540, 770);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(777, 136);
            this.button1.TabIndex = 4;
            this.button1.Text = "עדכן זמן";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1640, 866);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 157);
            this.button2.TabIndex = 5;
            this.button2.Text = "מסך ראשי";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FirstNameLABEL
            // 
            this.FirstNameLABEL.AutoSize = true;
            this.FirstNameLABEL.BackColor = System.Drawing.Color.Transparent;
            this.FirstNameLABEL.Font = new System.Drawing.Font("Yu Gothic UI", 24F);
            this.FirstNameLABEL.ForeColor = System.Drawing.Color.DimGray;
            this.FirstNameLABEL.Location = new System.Drawing.Point(628, 411);
            this.FirstNameLABEL.Name = "FirstNameLABEL";
            this.FirstNameLABEL.Size = new System.Drawing.Size(584, 65);
            this.FirstNameLABEL.TabIndex = 6;
            this.FirstNameLABEL.Text = ":אנא בחר הארכת זמן רצויה";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 20F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(1051, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 54);
            this.label1.TabIndex = 7;
            this.label1.Text = ":זמן נבחר";
            // 
            // Radio1
            // 
            this.Radio1.AutoSize = true;
            this.Radio1.BackColor = System.Drawing.Color.Transparent;
            this.Radio1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Radio1.Font = new System.Drawing.Font("Yu Gothic UI", 20F);
            this.Radio1.ForeColor = System.Drawing.Color.DimGray;
            this.Radio1.Location = new System.Drawing.Point(814, 532);
            this.Radio1.Name = "Radio1";
            this.Radio1.Size = new System.Drawing.Size(210, 58);
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
            this.Radio2.Font = new System.Drawing.Font("Yu Gothic UI", 20F);
            this.Radio2.ForeColor = System.Drawing.Color.DimGray;
            this.Radio2.Location = new System.Drawing.Point(586, 532);
            this.Radio2.Name = "Radio2";
            this.Radio2.Size = new System.Drawing.Size(202, 58);
            this.Radio2.TabIndex = 23;
            this.Radio2.TabStop = true;
            this.Radio2.Text = "חצי שעה";
            this.Radio2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(622, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(515, 363);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // ExtraTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Radio2);
            this.Controls.Add(this.Radio1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstNameLABEL);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ExtraTimeForm";
            this.Text = "ExtraTimeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExtraTimeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}