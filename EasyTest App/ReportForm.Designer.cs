namespace EasyTest_App
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.label4 = new System.Windows.Forms.Label();
            this.ContentNote = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.note = new System.Windows.Forms.RadioButton();
            this.toilet = new System.Windows.Forms.RadioButton();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.IDAnsLABEL = new System.Windows.Forms.Label();
            this.FullNamAnsLABEL = new System.Windows.Forms.Label();
            this.IdLABEL = new System.Windows.Forms.Label();
            this.FirstNameLABEL = new System.Windows.Forms.Label();
            this.TableLABEL = new System.Windows.Forms.Label();
            this.tableBTN = new System.Windows.Forms.Button();
            this.TimerBTN = new System.Windows.Forms.Button();
            this.ReturnBTN = new System.Windows.Forms.Label();
            this.ExitTimeLBL = new System.Windows.Forms.Label();
            this.ReturnBTN2 = new System.Windows.Forms.Label();
            this.ExitTimeLBL2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(833, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = ":סוג דיווח";
            // 
            // ContentNote
            // 
            this.ContentNote.BackColor = System.Drawing.SystemColors.Window;
            this.ContentNote.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentNote.Location = new System.Drawing.Point(610, 169);
            this.ContentNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ContentNote.Multiline = true;
            this.ContentNote.Name = "ContentNote";
            this.ContentNote.Size = new System.Drawing.Size(358, 213);
            this.ContentNote.TabIndex = 9;
            this.ContentNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ContentNote.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(839, 395);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 52);
            this.button1.TabIndex = 10;
            this.button1.Text = "אישור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(610, 395);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 52);
            this.button2.TabIndex = 11;
            this.button2.Text = "חזור";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(832, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 37);
            this.label7.TabIndex = 19;
            this.label7.Text = ":הזן דיווח";
            // 
            // note
            // 
            this.note.AutoSize = true;
            this.note.BackColor = System.Drawing.Color.Transparent;
            this.note.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.note.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note.ForeColor = System.Drawing.Color.Transparent;
            this.note.Location = new System.Drawing.Point(527, 81);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(137, 24);
            this.note.TabIndex = 20;
            this.note.TabStop = true;
            this.note.Text = "הערת משמעת";
            this.note.UseVisualStyleBackColor = false;
            this.note.CheckedChanged += new System.EventHandler(this.note_CheckedChanged);
            // 
            // toilet
            // 
            this.toilet.AutoSize = true;
            this.toilet.BackColor = System.Drawing.Color.Transparent;
            this.toilet.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toilet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.toilet.ForeColor = System.Drawing.Color.Transparent;
            this.toilet.Location = new System.Drawing.Point(711, 81);
            this.toilet.Name = "toilet";
            this.toilet.Size = new System.Drawing.Size(95, 24);
            this.toilet.TabIndex = 21;
            this.toilet.TabStop = true;
            this.toilet.Text = "שירותים";
            this.toilet.UseVisualStyleBackColor = false;
            this.toilet.CheckedChanged += new System.EventHandler(this.toilet_CheckedChanged);
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "התחצפות",
            "חשד להעתקה"});
            this.comboBox.Location = new System.Drawing.Point(763, 124);
            this.comboBox.Name = "comboBox";
            this.comboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox.Size = new System.Drawing.Size(202, 37);
            this.comboBox.TabIndex = 22;
            this.comboBox.Visible = false;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(46, 32);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(236, 233);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 23;
            this.pictureBox.TabStop = false;
            // 
            // IDAnsLABEL
            // 
            this.IDAnsLABEL.AutoSize = true;
            this.IDAnsLABEL.BackColor = System.Drawing.Color.Transparent;
            this.IDAnsLABEL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDAnsLABEL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IDAnsLABEL.Location = new System.Drawing.Point(12, 331);
            this.IDAnsLABEL.Name = "IDAnsLABEL";
            this.IDAnsLABEL.Size = new System.Drawing.Size(129, 27);
            this.IDAnsLABEL.TabIndex = 27;
            this.IDAnsLABEL.Text = "000000000";
            // 
            // FullNamAnsLABEL
            // 
            this.FullNamAnsLABEL.AutoSize = true;
            this.FullNamAnsLABEL.BackColor = System.Drawing.Color.Transparent;
            this.FullNamAnsLABEL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNamAnsLABEL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FullNamAnsLABEL.Location = new System.Drawing.Point(47, 282);
            this.FullNamAnsLABEL.Name = "FullNamAnsLABEL";
            this.FullNamAnsLABEL.Size = new System.Drawing.Size(129, 27);
            this.FullNamAnsLABEL.TabIndex = 26;
            this.FullNamAnsLABEL.Text = "000000000";
            // 
            // IdLABEL
            // 
            this.IdLABEL.AutoSize = true;
            this.IdLABEL.BackColor = System.Drawing.Color.Transparent;
            this.IdLABEL.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLABEL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IdLABEL.Location = new System.Drawing.Point(147, 329);
            this.IdLABEL.Name = "IdLABEL";
            this.IdLABEL.Size = new System.Drawing.Size(140, 29);
            this.IdLABEL.TabIndex = 25;
            this.IdLABEL.Text = ":תעודת זהות";
            // 
            // FirstNameLABEL
            // 
            this.FirstNameLABEL.AutoSize = true;
            this.FirstNameLABEL.BackColor = System.Drawing.Color.Transparent;
            this.FirstNameLABEL.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLABEL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FirstNameLABEL.Location = new System.Drawing.Point(182, 280);
            this.FirstNameLABEL.Name = "FirstNameLABEL";
            this.FirstNameLABEL.Size = new System.Drawing.Size(100, 29);
            this.FirstNameLABEL.TabIndex = 24;
            this.FirstNameLABEL.Text = ":שם מלא";
            // 
            // TableLABEL
            // 
            this.TableLABEL.AutoSize = true;
            this.TableLABEL.BackColor = System.Drawing.Color.Transparent;
            this.TableLABEL.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableLABEL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TableLABEL.Location = new System.Drawing.Point(140, 378);
            this.TableLABEL.Name = "TableLABEL";
            this.TableLABEL.Size = new System.Drawing.Size(142, 29);
            this.TableLABEL.TabIndex = 29;
            this.TableLABEL.Text = ":מספר שולחן";
            // 
            // tableBTN
            // 
            this.tableBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.tableBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableBTN.Location = new System.Drawing.Point(46, 371);
            this.tableBTN.Name = "tableBTN";
            this.tableBTN.Size = new System.Drawing.Size(63, 45);
            this.tableBTN.TabIndex = 28;
            this.tableBTN.Text = "1";
            this.tableBTN.UseVisualStyleBackColor = false;
            // 
            // TimerBTN
            // 
            this.TimerBTN.Location = new System.Drawing.Point(842, 144);
            this.TimerBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TimerBTN.Name = "TimerBTN";
            this.TimerBTN.Size = new System.Drawing.Size(126, 52);
            this.TimerBTN.TabIndex = 30;
            this.TimerBTN.Text = "התחל טיימר";
            this.TimerBTN.UseVisualStyleBackColor = true;
            this.TimerBTN.Visible = false;
            this.TimerBTN.Click += new System.EventHandler(this.TimerBTN_Click);
            // 
            // ReturnBTN
            // 
            this.ReturnBTN.AutoSize = true;
            this.ReturnBTN.BackColor = System.Drawing.Color.Transparent;
            this.ReturnBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReturnBTN.Location = new System.Drawing.Point(769, 280);
            this.ReturnBTN.Name = "ReturnBTN";
            this.ReturnBTN.Size = new System.Drawing.Size(55, 27);
            this.ReturnBTN.TabIndex = 34;
            this.ReturnBTN.Text = "**:**";
            this.ReturnBTN.Visible = false;
            // 
            // ExitTimeLBL
            // 
            this.ExitTimeLBL.AutoSize = true;
            this.ExitTimeLBL.BackColor = System.Drawing.Color.Transparent;
            this.ExitTimeLBL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitTimeLBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitTimeLBL.Location = new System.Drawing.Point(767, 225);
            this.ExitTimeLBL.Name = "ExitTimeLBL";
            this.ExitTimeLBL.Size = new System.Drawing.Size(55, 27);
            this.ExitTimeLBL.TabIndex = 33;
            this.ExitTimeLBL.Text = "**:**";
            this.ExitTimeLBL.Visible = false;
            // 
            // ReturnBTN2
            // 
            this.ReturnBTN2.AutoSize = true;
            this.ReturnBTN2.BackColor = System.Drawing.Color.Transparent;
            this.ReturnBTN2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBTN2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReturnBTN2.Location = new System.Drawing.Point(846, 272);
            this.ReturnBTN2.Name = "ReturnBTN2";
            this.ReturnBTN2.Size = new System.Drawing.Size(126, 29);
            this.ReturnBTN2.TabIndex = 32;
            this.ReturnBTN2.Text = ":שעת חזרה";
            this.ReturnBTN2.Visible = false;
            // 
            // ExitTimeLBL2
            // 
            this.ExitTimeLBL2.AutoSize = true;
            this.ExitTimeLBL2.BackColor = System.Drawing.Color.Transparent;
            this.ExitTimeLBL2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitTimeLBL2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitTimeLBL2.Location = new System.Drawing.Point(844, 223);
            this.ExitTimeLBL2.Name = "ExitTimeLBL2";
            this.ExitTimeLBL2.Size = new System.Drawing.Size(128, 29);
            this.ExitTimeLBL2.TabIndex = 31;
            this.ExitTimeLBL2.Text = ":שעת יציאה";
            this.ExitTimeLBL2.Visible = false;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(981, 507);
            this.Controls.Add(this.ReturnBTN);
            this.Controls.Add(this.ExitTimeLBL);
            this.Controls.Add(this.ReturnBTN2);
            this.Controls.Add(this.ExitTimeLBL2);
            this.Controls.Add(this.TimerBTN);
            this.Controls.Add(this.TableLABEL);
            this.Controls.Add(this.tableBTN);
            this.Controls.Add(this.IDAnsLABEL);
            this.Controls.Add(this.FullNamAnsLABEL);
            this.Controls.Add(this.IdLABEL);
            this.Controls.Add(this.FirstNameLABEL);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.toilet);
            this.Controls.Add(this.note);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ContentNote);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ContentNote;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton note;
        private System.Windows.Forms.RadioButton toilet;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label IDAnsLABEL;
        private System.Windows.Forms.Label FullNamAnsLABEL;
        private System.Windows.Forms.Label IdLABEL;
        private System.Windows.Forms.Label FirstNameLABEL;
        private System.Windows.Forms.Label TableLABEL;
        private System.Windows.Forms.Button tableBTN;
        private System.Windows.Forms.Button TimerBTN;
        private System.Windows.Forms.Label ReturnBTN;
        private System.Windows.Forms.Label ExitTimeLBL;
        private System.Windows.Forms.Label ReturnBTN2;
        private System.Windows.Forms.Label ExitTimeLBL2;
    }
}