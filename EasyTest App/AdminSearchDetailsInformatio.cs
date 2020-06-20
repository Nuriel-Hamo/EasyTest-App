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
    public partial class AdminSearchDetailsInformatio : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=easytest");
        string[] str = AdminSearchForm.result.Split(':');
        public AdminSearchDetailsInformatio()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Hide();
            AdminForm.admSearch.Show();
        }

        private void AdminSearchDetailsInformatio_Load(object sender, EventArgs e)
        {
            /*label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            label6.BackColor = Color.FromArgb(0, 0, 0, 0);
            label7.BackColor = Color.FromArgb(0, 0, 0, 0);
            label8.BackColor = Color.FromArgb(0, 0, 0, 0);
            label9.BackColor = Color.FromArgb(0, 0, 0, 0);
            label_additionalD.BackColor = Color.FromArgb(100, 0, 0, 0);
            label_course.BackColor = Color.FromArgb(100, 0, 0, 0);
            label_end.BackColor = Color.FromArgb(100, 0, 0, 0);
            label_exam_id.BackColor = Color.FromArgb(100, 0, 0, 0);
            label_lecturer_name.BackColor = Color.FromArgb(100, 0, 0, 0);
            label_proctor_name.BackColor = Color.FromArgb(100, 0, 0, 0);
            label_start.BackColor = Color.FromArgb(100, 0, 0, 0); 
            buttonBack.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);*/

            con.Open();
           
            string Query = "SELECT * FROM examination_log WHERE student_id = @value";
            MySqlCommand cmd = new MySqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@value",str[1].Substring(1,10).Trim());
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                label1.Text = dr["exam_id"].ToString();
                label3.Text = getLecturer(dr["lecturer_id"].ToString());
                label4.Text = getProctor(dr["proctor_id"].ToString());
                label5.Text = getCourse(dr["course_id"].ToString());
                label6.Text = dr["start_time"].ToString().Substring(0,5);
                label7.Text = dr["end_time"].ToString().Substring(0, 5);
                label8.Text = getStudent(dr["student_id"].ToString());
            }
            con.Close();
            

        }
        private string getLecturer(string s)
        {
            MySqlConnection con2 = new MySqlConnection("server=localhost;user id=root;database=easytest");
            con2.Open();
            string Query = "SELECT * FROM lecturer WHERE lecturer_id = @value";
            MySqlCommand cmd = new MySqlCommand(Query, con2);
            cmd.Parameters.AddWithValue("@value", s);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["lecturer_id"].ToString() == s)
                    con.Close();
                    return dr["first_name"].ToString() +" " + dr["last_name"].ToString();
            }
            con.Close();
            return "";
        }
        private string getProctor(string s)
        {
            MySqlConnection con2 = new MySqlConnection("server=localhost;user id=root;database=easytest");
            con2.Open();
            string Query = "SELECT * FROM proctor WHERE proctor_id = @value";
            MySqlCommand cmd = new MySqlCommand(Query, con2);
            cmd.Parameters.AddWithValue("@value", s);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["proctor_id"].ToString() == s)
                    con.Close();
                return dr["first_name"].ToString() + " " + dr["last_name"].ToString();
            }
            con.Close();
            return "";
        }
        private string getCourse(string s)
        {
            MySqlConnection con2 = new MySqlConnection("server=localhost;user id=root;database=easytest");
            con2.Open();
            string Query = "SELECT * FROM course WHERE course_id = @value";
            MySqlCommand cmd = new MySqlCommand(Query, con2);
            cmd.Parameters.AddWithValue("@value", s);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["course_id"].ToString() == s)
                    con.Close();
                return dr["course_name"].ToString();
            }
            con.Close();
            return "";
        }
        private string getStudent(string s)
        {
            MySqlConnection con2 = new MySqlConnection("server=localhost;user id=root;database=easytest");
            con2.Open();
            string Query = "SELECT * FROM student WHERE student_id = @value";
            MySqlCommand cmd = new MySqlCommand(Query, con2);
            cmd.Parameters.AddWithValue("@value", s);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["student_id"].ToString() == s)
                    con.Close();
                return dr["first_name"].ToString() + " " + dr["last_name"].ToString();
            }
            con.Close();
            return "";
        }
        private void AdminSearchDetailsInformatio_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

     
    }
}
