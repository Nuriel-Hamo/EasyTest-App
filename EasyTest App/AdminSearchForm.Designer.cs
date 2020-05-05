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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSearchForm));
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
            this.label1.Location = new System.Drawing.Point(347, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = ":אנא בחר אחת מן אפשרויות החיפוש הבאות";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(404, 116);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(137, 22);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "חפש";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // textBoxCourse
            // 
            this.textBoxCourse.Location = new System.Drawing.Point(430, 76);
            this.textBoxCourse.Name = "textBoxCourse";
            this.textBoxCourse.Size = new System.Drawing.Size(111, 20);
            this.textBoxCourse.TabIndex = 2;
            // 
            // radioButtonCourse
            // 
            this.radioButtonCourse.AutoSize = true;
            this.radioButtonCourse.Checked = true;
            this.radioButtonCourse.Location = new System.Drawing.Point(456, 53);
            this.radioButtonCourse.Name = "radioButtonCourse";
            this.radioButtonCourse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonCourse.Size = new System.Drawing.Size(80, 17);
            this.radioButtonCourse.TabIndex = 3;
            this.radioButtonCourse.TabStop = true;
            this.radioButtonCourse.Text = "מספר קורס";
            this.radioButtonCourse.UseVisualStyleBackColor = true;
            // 
            // radioButtonExam
            // 
            this.radioButtonExam.AutoSize = true;
            this.radioButtonExam.Location = new System.Drawing.Point(317, 53);
            this.radioButtonExam.Name = "radioButtonExam";
            this.radioButtonExam.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonExam.Size = new System.Drawing.Size(81, 17);
            this.radioButtonExam.TabIndex = 4;
            this.radioButtonExam.Text = "מספר מבחן";
            this.radioButtonExam.UseVisualStyleBackColor = true;
            // 
            // textBoxExam
            // 
            this.textBoxExam.Enabled = false;
            this.textBoxExam.Location = new System.Drawing.Point(287, 76);
            this.textBoxExam.Name = "textBoxExam";
            this.textBoxExam.Size = new System.Drawing.Size(111, 20);
            this.textBoxExam.TabIndex = 5;
            // 
            // textBoxBookID
            // 
            this.textBoxBookID.Enabled = false;
            this.textBoxBookID.Location = new System.Drawing.Point(135, 76);
            this.textBoxBookID.Name = "textBoxBookID";
            this.textBoxBookID.Size = new System.Drawing.Size(111, 20);
            this.textBoxBookID.TabIndex = 7;
            // 
            // radioButtonBookID
            // 
            this.radioButtonBookID.AutoSize = true;
            this.radioButtonBookID.Location = new System.Drawing.Point(157, 53);
            this.radioButtonBookID.Name = "radioButtonBookID";
            this.radioButtonBookID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonBookID.Size = new System.Drawing.Size(89, 17);
            this.radioButtonBookID.TabIndex = 6;
            this.radioButtonBookID.Text = "מספר מחברת";
            this.radioButtonBookID.UseVisualStyleBackColor = true;
            // 
            // listBoxResult
            // 
            this.listBoxResult.Enabled = false;
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(94, 157);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(447, 134);
            this.listBoxResult.TabIndex = 8;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(109, 116);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(137, 22);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "חזור";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // AdminSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(588, 313);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.textBoxBookID);
            this.Controls.Add(this.radioButtonBookID);
            this.Controls.Add(this.textBoxExam);
            this.Controls.Add(this.radioButtonExam);
            this.Controls.Add(this.radioButtonCourse);
            this.Controls.Add(this.textBoxCourse);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label1);
            this.Name = "AdminSearchForm";
            this.Text = "AdminSearchForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminSearchForm_FormClosing);
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