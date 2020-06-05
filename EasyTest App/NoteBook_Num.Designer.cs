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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notebook_TEXTBOX
            // 
            this.notebook_TEXTBOX.BackColor = System.Drawing.Color.White;
            this.notebook_TEXTBOX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.notebook_TEXTBOX, "notebook_TEXTBOX");
            this.notebook_TEXTBOX.ForeColor = System.Drawing.Color.DimGray;
            this.notebook_TEXTBOX.Name = "notebook_TEXTBOX";
            this.notebook_TEXTBOX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notebook_TEXTBOX_MouseClick);
            this.notebook_TEXTBOX.TextChanged += new System.EventHandler(this.notebook_TEXTBOX_TextChanged);
            // 
            // notebookBTN
            // 
            this.notebookBTN.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.notebookBTN, "notebookBTN");
            this.notebookBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.notebookBTN.Name = "notebookBTN";
            this.notebookBTN.UseVisualStyleBackColor = false;
            this.notebookBTN.Click += new System.EventHandler(this.notebookBTN_Click);
            // 
            // notebookBTN_back
            // 
            this.notebookBTN_back.BackColor = System.Drawing.Color.DodgerBlue;
            this.notebookBTN_back.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.notebookBTN_back, "notebookBTN_back");
            this.notebookBTN_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.notebookBTN_back.Name = "notebookBTN_back";
            this.notebookBTN_back.UseVisualStyleBackColor = false;
            this.notebookBTN_back.Click += new System.EventHandler(this.notebookBTN_back_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Name = "panel1";
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
            // NoteBook_Num
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.notebookBTN_back);
            this.Controls.Add(this.notebookBTN);
            this.Controls.Add(this.notebook_TEXTBOX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NoteBook_Num";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NoteBook_Num_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox notebook_TEXTBOX;
        private System.Windows.Forms.Button notebookBTN;
        private System.Windows.Forms.Button notebookBTN_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}