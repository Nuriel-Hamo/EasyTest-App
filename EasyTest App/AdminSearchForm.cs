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
        public static string send,result,tbox;
        
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=easytest");
        
        public AdminSearchForm()
        {
            InitializeComponent();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Clear();
            if (CanSearch())
            {
                if (radioButtonCourse.Checked)
                {
                    tbox = textBoxCourse.Text;
                    Course();
                }
                else if (radioButtonExam.Checked)
                {
                    tbox = textBoxExam.Text;
                    Exam();
                }
                else if (radioButtonBookID.Checked)
                {
                    tbox = textBoxBookID.Text;
                    BookID();
                }


            }

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Hide();
            Login.adminF.Show();
        }
        private Boolean CanSearch()
        {

            if (textBoxCourse.Enabled == true && textBoxCourse.Text == "")
            {
                MessageBox.Show("אנא הזן ערך בכדי להמשיך או לחץ חזור לתפריט הראשי");
                return false;
            }
            else if (textBoxExam.Enabled == true && textBoxExam.Text == "")
            {
                MessageBox.Show("אנא הזן ערך בכדי להמשיך או לחץ חזור לתפריט הראשי");
                return false;
            }
            else if (textBoxBookID.Enabled == true && textBoxBookID.Text == "")
            {
                MessageBox.Show("אנא הזן ערך בכדי להמשיך או לחץ חזור לתפריט הראשי");
                return false;
            }

                return true;
        }

        private void AdminSearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void RadioButtonExam_CheckedChanged(object sender, EventArgs e)
        {
            ResetTBoxs();
            listBoxResult.Items.Clear();
            textBoxBookID.Enabled = false;
            textBoxCourse.Enabled = false;
            textBoxExam.Enabled = true;
        }

        private void RadioButtonCourse_CheckedChanged(object sender, EventArgs e)
        {
            ResetTBoxs();
            listBoxResult.Items.Clear();
            textBoxBookID.Enabled = false;
            textBoxCourse.Enabled = true;
            textBoxExam.Enabled = false;
        }

        private void RadioButtonBookID_CheckedChanged(object sender, EventArgs e)
        {
            ResetTBoxs();
            listBoxResult.Items.Clear();
            textBoxBookID.Enabled = true;
            textBoxCourse.Enabled = false;
            textBoxExam.Enabled = false;
        }

        private void Course()
        {
            send = "course";
            con.Open();
            string Query = "SELECT * FROM examination_log WHERE course_id = @textBoxCourse";
            MySqlCommand cmd = new MySqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@textBoxCourse", textBoxCourse.Text);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);
            if (dt.Rows.Count == 0)
                MessageBox.Show("קורס מספר " + textBoxCourse.Text + "אינו קיים ", "שגיאה");
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    listBoxResult.Items.Add("ת.ז סטודנט: " + dr["student_id"].ToString() + " מספר מחברת:" + dr["notebook_num"].ToString() + " מספר שולחן: " + dr["table_num"].ToString());
                }
            }

            con.Close();
        }
        private void Exam()
        {
            send = "exam";
            con.Open();
            string Query = "SELECT * FROM examination_log WHERE exam_id = @textBoxExam";
            MySqlCommand cmd = new MySqlCommand(Query, con);

            cmd.Parameters.AddWithValue("@textBoxExam", textBoxExam.Text);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);
            if (dt.Rows.Count == 0)
                MessageBox.Show("מבחן מספר " + textBoxExam.Text + "אינו קיים ", "שגיאה");
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    listBoxResult.Items.Add("ת.ז סטודנט: " + dr["student_id"].ToString() + " מספר מחברת:" + dr["notebook_num"].ToString() + " מספר שולחן: " + dr["table_num"].ToString());
                }
            }

            con.Close();
        }
        private void BookID()
        {
            send = "book_id";
            con.Open();
            string Query = "SELECT * FROM examination_log WHERE notebook_num = @textBoxBookID";
            MySqlCommand cmd = new MySqlCommand(Query, con);

            cmd.Parameters.AddWithValue("@textBoxBookID", textBoxBookID.Text);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);
            if (dt.Rows.Count == 0)
                MessageBox.Show("מחברת מספר " + textBoxBookID.Text + "אינה קיימת ", "שגיאה");
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    listBoxResult.Items.Add("ת.ז סטודנט: " + dr["student_id"].ToString() + " מספר מחברת:" + dr["notebook_num"].ToString() + " מספר שולחן: " + dr["table_num"].ToString());
                }
            }

            con.Close();
        }
        private void ResetTBoxs()
        {
            textBoxBookID.Text = "";
            textBoxCourse.Text = "";
            textBoxExam.Text = "";
        }

        private void ListBoxResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxResult.GetItemText(listBoxResult.SelectedItem)!=null)
            {
                result = listBoxResult.GetItemText(listBoxResult.SelectedItem);
                AdminSearchDetailsInformatio info = new AdminSearchDetailsInformatio();
                Hide();
                info.Show();
            }
            else
                ;
        }
    }
}
