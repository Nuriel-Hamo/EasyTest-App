namespace EasyTest_App
{
    partial class ExamSummary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backBTN = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.DateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LecturerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProctorsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtraTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backBTN
            // 
            this.backBTN.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.backBTN.Location = new System.Drawing.Point(1598, 907);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(279, 86);
            this.backBTN.TabIndex = 1;
            this.backBTN.Text = "חזור";
            this.backBTN.UseVisualStyleBackColor = true;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateCol,
            this.TimeCol,
            this.RealTimeCol,
            this.Subject,
            this.ClassCol,
            this.LecturerName,
            this.ProctorsCol,
            this.ExtraTimeCol,
            this.ReportCol,
            this.StudentNumCol});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.Location = new System.Drawing.Point(23, 185);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(1854, 683);
            this.dataGridView.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 28F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(-1, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1894, 68);
            this.label3.TabIndex = 15;
            this.label3.Text = "סיכום בחינות";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateCol
            // 
            this.DateCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.DateCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.DateCol.HeaderText = "תאריך";
            this.DateCol.MinimumWidth = 8;
            this.DateCol.Name = "DateCol";
            this.DateCol.ReadOnly = true;
            this.DateCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TimeCol
            // 
            this.TimeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TimeCol.HeaderText = "שעות בחינה";
            this.TimeCol.MinimumWidth = 8;
            this.TimeCol.Name = "TimeCol";
            this.TimeCol.ReadOnly = true;
            // 
            // RealTimeCol
            // 
            this.RealTimeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RealTimeCol.HeaderText = "שעות בחינה בפועל";
            this.RealTimeCol.MinimumWidth = 8;
            this.RealTimeCol.Name = "RealTimeCol";
            this.RealTimeCol.ReadOnly = true;
            // 
            // Subject
            // 
            this.Subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Subject.HeaderText = "מקצוע";
            this.Subject.MinimumWidth = 8;
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            // 
            // ClassCol
            // 
            this.ClassCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClassCol.HeaderText = "מס\' כיתה";
            this.ClassCol.MinimumWidth = 8;
            this.ClassCol.Name = "ClassCol";
            this.ClassCol.ReadOnly = true;
            // 
            // LecturerName
            // 
            this.LecturerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LecturerName.HeaderText = "מרצה";
            this.LecturerName.MinimumWidth = 8;
            this.LecturerName.Name = "LecturerName";
            this.LecturerName.ReadOnly = true;
            // 
            // ProctorsCol
            // 
            this.ProctorsCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProctorsCol.HeaderText = "משגיחים";
            this.ProctorsCol.MinimumWidth = 8;
            this.ProctorsCol.Name = "ProctorsCol";
            this.ProctorsCol.ReadOnly = true;
            // 
            // ExtraTimeCol
            // 
            this.ExtraTimeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExtraTimeCol.HeaderText = "הארכות זמן";
            this.ExtraTimeCol.MinimumWidth = 8;
            this.ExtraTimeCol.Name = "ExtraTimeCol";
            this.ExtraTimeCol.ReadOnly = true;
            // 
            // ReportCol
            // 
            this.ReportCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReportCol.HeaderText = "אירועים מיוחדים";
            this.ReportCol.MinimumWidth = 8;
            this.ReportCol.Name = "ReportCol";
            this.ReportCol.ReadOnly = true;
            // 
            // StudentNumCol
            // 
            this.StudentNumCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentNumCol.HeaderText = "מס\' סטודנטים";
            this.StudentNumCol.MinimumWidth = 8;
            this.StudentNumCol.Name = "StudentNumCol";
            this.StudentNumCol.ReadOnly = true;
            // 
            // ExamSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.dataGridView);
            this.Name = "ExamSummary";
            this.Text = "ExamSummary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExamSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LecturerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProctorsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtraTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNumCol;
    }
}