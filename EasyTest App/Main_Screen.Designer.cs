namespace EasyTest_App
{
    partial class Main_Screen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Screen));
            this.AddStudentBTN = new System.Windows.Forms.Button();
            this.ReportBTN = new System.Windows.Forms.Button();
            this.ExtraTimeBTN = new System.Windows.Forms.Button();
            this.EndExamBTN = new System.Windows.Forms.Button();
            this.BeginExamBTN = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // AddStudentBTN
            // 
            this.AddStudentBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddStudentBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStudentBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudentBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddStudentBTN.Location = new System.Drawing.Point(567, 92);
            this.AddStudentBTN.Name = "AddStudentBTN";
            this.AddStudentBTN.Size = new System.Drawing.Size(201, 43);
            this.AddStudentBTN.TabIndex = 0;
            this.AddStudentBTN.Text = "הוספת סטודנט חדש";
            this.AddStudentBTN.UseVisualStyleBackColor = false;
            this.AddStudentBTN.Click += new System.EventHandler(this.AddStudentBTN_Click);
            // 
            // ReportBTN
            // 
            this.ReportBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.ReportBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ReportBTN.Location = new System.Drawing.Point(567, 152);
            this.ReportBTN.Name = "ReportBTN";
            this.ReportBTN.Size = new System.Drawing.Size(201, 43);
            this.ReportBTN.TabIndex = 1;
            this.ReportBTN.Text = "דיווח למדור בחינות";
            this.ReportBTN.UseVisualStyleBackColor = false;
            this.ReportBTN.Click += new System.EventHandler(this.ReportBTN_Click);
            // 
            // ExtraTimeBTN
            // 
            this.ExtraTimeBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.ExtraTimeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExtraTimeBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraTimeBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExtraTimeBTN.Location = new System.Drawing.Point(567, 214);
            this.ExtraTimeBTN.Name = "ExtraTimeBTN";
            this.ExtraTimeBTN.Size = new System.Drawing.Size(201, 43);
            this.ExtraTimeBTN.TabIndex = 2;
            this.ExtraTimeBTN.Text = "הזן הארכת זמן";
            this.ExtraTimeBTN.UseVisualStyleBackColor = false;
            this.ExtraTimeBTN.Click += new System.EventHandler(this.ExtraTimeBTN_Click);
            // 
            // EndExamBTN
            // 
            this.EndExamBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.EndExamBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EndExamBTN.Enabled = false;
            this.EndExamBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndExamBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EndExamBTN.Location = new System.Drawing.Point(32, 385);
            this.EndExamBTN.Name = "EndExamBTN";
            this.EndExamBTN.Size = new System.Drawing.Size(150, 43);
            this.EndExamBTN.TabIndex = 4;
            this.EndExamBTN.Text = "סיים בחינה";
            this.EndExamBTN.UseVisualStyleBackColor = false;
            this.EndExamBTN.Click += new System.EventHandler(this.EndExamBTN_Click);
            // 
            // BeginExamBTN
            // 
            this.BeginExamBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.BeginExamBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BeginExamBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeginExamBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BeginExamBTN.Location = new System.Drawing.Point(264, 385);
            this.BeginExamBTN.Name = "BeginExamBTN";
            this.BeginExamBTN.Size = new System.Drawing.Size(150, 43);
            this.BeginExamBTN.TabIndex = 5;
            this.BeginExamBTN.Text = "התחל בחינה";
            this.BeginExamBTN.UseVisualStyleBackColor = false;
            this.BeginExamBTN.Click += new System.EventHandler(this.BeginExamBTN_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(622, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 56);
            this.label1.TabIndex = 7;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelName.Location = new System.Drawing.Point(729, 40);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 20);
            this.labelName.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(42, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 178);
            this.panel1.TabIndex = 10;
            // 
            // Main_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 471);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BeginExamBTN);
            this.Controls.Add(this.EndExamBTN);
            this.Controls.Add(this.ExtraTimeBTN);
            this.Controls.Add(this.ReportBTN);
            this.Controls.Add(this.AddStudentBTN);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Screen";
            this.Activated += new System.EventHandler(this.Main_Screen_Activated);
            this.Load += new System.EventHandler(this.Main_Screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddStudentBTN;
        private System.Windows.Forms.Button ReportBTN;
        private System.Windows.Forms.Button ExtraTimeBTN;
        private System.Windows.Forms.Button EndExamBTN;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BeginExamBTN;
    }
}