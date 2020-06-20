namespace EasyTest_App
{
    partial class AdminSearchForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxCourse = new System.Windows.Forms.TextBox();
            this.radioButtonCourse = new System.Windows.Forms.RadioButton();
            this.radioButtonExam = new System.Windows.Forms.RadioButton();
            this.textBoxExam = new System.Windows.Forms.TextBox();
            this.textBoxBookID = new System.Windows.Forms.TextBox();
            this.radioButtonBookID = new System.Windows.Forms.RadioButton();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(482, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(924, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = ":אנא בחר אחת מן אפשרויות החיפוש הבאות";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSearch.Location = new System.Drawing.Point(509, 809);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(425, 126);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "חפש";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // textBoxCourse
            // 
            this.textBoxCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCourse.Font = new System.Drawing.Font("Yu Gothic UI", 14F);
            this.textBoxCourse.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxCourse.Location = new System.Drawing.Point(1159, 280);
            this.textBoxCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCourse.Name = "textBoxCourse";
            this.textBoxCourse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxCourse.Size = new System.Drawing.Size(224, 38);
            this.textBoxCourse.TabIndex = 2;
            // 
            // radioButtonCourse
            // 
            this.radioButtonCourse.AutoSize = true;
            this.radioButtonCourse.Checked = true;
            this.radioButtonCourse.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.radioButtonCourse.ForeColor = System.Drawing.Color.DimGray;
            this.radioButtonCourse.Location = new System.Drawing.Point(1159, 218);
            this.radioButtonCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonCourse.Name = "radioButtonCourse";
            this.radioButtonCourse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonCourse.Size = new System.Drawing.Size(224, 52);
            this.radioButtonCourse.TabIndex = 3;
            this.radioButtonCourse.TabStop = true;
            this.radioButtonCourse.Text = "מספר קורס";
            this.radioButtonCourse.UseVisualStyleBackColor = true;
            this.radioButtonCourse.CheckedChanged += new System.EventHandler(this.RadioButtonCourse_CheckedChanged);
            // 
            // radioButtonExam
            // 
            this.radioButtonExam.AutoSize = true;
            this.radioButtonExam.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.radioButtonExam.ForeColor = System.Drawing.Color.DimGray;
            this.radioButtonExam.Location = new System.Drawing.Point(835, 218);
            this.radioButtonExam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonExam.Name = "radioButtonExam";
            this.radioButtonExam.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonExam.Size = new System.Drawing.Size(225, 52);
            this.radioButtonExam.TabIndex = 4;
            this.radioButtonExam.Text = "מספר מבחן";
            this.radioButtonExam.UseVisualStyleBackColor = true;
            this.radioButtonExam.CheckedChanged += new System.EventHandler(this.RadioButtonExam_CheckedChanged);
            // 
            // textBoxExam
            // 
            this.textBoxExam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExam.Enabled = false;
            this.textBoxExam.Font = new System.Drawing.Font("Yu Gothic UI", 14F);
            this.textBoxExam.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxExam.Location = new System.Drawing.Point(836, 280);
            this.textBoxExam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxExam.Name = "textBoxExam";
            this.textBoxExam.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxExam.Size = new System.Drawing.Size(224, 38);
            this.textBoxExam.TabIndex = 5;
            // 
            // textBoxBookID
            // 
            this.textBoxBookID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBookID.Enabled = false;
            this.textBoxBookID.Font = new System.Drawing.Font("Yu Gothic UI", 14F);
            this.textBoxBookID.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxBookID.Location = new System.Drawing.Point(509, 280);
            this.textBoxBookID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBookID.Name = "textBoxBookID";
            this.textBoxBookID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxBookID.Size = new System.Drawing.Size(224, 38);
            this.textBoxBookID.TabIndex = 7;
            // 
            // radioButtonBookID
            // 
            this.radioButtonBookID.AutoSize = true;
            this.radioButtonBookID.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.radioButtonBookID.ForeColor = System.Drawing.Color.DimGray;
            this.radioButtonBookID.Location = new System.Drawing.Point(509, 218);
            this.radioButtonBookID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonBookID.Name = "radioButtonBookID";
            this.radioButtonBookID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonBookID.Size = new System.Drawing.Size(261, 52);
            this.radioButtonBookID.TabIndex = 6;
            this.radioButtonBookID.Text = "מספר מחברת";
            this.radioButtonBookID.UseVisualStyleBackColor = true;
            this.radioButtonBookID.CheckedChanged += new System.EventHandler(this.RadioButtonBookID_CheckedChanged);
            // 
            // listBoxResult
            // 
            this.listBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxResult.Font = new System.Drawing.Font("Yu Gothic UI", 14F);
            this.listBoxResult.ForeColor = System.Drawing.Color.DimGray;
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 38;
            this.listBoxResult.Location = new System.Drawing.Point(509, 335);
            this.listBoxResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxResult.Size = new System.Drawing.Size(874, 456);
            this.listBoxResult.TabIndex = 8;
            this.listBoxResult.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxResult_MouseDoubleClick);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBack.Location = new System.Drawing.Point(958, 809);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(425, 126);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "חזור";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // AdminSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonExam);
            this.Controls.Add(this.textBoxBookID);
            this.Controls.Add(this.radioButtonCourse);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxExam);
            this.Controls.Add(this.radioButtonBookID);
            this.Controls.Add(this.textBoxCourse);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminSearchForm";
            this.Text = "AdminSearchForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminSearchForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminSearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxCourse;
        private System.Windows.Forms.RadioButton radioButtonCourse;
        private System.Windows.Forms.RadioButton radioButtonExam;
        private System.Windows.Forms.TextBox textBoxExam;
        private System.Windows.Forms.TextBox textBoxBookID;
        private System.Windows.Forms.RadioButton radioButtonBookID;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Button buttonBack;
    }
}