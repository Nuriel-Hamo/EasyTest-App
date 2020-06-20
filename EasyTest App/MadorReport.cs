using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EasyTest_App
{
    public partial class MadorReport : Form
    {
        public static string typeOfReport;
        public MadorReport()
        {
            InitializeComponent();
        }

        private void AddStudentBTN_Click(object sender, EventArgs e)
        {
            Login.main_screen.Show();
            Hide();
        }
        

        private void AirConPIC_Click(object sender, EventArgs e)
        {
            typeOfReport ="air_con_problem";
            MadorReportDetailes md = new MadorReportDetailes();
            md.Show();
            Hide();
        }

        private void computerPIC_Click(object sender, EventArgs e)
        {
            typeOfReport = "computer_problem";
            MadorReportDetailes md = new MadorReportDetailes();
            md.Show();
            Hide();

        }

        private void LogisticalPIC_Click(object sender, EventArgs e)
        {
            typeOfReport = "logistical_problem";
            MadorReportDetailes md = new MadorReportDetailes();
            md.Show();
            Hide();


        }

        private void proctorPIC_Click(object sender, EventArgs e)
        {
            typeOfReport = "other";
            MadorReportDetailes md = new MadorReportDetailes();
            md.Show();
            Hide();


        }
    }
}
