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
            this.BeginExamBTN = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimerLBL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TablePic = new System.Windows.Forms.PictureBox();
            this.dateLBL = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.toiletError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.labelExTime1 = new System.Windows.Forms.Label();
            this.finishError = new System.Windows.Forms.ErrorProvider(this.components);
            this.timerExtra1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toiletError)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finishError)).BeginInit();
            this.SuspendLayout();
            // 
            // AddStudentBTN
            // 
            resources.ApplyResources(this.AddStudentBTN, "AddStudentBTN");
            this.AddStudentBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(75)))), ((int)(((byte)(174)))));
            this.AddStudentBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finishError.SetError(this.AddStudentBTN, resources.GetString("AddStudentBTN.Error"));
            this.toiletError.SetError(this.AddStudentBTN, resources.GetString("AddStudentBTN.Error1"));
            this.AddStudentBTN.FlatAppearance.BorderSize = 0;
            this.AddStudentBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.AddStudentBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.finishError.SetIconAlignment(this.AddStudentBTN, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("AddStudentBTN.IconAlignment"))));
            this.toiletError.SetIconAlignment(this.AddStudentBTN, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("AddStudentBTN.IconAlignment1"))));
            this.toiletError.SetIconPadding(this.AddStudentBTN, ((int)(resources.GetObject("AddStudentBTN.IconPadding"))));
            this.finishError.SetIconPadding(this.AddStudentBTN, ((int)(resources.GetObject("AddStudentBTN.IconPadding1"))));
            this.AddStudentBTN.Name = "AddStudentBTN";
            this.AddStudentBTN.UseVisualStyleBackColor = false;
            this.AddStudentBTN.Click += new System.EventHandler(this.AddStudentBTN_Click);
            // 
            // ReportBTN
            // 
            resources.ApplyResources(this.ReportBTN, "ReportBTN");
            this.ReportBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(75)))), ((int)(((byte)(174)))));
            this.ReportBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finishError.SetError(this.ReportBTN, resources.GetString("ReportBTN.Error"));
            this.toiletError.SetError(this.ReportBTN, resources.GetString("ReportBTN.Error1"));
            this.ReportBTN.FlatAppearance.BorderSize = 0;
            this.ReportBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.ReportBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.finishError.SetIconAlignment(this.ReportBTN, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ReportBTN.IconAlignment"))));
            this.toiletError.SetIconAlignment(this.ReportBTN, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ReportBTN.IconAlignment1"))));
            this.toiletError.SetIconPadding(this.ReportBTN, ((int)(resources.GetObject("ReportBTN.IconPadding"))));
            this.finishError.SetIconPadding(this.ReportBTN, ((int)(resources.GetObject("ReportBTN.IconPadding1"))));
            this.ReportBTN.Name = "ReportBTN";
            this.ReportBTN.UseVisualStyleBackColor = false;
            this.ReportBTN.Click += new System.EventHandler(this.ReportBTN_Click);
            // 
            // ExtraTimeBTN
            // 
            resources.ApplyResources(this.ExtraTimeBTN, "ExtraTimeBTN");
            this.ExtraTimeBTN.BackColor = System.Drawing.Color.Transparent;
            this.ExtraTimeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finishError.SetError(this.ExtraTimeBTN, resources.GetString("ExtraTimeBTN.Error"));
            this.toiletError.SetError(this.ExtraTimeBTN, resources.GetString("ExtraTimeBTN.Error1"));
            this.ExtraTimeBTN.FlatAppearance.BorderSize = 0;
            this.ExtraTimeBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.ExtraTimeBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.finishError.SetIconAlignment(this.ExtraTimeBTN, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ExtraTimeBTN.IconAlignment"))));
            this.toiletError.SetIconAlignment(this.ExtraTimeBTN, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ExtraTimeBTN.IconAlignment1"))));
            this.toiletError.SetIconPadding(this.ExtraTimeBTN, ((int)(resources.GetObject("ExtraTimeBTN.IconPadding"))));
            this.finishError.SetIconPadding(this.ExtraTimeBTN, ((int)(resources.GetObject("ExtraTimeBTN.IconPadding1"))));
            this.ExtraTimeBTN.Name = "ExtraTimeBTN";
            this.ExtraTimeBTN.UseVisualStyleBackColor = false;
            this.ExtraTimeBTN.Click += new System.EventHandler(this.ExtraTimeBTN_Click);
            // 
            // BeginExamBTN
            // 
            resources.ApplyResources(this.BeginExamBTN, "BeginExamBTN");
            this.BeginExamBTN.BackColor = System.Drawing.Color.Transparent;
            this.BeginExamBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finishError.SetError(this.BeginExamBTN, resources.GetString("BeginExamBTN.Error"));
            this.toiletError.SetError(this.BeginExamBTN, resources.GetString("BeginExamBTN.Error1"));
            this.BeginExamBTN.FlatAppearance.BorderSize = 0;
            this.BeginExamBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.BeginExamBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.finishError.SetIconAlignment(this.BeginExamBTN, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("BeginExamBTN.IconAlignment"))));
            this.toiletError.SetIconAlignment(this.BeginExamBTN, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("BeginExamBTN.IconAlignment1"))));
            this.toiletError.SetIconPadding(this.BeginExamBTN, ((int)(resources.GetObject("BeginExamBTN.IconPadding"))));
            this.finishError.SetIconPadding(this.BeginExamBTN, ((int)(resources.GetObject("BeginExamBTN.IconPadding1"))));
            this.BeginExamBTN.Name = "BeginExamBTN";
            this.BeginExamBTN.UseVisualStyleBackColor = false;
            this.BeginExamBTN.Click += new System.EventHandler(this.BeginExamBTN_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerLBL
            // 
            resources.ApplyResources(this.TimerLBL, "TimerLBL");
            this.TimerLBL.BackColor = System.Drawing.Color.Transparent;
            this.toiletError.SetError(this.TimerLBL, resources.GetString("TimerLBL.Error"));
            this.finishError.SetError(this.TimerLBL, resources.GetString("TimerLBL.Error1"));
            this.TimerLBL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.finishError.SetIconAlignment(this.TimerLBL, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("TimerLBL.IconAlignment"))));
            this.toiletError.SetIconAlignment(this.TimerLBL, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("TimerLBL.IconAlignment1"))));
            this.finishError.SetIconPadding(this.TimerLBL, ((int)(resources.GetObject("TimerLBL.IconPadding"))));
            this.toiletError.SetIconPadding(this.TimerLBL, ((int)(resources.GetObject("TimerLBL.IconPadding1"))));
            this.TimerLBL.Name = "TimerLBL";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TablePic);
            this.finishError.SetError(this.panel1, resources.GetString("panel1.Error"));
            this.toiletError.SetError(this.panel1, resources.GetString("panel1.Error1"));
            this.finishError.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment"))));
            this.toiletError.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment1"))));
            this.finishError.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding"))));
            this.toiletError.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding1"))));
            this.panel1.Name = "panel1";
            // 
            // TablePic
            // 
            resources.ApplyResources(this.TablePic, "TablePic");
            this.TablePic.BackColor = System.Drawing.Color.Transparent;
            this.finishError.SetError(this.TablePic, resources.GetString("TablePic.Error"));
            this.toiletError.SetError(this.TablePic, resources.GetString("TablePic.Error1"));
            this.finishError.SetIconAlignment(this.TablePic, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("TablePic.IconAlignment"))));
            this.toiletError.SetIconAlignment(this.TablePic, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("TablePic.IconAlignment1"))));
            this.finishError.SetIconPadding(this.TablePic, ((int)(resources.GetObject("TablePic.IconPadding"))));
            this.toiletError.SetIconPadding(this.TablePic, ((int)(resources.GetObject("TablePic.IconPadding1"))));
            this.TablePic.Name = "TablePic";
            this.TablePic.TabStop = false;
            // 
            // dateLBL
            // 
            resources.ApplyResources(this.dateLBL, "dateLBL");
            this.dateLBL.BackColor = System.Drawing.Color.Transparent;
            this.toiletError.SetError(this.dateLBL, resources.GetString("dateLBL.Error"));
            this.finishError.SetError(this.dateLBL, resources.GetString("dateLBL.Error1"));
            this.dateLBL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.finishError.SetIconAlignment(this.dateLBL, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dateLBL.IconAlignment"))));
            this.toiletError.SetIconAlignment(this.dateLBL, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dateLBL.IconAlignment1"))));
            this.finishError.SetIconPadding(this.dateLBL, ((int)(resources.GetObject("dateLBL.IconPadding"))));
            this.toiletError.SetIconPadding(this.dateLBL, ((int)(resources.GetObject("dateLBL.IconPadding1"))));
            this.dateLBL.Name = "dateLBL";
            // 
            // labelName
            // 
            resources.ApplyResources(this.labelName, "labelName");
            this.toiletError.SetError(this.labelName, resources.GetString("labelName.Error"));
            this.finishError.SetError(this.labelName, resources.GetString("labelName.Error1"));
            this.labelName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.finishError.SetIconAlignment(this.labelName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("labelName.IconAlignment"))));
            this.toiletError.SetIconAlignment(this.labelName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("labelName.IconAlignment1"))));
            this.finishError.SetIconPadding(this.labelName, ((int)(resources.GetObject("labelName.IconPadding"))));
            this.toiletError.SetIconPadding(this.labelName, ((int)(resources.GetObject("labelName.IconPadding1"))));
            this.labelName.Name = "labelName";
            // 
            // toiletError
            // 
            this.toiletError.BlinkRate = 1000;
            this.toiletError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.toiletError.ContainerControl = this;
            resources.ApplyResources(this.toiletError, "toiletError");
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.finishError.SetError(this.panel3, resources.GetString("panel3.Error"));
            this.toiletError.SetError(this.panel3, resources.GetString("panel3.Error1"));
            this.finishError.SetIconAlignment(this.panel3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel3.IconAlignment"))));
            this.toiletError.SetIconAlignment(this.panel3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel3.IconAlignment1"))));
            this.finishError.SetIconPadding(this.panel3, ((int)(resources.GetObject("panel3.IconPadding"))));
            this.toiletError.SetIconPadding(this.panel3, ((int)(resources.GetObject("panel3.IconPadding1"))));
            this.panel3.Name = "panel3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.toiletError.SetError(this.label1, resources.GetString("label1.Error"));
            this.finishError.SetError(this.label1, resources.GetString("label1.Error1"));
            this.finishError.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.toiletError.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment1"))));
            this.finishError.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.toiletError.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding1"))));
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.toiletError.SetError(this.label2, resources.GetString("label2.Error"));
            this.finishError.SetError(this.label2, resources.GetString("label2.Error1"));
            this.finishError.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.toiletError.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment1"))));
            this.finishError.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.toiletError.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding1"))));
            this.label2.Name = "label2";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Controls.Add(this.pictureBox1);
            this.finishError.SetError(this.panel4, resources.GetString("panel4.Error"));
            this.toiletError.SetError(this.panel4, resources.GetString("panel4.Error1"));
            this.finishError.SetIconAlignment(this.panel4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel4.IconAlignment"))));
            this.toiletError.SetIconAlignment(this.panel4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel4.IconAlignment1"))));
            this.finishError.SetIconPadding(this.panel4, ((int)(resources.GetObject("panel4.IconPadding"))));
            this.toiletError.SetIconPadding(this.panel4, ((int)(resources.GetObject("panel4.IconPadding1"))));
            this.panel4.Name = "panel4";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.finishError.SetError(this.pictureBox1, resources.GetString("pictureBox1.Error"));
            this.toiletError.SetError(this.pictureBox1, resources.GetString("pictureBox1.Error1"));
            this.finishError.SetIconAlignment(this.pictureBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox1.IconAlignment"))));
            this.toiletError.SetIconAlignment(this.pictureBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox1.IconAlignment1"))));
            this.finishError.SetIconPadding(this.pictureBox1, ((int)(resources.GetObject("pictureBox1.IconPadding"))));
            this.toiletError.SetIconPadding(this.pictureBox1, ((int)(resources.GetObject("pictureBox1.IconPadding1"))));
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.toiletError.SetError(this.label3, resources.GetString("label3.Error"));
            this.finishError.SetError(this.label3, resources.GetString("label3.Error1"));
            this.finishError.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.toiletError.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment1"))));
            this.finishError.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.toiletError.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding1"))));
            this.label3.Name = "label3";
            // 
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.BackColor = System.Drawing.Color.Green;
            this.panel5.Controls.Add(this.pictureBox2);
            this.finishError.SetError(this.panel5, resources.GetString("panel5.Error"));
            this.toiletError.SetError(this.panel5, resources.GetString("panel5.Error1"));
            this.finishError.SetIconAlignment(this.panel5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel5.IconAlignment"))));
            this.toiletError.SetIconAlignment(this.panel5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel5.IconAlignment1"))));
            this.finishError.SetIconPadding(this.panel5, ((int)(resources.GetObject("panel5.IconPadding"))));
            this.toiletError.SetIconPadding(this.panel5, ((int)(resources.GetObject("panel5.IconPadding1"))));
            this.panel5.Name = "panel5";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.finishError.SetError(this.pictureBox2, resources.GetString("pictureBox2.Error"));
            this.toiletError.SetError(this.pictureBox2, resources.GetString("pictureBox2.Error1"));
            this.finishError.SetIconAlignment(this.pictureBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox2.IconAlignment"))));
            this.toiletError.SetIconAlignment(this.pictureBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox2.IconAlignment1"))));
            this.finishError.SetIconPadding(this.pictureBox2, ((int)(resources.GetObject("pictureBox2.IconPadding"))));
            this.toiletError.SetIconPadding(this.pictureBox2, ((int)(resources.GetObject("pictureBox2.IconPadding1"))));
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // panel6
            // 
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.labelName);
            this.panel6.Controls.Add(this.AddStudentBTN);
            this.panel6.Controls.Add(this.ReportBTN);
            this.panel6.Controls.Add(this.ExtraTimeBTN);
            this.panel6.Controls.Add(this.BeginExamBTN);
            this.finishError.SetError(this.panel6, resources.GetString("panel6.Error"));
            this.toiletError.SetError(this.panel6, resources.GetString("panel6.Error1"));
            this.finishError.SetIconAlignment(this.panel6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel6.IconAlignment"))));
            this.toiletError.SetIconAlignment(this.panel6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel6.IconAlignment1"))));
            this.finishError.SetIconPadding(this.panel6, ((int)(resources.GetObject("panel6.IconPadding"))));
            this.toiletError.SetIconPadding(this.panel6, ((int)(resources.GetObject("panel6.IconPadding1"))));
            this.panel6.Name = "panel6";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.toiletError.SetError(this.label4, resources.GetString("label4.Error"));
            this.finishError.SetError(this.label4, resources.GetString("label4.Error1"));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.finishError.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.toiletError.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment1"))));
            this.finishError.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.toiletError.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding1"))));
            this.label4.Name = "label4";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label3);
            this.finishError.SetError(this.panel2, resources.GetString("panel2.Error"));
            this.toiletError.SetError(this.panel2, resources.GetString("panel2.Error1"));
            this.finishError.SetIconAlignment(this.panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel2.IconAlignment"))));
            this.toiletError.SetIconAlignment(this.panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel2.IconAlignment1"))));
            this.finishError.SetIconPadding(this.panel2, ((int)(resources.GetObject("panel2.IconPadding"))));
            this.toiletError.SetIconPadding(this.panel2, ((int)(resources.GetObject("panel2.IconPadding1"))));
            this.panel2.Name = "panel2";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.toiletError.SetError(this.label6, resources.GetString("label6.Error"));
            this.finishError.SetError(this.label6, resources.GetString("label6.Error1"));
            this.finishError.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment"))));
            this.toiletError.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment1"))));
            this.finishError.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding"))));
            this.toiletError.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding1"))));
            this.label6.Name = "label6";
            // 
            // panel7
            // 
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.BackColor = System.Drawing.Color.LightGray;
            this.finishError.SetError(this.panel7, resources.GetString("panel7.Error"));
            this.toiletError.SetError(this.panel7, resources.GetString("panel7.Error1"));
            this.finishError.SetIconAlignment(this.panel7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel7.IconAlignment"))));
            this.toiletError.SetIconAlignment(this.panel7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel7.IconAlignment1"))));
            this.finishError.SetIconPadding(this.panel7, ((int)(resources.GetObject("panel7.IconPadding"))));
            this.toiletError.SetIconPadding(this.panel7, ((int)(resources.GetObject("panel7.IconPadding1"))));
            this.panel7.Name = "panel7";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.toiletError.SetError(this.label5, resources.GetString("label5.Error"));
            this.finishError.SetError(this.label5, resources.GetString("label5.Error1"));
            this.finishError.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment"))));
            this.toiletError.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment1"))));
            this.finishError.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding"))));
            this.toiletError.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding1"))));
            this.label5.Name = "label5";
            // 
            // labelExTime1
            // 
            resources.ApplyResources(this.labelExTime1, "labelExTime1");
            this.toiletError.SetError(this.labelExTime1, resources.GetString("labelExTime1.Error"));
            this.finishError.SetError(this.labelExTime1, resources.GetString("labelExTime1.Error1"));
            this.labelExTime1.ForeColor = System.Drawing.Color.Black;
            this.finishError.SetIconAlignment(this.labelExTime1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("labelExTime1.IconAlignment"))));
            this.toiletError.SetIconAlignment(this.labelExTime1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("labelExTime1.IconAlignment1"))));
            this.finishError.SetIconPadding(this.labelExTime1, ((int)(resources.GetObject("labelExTime1.IconPadding"))));
            this.toiletError.SetIconPadding(this.labelExTime1, ((int)(resources.GetObject("labelExTime1.IconPadding1"))));
            this.labelExTime1.Name = "labelExTime1";
            // 
            // finishError
            // 
            this.finishError.ContainerControl = this;
            resources.ApplyResources(this.finishError, "finishError");
            // 
            // timerExtra1
            // 
            this.timerExtra1.Interval = 1000;
            this.timerExtra1.Tick += new System.EventHandler(this.timerExtra1_Tick);
            // 
            // Main_Screen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelExTime1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dateLBL);
            this.Controls.Add(this.TimerLBL);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Main_Screen_Activated);
            this.Load += new System.EventHandler(this.Main_Screen_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toiletError)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finishError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddStudentBTN;
        private System.Windows.Forms.Button ReportBTN;
        private System.Windows.Forms.Button ExtraTimeBTN;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimerLBL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BeginExamBTN;
        private System.Windows.Forms.Label dateLBL;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider finishError;
        private System.Windows.Forms.ErrorProvider toiletError;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelExTime1;
        private System.Windows.Forms.Timer timerExtra1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox TablePic;
    }
}