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
            this.label1 = new System.Windows.Forms.Label();
            this.notebookBTN_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notebook_TEXTBOX
            // 
            this.notebook_TEXTBOX.BackColor = System.Drawing.SystemColors.InactiveBorder;
            resources.ApplyResources(this.notebook_TEXTBOX, "notebook_TEXTBOX");
            this.notebook_TEXTBOX.ForeColor = System.Drawing.Color.DimGray;
            this.notebook_TEXTBOX.Name = "notebook_TEXTBOX";
            this.notebook_TEXTBOX.TextChanged += new System.EventHandler(this.notebook_TEXTBOX_TextChanged);
            // 
            // notebookBTN
            // 
            this.notebookBTN.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.notebookBTN, "notebookBTN");
            this.notebookBTN.Name = "notebookBTN";
            this.notebookBTN.UseVisualStyleBackColor = false;
            this.notebookBTN.Click += new System.EventHandler(this.notebookBTN_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // notebookBTN_back
            // 
            this.notebookBTN_back.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.notebookBTN_back, "notebookBTN_back");
            this.notebookBTN_back.Name = "notebookBTN_back";
            this.notebookBTN_back.UseVisualStyleBackColor = false;
            this.notebookBTN_back.Click += new System.EventHandler(this.notebookBTN_back_Click);
            // 
            // NoteBook_Num
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.notebookBTN_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notebookBTN);
            this.Controls.Add(this.notebook_TEXTBOX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NoteBook_Num";
            this.Load += new System.EventHandler(this.NoteBook_Num_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox notebook_TEXTBOX;
        private System.Windows.Forms.Button notebookBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button notebookBTN_back;
    }
}