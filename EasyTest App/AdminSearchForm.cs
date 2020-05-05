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

namespace EasyTest_App
{
    public partial class AdminSearchForm : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=easytest");
        public AdminSearchForm()
        {
            InitializeComponent();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if(CanSearch())
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"SELECT * FROM course";
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    listBoxResult.Items.Add(dr["course_id"].ToString() + " " + dr["course_name"].ToString());
                }
                con.Close();
            }

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            AdminForm admin = new AdminForm();
            Hide();
            admin.Show();
        }
        private Boolean CanSearch()
        {
            if (textBoxCourse.Enabled == true && textBoxCourse.Text == "")
                MessageBox.Show("אנא הזן ערך בכדי להמשיך או לחצי חזור לתפריט הראשי");
            else if (textBoxExam.Enabled == true && textBoxExam.Text == "")
                MessageBox.Show("אנא הזן ערך בכדי להמשיך או לחצי חזור לתפריט הראשי");
            else if (textBoxBookID.Enabled == true && textBoxBookID.Text == "")
                MessageBox.Show("אנא הזן ערך בכדי להמשיך או לחצי חזור לתפריט הראשי");
            else 
                return false;
            return true;
        }

        private void AdminSearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
