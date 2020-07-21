using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTest_App.DB;
using MySql.Data.MySqlClient;


namespace EasyTest_App
{
    public partial class MadorReportDetailes : Form
    {
        public MadorReportDetailes()
        {
            InitializeComponent();
        }
        public delegate void ReportString(string ReportDetails);
        public static event ReportString ReportStringEvent;

        private void sendReportBTN_Click(object sender, EventArgs e)
        {
            if (DBManager.SetMadorReport(MadorReport.typeOfReport, textBoxRepot.Text))
            {
                MessageBox.Show("דיווח נשלח בהצלחה", "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReportStringEvent?.Invoke(textBoxRepot.Text);


            }
            else
            {
                MessageBox.Show("תקלה בשליחת הדיווח, יש ליצור קשר טלפוני עם מדור בחינות", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }
     

        private void returnBTN_Click(object sender, EventArgs e)
        {
            MadorReport mr = new MadorReport();
            mr.Show();
            Hide();

        }

        private void homeBTN_Click(object sender, EventArgs e)
        {
            Login.main_screen.Show();
            Hide();

        }
    }
}
