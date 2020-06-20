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

        private void sendReportBTN_Click(object sender, EventArgs e)
        {
            if (DBManager.SetMadorReport(MadorReport.typeOfReport, textBoxRepot.Text))
            {
                MessageBox.Show("דיווח נשלח בהצלחה", "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
