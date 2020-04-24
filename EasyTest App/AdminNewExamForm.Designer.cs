namespace EasyTest_App
{
    partial class AdminNewExamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminNewExamForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCourseCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_proctorID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_lecturerID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_exam_date = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_start_hour = new System.Windows.Forms.TextBox();
            this.textBox_end_hour = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = ":יצירת בחינה";
            // 
            // textBoxCourseCode
            // 
            this.textBoxCourseCode.Location = new System.Drawing.Point(311, 54);
            this.textBoxCourseCode.Name = "textBoxCourseCode";
            this.textBoxCourseCode.Size = new System.Drawing.Size(105, 20);
            this.textBoxCourseCode.TabIndex = 1;
            this.textBoxCourseCode.TextChanged += new System.EventHandler(this.TextBoxCourseCode_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = ":קוד קורס";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = ":מספר משגיח";
            // 
            // textBox_proctorID
            // 
            this.textBox_proctorID.Enabled = false;
            this.textBox_proctorID.Location = new System.Drawing.Point(311, 88);
            this.textBox_proctorID.Name = "textBox_proctorID";
            this.textBox_proctorID.Size = new System.Drawing.Size(105, 20);
            this.textBox_proctorID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = ":מספר מרצה";
            // 
            // textBox_lecturerID
            // 
            this.textBox_lecturerID.Enabled = false;
            this.textBox_lecturerID.Location = new System.Drawing.Point(311, 118);
            this.textBox_lecturerID.Name = "textBox_lecturerID";
            this.textBox_lecturerID.Size = new System.Drawing.Size(105, 20);
            this.textBox_lecturerID.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = ":תאריך בחינה";
            // 
            // textBox_exam_date
            // 
            this.textBox_exam_date.Enabled = false;
            this.textBox_exam_date.Location = new System.Drawing.Point(311, 152);
            this.textBox_exam_date.Name = "textBox_exam_date";
            this.textBox_exam_date.Size = new System.Drawing.Size(105, 20);
            this.textBox_exam_date.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = ":שעת התחלה";
            // 
            // textBox_start_hour
            // 
            this.textBox_start_hour.Enabled = false;
            this.textBox_start_hour.Location = new System.Drawing.Point(311, 183);
            this.textBox_start_hour.Name = "textBox_start_hour";
            this.textBox_start_hour.Size = new System.Drawing.Size(105, 20);
            this.textBox_start_hour.TabIndex = 10;
            // 
            // textBox_end_hour
            // 
            this.textBox_end_hour.Enabled = false;
            this.textBox_end_hour.Location = new System.Drawing.Point(311, 219);
            this.textBox_end_hour.Name = "textBox_end_hour";
            this.textBox_end_hour.Size = new System.Drawing.Size(105, 20);
            this.textBox_end_hour.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = ":שעת סיום";
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(444, 255);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(94, 33);
            this.button_confirm.TabIndex = 13;
            this.button_confirm.Text = "אשר";
            this.button_confirm.UseVisualStyleBackColor = true;
            // 
            // button_reset
            // 
            this.button_reset.Enabled = false;
            this.button_reset.Location = new System.Drawing.Point(220, 255);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(94, 33);
            this.button_reset.TabIndex = 14;
            this.button_reset.Text = "אפס";
            this.button_reset.UseVisualStyleBackColor = true;
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(29, 255);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(94, 33);
            this.button_back.TabIndex = 15;
            this.button_back.Text = "חזור";
            this.button_back.UseVisualStyleBackColor = true;
            // 
            // AdminNewExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(569, 300);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_end_hour);
            this.Controls.Add(this.textBox_start_hour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_exam_date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_lecturerID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_proctorID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCourseCode);
            this.Controls.Add(this.label1);
            this.Name = "AdminNewExamForm";
            this.Text = "AdminNewExamForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCourseCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_proctorID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_lecturerID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_exam_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_start_hour;
        private System.Windows.Forms.TextBox textBox_end_hour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_back;
    }
}