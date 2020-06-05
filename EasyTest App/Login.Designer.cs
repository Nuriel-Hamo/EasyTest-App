namespace EasyTest_App
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.login_backBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LoginBTN = new System.Windows.Forms.Button();
            this.Pass_textbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserID_textbox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 28F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(279, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "EasyTest";
            // 
            // login_backBTN
            // 
            this.login_backBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.login_backBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_backBTN.Location = new System.Drawing.Point(145, 242);
            this.login_backBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.login_backBTN.Name = "login_backBTN";
            this.login_backBTN.Size = new System.Drawing.Size(93, 32);
            this.login_backBTN.TabIndex = 9;
            this.login_backBTN.Text = "חזור";
            this.login_backBTN.UseVisualStyleBackColor = false;
            this.login_backBTN.Visible = false;
            this.login_backBTN.Click += new System.EventHandler(this.login_backBTN_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(15, 84);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 1);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(14, 129);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 1);
            this.panel2.TabIndex = 5;
            // 
            // LoginBTN
            // 
            this.LoginBTN.BackColor = System.Drawing.Color.Transparent;
            this.LoginBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBTN.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.LoginBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.LoginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBTN.Font = new System.Drawing.Font("Arial", 12F);
            this.LoginBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginBTN.Location = new System.Drawing.Point(17, 160);
            this.LoginBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(223, 59);
            this.LoginBTN.TabIndex = 2;
            this.LoginBTN.Text = "כניסה ";
            this.LoginBTN.UseVisualStyleBackColor = false;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            this.LoginBTN.MouseHover += new System.EventHandler(this.LoginBTN_MouseHover);
            // 
            // Pass_textbox
            // 
            this.Pass_textbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Pass_textbox.Font = new System.Drawing.Font("Arial", 12F);
            this.Pass_textbox.ForeColor = System.Drawing.Color.DimGray;
            this.Pass_textbox.Location = new System.Drawing.Point(17, 101);
            this.Pass_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pass_textbox.Name = "Pass_textbox";
            this.Pass_textbox.PasswordChar = '*';
            this.Pass_textbox.Size = new System.Drawing.Size(181, 26);
            this.Pass_textbox.TabIndex = 1;
            this.Pass_textbox.Text = "הכנס סיסמה";
            this.Pass_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Pass_textbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pass_textbox_MouseClick);
            this.Pass_textbox.TextChanged += new System.EventHandler(this.Pass_textbox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(201, 92);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // UserID_textbox
            // 
            this.UserID_textbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.UserID_textbox.Font = new System.Drawing.Font("Arial", 12F);
            this.UserID_textbox.ForeColor = System.Drawing.Color.DimGray;
            this.UserID_textbox.Location = new System.Drawing.Point(17, 57);
            this.UserID_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserID_textbox.Name = "UserID_textbox";
            this.UserID_textbox.Size = new System.Drawing.Size(181, 26);
            this.UserID_textbox.TabIndex = 0;
            this.UserID_textbox.Text = "הכנס ת.ז";
            this.UserID_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UserID_textbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserID_textbox_MouseClick);
            this.UserID_textbox.TextChanged += new System.EventHandler(this.UserID_textbox_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(201, 47);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.login_backBTN);
            this.panel3.Controls.Add(this.UserID_textbox);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.Pass_textbox);
            this.panel3.Controls.Add(this.LoginBTN);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(243, 70);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 289);
            this.panel3.TabIndex = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 455);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login_backBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button LoginBTN;
        private System.Windows.Forms.TextBox Pass_textbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox UserID_textbox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
    }
}

