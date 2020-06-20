namespace EasyTest_App
{
    partial class NoteBook_Num
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteBook_Num));
            this.notebook_TEXTBOX = new System.Windows.Forms.TextBox();
            this.notebookBTN = new System.Windows.Forms.Button();
            this.notebookBTN_back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.homeBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // notebook_TEXTBOX
            // 
            resources.ApplyResources(this.notebook_TEXTBOX, "notebook_TEXTBOX");
            this.notebook_TEXTBOX.BackColor = System.Drawing.Color.White;
            this.notebook_TEXTBOX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notebook_TEXTBOX.ForeColor = System.Drawing.Color.DimGray;
            this.notebook_TEXTBOX.Name = "notebook_TEXTBOX";
            this.notebook_TEXTBOX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notebook_TEXTBOX_MouseClick);
            this.notebook_TEXTBOX.TextChanged += new System.EventHandler(this.notebook_TEXTBOX_TextChanged);
            // 
            // notebookBTN
            // 
            this.notebookBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(75)))), ((int)(((byte)(174)))));
            this.notebookBTN.FlatAppearance.BorderSize = 0;
            this.notebookBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            resources.ApplyResources(this.notebookBTN, "notebookBTN");
            this.notebookBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.notebookBTN.Name = "notebookBTN";
            this.notebookBTN.UseVisualStyleBackColor = false;
            this.notebookBTN.Click += new System.EventHandler(this.notebookBTN_Click);
            // 
            // notebookBTN_back
            // 
            this.notebookBTN_back.BackColor = System.Drawing.Color.Transparent;
            this.notebookBTN_back.FlatAppearance.BorderSize = 0;
            this.notebookBTN_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            resources.ApplyResources(this.notebookBTN_back, "notebookBTN_back");
            this.notebookBTN_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.notebookBTN_back.Name = "notebookBTN_back";
            this.notebookBTN_back.UseVisualStyleBackColor = false;
            this.notebookBTN_back.Click += new System.EventHandler(this.notebookBTN_back_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Name = "label3";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel6.Controls.Add(this.homeBTN);
            this.panel6.Controls.Add(this.notebookBTN);
            this.panel6.Controls.Add(this.notebookBTN_back);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // homeBTN
            // 
            resources.ApplyResources(this.homeBTN, "homeBTN");
            this.homeBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(75)))), ((int)(((byte)(174)))));
            this.homeBTN.FlatAppearance.BorderSize = 0;
            this.homeBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.homeBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homeBTN.Name = "homeBTN";
            this.homeBTN.UseVisualStyleBackColor = false;
            this.homeBTN.Click += new System.EventHandler(this.homeBTN_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // NoteBook_Num
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.notebook_TEXTBOX);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NoteBook_Num";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox notebook_TEXTBOX;
        private System.Windows.Forms.Button notebookBTN;
        private System.Windows.Forms.Button notebookBTN_back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button homeBTN;
        private System.Windows.Forms.Panel panel1;
    }
}