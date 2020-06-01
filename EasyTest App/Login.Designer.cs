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
            this.UserID_textbox = new System.Windows.Forms.TextBox();
            this.Pass_textbox = new System.Windows.Forms.TextBox();
            this.LoginBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login_backBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserID_textbox
            // 
            this.UserID_textbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.UserID_textbox.Font = new System.Drawing.Font("Arial", 12F);
            this.UserID_textbox.ForeColor = System.Drawing.Color.DimGray;
            this.UserID_textbox.Location = new System.Drawing.Point(270, 126);
            this.UserID_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.UserID_textbox.Name = "UserID_textbox";
            this.UserID_textbox.Size = new System.Drawing.Size(181, 26);
            this.UserID_textbox.TabIndex = 0;
            this.UserID_textbox.Text = "הכנס ת.ז";
            this.UserID_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UserID_textbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserID_textbox_MouseClick);
            this.UserID_textbox.TextChanged += new System.EventHandler(this.UserID_textbox_TextChanged);
            // 
            // Pass_textbox
            // 
            this.Pass_textbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Pass_textbox.Font = new System.Drawing.Font("Arial", 12F);
            this.Pass_textbox.ForeColor = System.Drawing.Color.DimGray;
            this.Pass_textbox.Location = new System.Drawing.Point(270, 170);
            this.Pass_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.Pass_textbox.Name = "Pass_textbox";
            this.Pass_textbox.Size = new System.Drawing.Size(181, 26);
            this.Pass_textbox.TabIndex = 1;
            this.Pass_textbox.Text = "הכנס סיסמה";
            this.Pass_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Pass_textbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pass_textbox_MouseClick);
            this.Pass_textbox.TextChanged += new System.EventHandler(this.Pass_textbox_TextChanged);
            // 
            // LoginBTN
            // 
            this.LoginBTN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LoginBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBTN.Font = new System.Drawing.Font("Arial", 12F);
            this.LoginBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoginBTN.Location = new System.Drawing.Point(339, 222);
            this.LoginBTN.Margin = new System.Windows.Forms.Padding(2);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(111, 36);
            this.LoginBTN.TabIndex = 2;
            this.LoginBTN.Text = "כניסה למערכת";
            this.LoginBTN.UseVisualStyleBackColor = false;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            this.LoginBTN.MouseHover += new System.EventHandler(this.LoginBTN_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 28F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(164, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "EasyTest";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(268, 154);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 1);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(267, 198);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 1);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(453, 117);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(453, 161);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // login_backBTN
            // 
            this.login_backBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.login_backBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_backBTN.Location = new System.Drawing.Point(424, 270);
            this.login_backBTN.Margin = new System.Windows.Forms.Padding(2);
            this.login_backBTN.Name = "login_backBTN";
            this.login_backBTN.Size = new System.Drawing.Size(85, 25);
            this.login_backBTN.TabIndex = 9;
            this.login_backBTN.Text = "חזור";
            this.login_backBTN.UseVisualStyleBackColor = false;
            this.login_backBTN.Visible = false;
            this.login_backBTN.Click += new System.EventHandler(this.login_backBTN_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(520, 306);
            this.Controls.Add(this.login_backBTN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBTN);
            this.Controls.Add(this.Pass_textbox);
            this.Controls.Add(this.UserID_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserID_textbox;
        private System.Windows.Forms.TextBox Pass_textbox;
        private System.Windows.Forms.Button LoginBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button login_backBTN;
    }
}

