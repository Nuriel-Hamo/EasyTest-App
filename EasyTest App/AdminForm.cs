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

namespace EasyTest_App
{
    
    public partial class AdminForm : Form
    {
        public static string send;
        public static string for_label;
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=easytest");
        public static AdminSearchForm admSearch = new AdminSearchForm();
        public AdminForm()
        {
            InitializeComponent();
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
    }
}
