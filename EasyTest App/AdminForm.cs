using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;
using TableDependency.SqlClient;
using System.Data.SqlClient;
using TableDependency.SqlClient.Base.EventArgs;
using EasyTest_App.DB;

namespace EasyTest_App
{
    
    public partial class AdminForm : Form
    {
        //private static string string_con = "server=localhost;user id=root;database=easytest";
        string connectionString = "server=localhost;user id=root;database=easytest";
        public static string send;
        public static string for_label;
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=easytest");
        public static AdminSearchForm admSearch = new AdminSearchForm();
        public AdminForm()
        {
            InitializeComponent();

        }

        /*public void EventListner() {
            DBManager.DBEvent += ReportNotification;
        }*/
        public void ReportNotification()
        {
            reportAlertLBL.Text = "קיימות תקלות פתוחות במערכת";
            reportAlertLBL.Visible = true;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text.Equals("הוספת בחינה חדשה"))
            {
                AdminNewExamForm admN = new AdminNewExamForm();
                admN.Show();
                Hide();
            }
            if(button1.Text.Equals("הוספת משגיח בחינה"))
            {
                AddProctorForm addProctor = new AddProctorForm();
                Hide();
                addProctor.Show();
            }
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ButtonSearchExam_Click(object sender, EventArgs e)
        {
            if(buttonSearchExam.Text.Equals("מחק בחינה"))
            {
                send = "exam";
                AdminFormExamDeletion ad = new AdminFormExamDeletion();
                Hide();
                ad.Show();
            }
            if(buttonSearchExam.Text.Equals("מחיקת משגיח בחינה"))
            {
                send = "proctor";
                AdminFormExamDeletion ad = new AdminFormExamDeletion();
                Hide();
                ad.Show();
            }
        }

        private void ButtonAddProctor_Click(object sender, EventArgs e)
        {
            if(buttonAddProctor.Text.Equals("עדכן בחינה קיימת"))
            {
                send = "exam";
                for_label = ":אנא הזן את מספר הבחינה שברצונך לעדכן";
                AdminUpdateForm updateForm = new AdminUpdateForm();
                updateForm.Show();
                

            }
            if(buttonAddProctor.Text.Equals("עדכן משגיח בחינה קיים"))
            {
                send = "proctor";
                for_label = ":אנא הזן מספר ת.ז של משגיח הבחינה שברצונך לעדכן";
                AdminUpdateForm updateForm = new AdminUpdateForm();
                updateForm.Show();
            }
        }

        private void ToolStripMenuItemExamManage_Click(object sender, EventArgs e)
        {
            button1.Text = "הוספת בחינה חדשה";
            buttonAddProctor.Text = "עדכן בחינה קיימת";
            buttonSearchExam.Text = "מחק בחינה";
        }

        private void ToolStripMenuItemProctorManage_Click(object sender, EventArgs e)
        {
            button1.Text = "הוספת משגיח בחינה";
            buttonAddProctor.Text = "עדכן משגיח בחינה קיים";
            buttonSearchExam.Text = "מחיקת משגיח בחינה";
        }

        private void ToolStripMenuItemSearch_Click(object sender, EventArgs e)
        {
            Hide();
            admSearch.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            DBManager.DBEvent += ReportNotification;

            string Query1 = "SELECT * FROM exam_report WHERE status = '0' OR status = '1'";
            con.Open();
            MySqlCommand cmd1 = new MySqlCommand(Query1, con);
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            con.Close();
            if (dt1.Rows.Count > 0)
            {
                reportAlertLBL.Text = "קיימות תקלות פתוחות במערכת";
                reportAlertLBL.Visible = true;
            }



            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            menuStrip1.BackColor = Color.FromArgb(100, 0, 0, 0);
            string a = Login.admin_id.ToString();
            con.Open();
            string Query = "SELECT `first_name` FROM `proctor` WHERE `proctor`.`proctor_id`=@admin";
            MySqlCommand cmd = new MySqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@admin",a );
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
              label1.Text = "שלום "+dr["first_name"].ToString();
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            Login.startProgram = false;
            login.Show();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SqlDependency.Stop(connectionString);
        }

        private void reportAlertLBL_Click(object sender, EventArgs e)
        {
            ReportManagerForm rmf = new ReportManagerForm();
            rmf.Show();
            Hide();
        }

        private void EventM_Click(object sender, EventArgs e)
        {
            ReportManagerForm rmf = new ReportManagerForm();
            rmf.Show();
            Hide();
        }
    }
}
