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
using System.Text.RegularExpressions;
namespace EasyTest_App
{
    public partial class AdminNewExamForm : Form
    {
        
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=easytest");
        Regex rx = new Regex("^([0-1]?[0-9]|2[0-3]):[0-5][0-9]$");
        int examID = 1;
        
        public AdminNewExamForm()
        {
            
            InitializeComponent();
        }

        private void TextBoxCourseCode_TextChanged(object sender, EventArgs e)
        {
            if (listBox1.GetItemText(listBox1.SelectedItem).Equals(""))
                textBoxCourseCode.Text = "";
            if (notEmpty())
                button_confirm.Enabled = true;
        }
        private Boolean notEmpty()
        {
            if (textBox_proctorID.Text != "" && textBox_lecturerID.Text != "" && textBox_exam_date.Text != "" && textBox_start_hour.Text != "" && textBox_end_hour.Text != "")
                return true;
            else
                return false;
        }

        private void TextBox_proctorID_TextChanged(object sender, EventArgs e)
        {
            if (listBox1.GetItemText(listBox1.SelectedItem).Equals(""))
                textBox_proctorID.Text = "";
            if (notEmpty())
                button_confirm.Enabled = true;
            
        }

        private void TextBox_lecturerID_TextChanged(object sender, EventArgs e)
        {
            if (listBox1.GetItemText(listBox1.SelectedItem).Equals(""))
                textBox_lecturerID.Text = "";
            if (notEmpty())
                button_confirm.Enabled = true;
        }

        private void TextBox_exam_date_TextChanged(object sender, EventArgs e)
        {
            if (textBox_exam_date.Text == "")
                button_confirm.Enabled = false;
            if (textBox_exam_date.Text != "" && !textBox_exam_date.Text.Equals(calendar.SelectionRange.Start.ToShortDateString()))
                textBox_exam_date.Text = "";
            if (notEmpty())
                button_confirm.Enabled = true;
        }

        private void TextBox_start_hour_TextChanged(object sender, EventArgs e)
        {
            if (textBox_start_hour.Text == "")
                button_confirm.Enabled = false;
            if (notEmpty())
                button_confirm.Enabled = true;

        }

        private void TextBox_end_hour_TextChanged(object sender, EventArgs e)
        {
            if (textBox_end_hour.Text == "")
                button_confirm.Enabled = false;
            if (notEmpty())
                button_confirm.Enabled = true;
        }

        private void Button_back_Click(object sender, EventArgs e)
        {
           
            Hide();
            Login.adminF.Show();            
        }

        private void Button_reset_Click(object sender, EventArgs e)
        {
            textBoxCourseCode.Text = "";
            textBox_proctorID.Text = "";
            textBox_lecturerID.Text = "";
            textBox_exam_date.Text = "";
            textBox_start_hour.Text = "";
            textBox_end_hour.Text = "";
            textBox_class_number.Text = "";
        }

        private void Button_confirm_Click(object sender, EventArgs e)
        {

            string addExamQuery = "INSERT INTO `exam` (`proctor_id`, `lecturer_id`, `course_id`, `class_num`, `test_date`, `start_time`, `end_time`) VALUES (@textBox_proctorID, @textBox_lecturerID, @textBoxCourseCode, @textBox_class_number,@textBox_exam_date, @textBox_start_hour, @textBox_end_hour)";
            //string addExamQuery = "INSERT INTO `exam` (`exam_id`, `proctor_id`, `lecturer_id`, `course_id`, `class_num`, `test_date`, `start_time`, `end_time`) VALUES ('1', '311329221', '123456789', '14521', '416', '2020-05-21', '15:00:00', '18:00:00');";
            MySqlConnection con2 = new MySqlConnection("server=localhost;user id=root;database=easytest");
            con2.Open();
            MySqlCommand cmd = new MySqlCommand(addExamQuery, con2);
            
            //cmd.Parameters.AddWithValue("@examID",examID);
            
            cmd.Parameters.AddWithValue("@textBox_proctorID", textBox_proctorID.Text);
            cmd.Parameters.AddWithValue("@textBox_lecturerID", textBox_lecturerID.Text);
            cmd.Parameters.AddWithValue("@textBoxCourseCode", textBoxCourseCode.Text);
            cmd.Parameters.AddWithValue("@textBox_class_number", textBox_class_number.Text);
            cmd.Parameters.AddWithValue("@textBox_exam_date", dateChaging(textBox_exam_date.Text));
            cmd.Parameters.AddWithValue("@textBox_start_hour", textBox_start_hour.Text);
            cmd.Parameters.AddWithValue("@textBox_end_hour", textBox_end_hour.Text);

            cmd.ExecuteNonQuery();

            con2.Close();
            //examID++;
            
            MessageBox.Show("המבחן הוזן בהצלחה");

            Hide();
            AdminForm admin = new AdminForm();
            admin.Show();
            
        }

        private void TextBox_class_number_TextChanged(object sender, EventArgs e)
        {

            if (listBox1.GetItemText(listBox1.SelectedItem).Equals(""))
                textBox_class_number.Text = "";
            if (notEmpty())
                button_confirm.Enabled = true;
        }
        private void AdminNewExamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox_proctorID_Enter(object sender, EventArgs e)
        {
            listBox1.Name = "proctors";
            listBox1.Items.Clear();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT proctor_id,first_name,last_name FROM proctor";
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["proctor_id"].ToString() + " " + dr["first_name"].ToString() + " " + dr["last_name"].ToString());
            }
            con.Close();
        }

        private void ListBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            
            string text = listBox1.GetItemText(listBox1.SelectedItem);
            if(listBox1.Name.Equals("proctors"))
            {
                text = text.Substring(0, 10);
                textBox_proctorID.Text = text;
            }
            if(listBox1.Name.Equals("courses"))
            {
                text = text.Substring(0, 5);
                textBoxCourseCode.Text = text;
            }
            if (listBox1.Name.Equals("lecturer"))
            {
                text = text.Substring(0, 10);
                textBox_lecturerID.Text = text;
            }
            if (listBox1.Name.Equals("mapping"))
            {
                text = text.Substring(0, 3);
                textBox_class_number.Text = text;
            }

        }

        private void TextBox_proctorID_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void TextBoxCourseCode_Enter(object sender, EventArgs e)
        {
            listBox1.Name = "courses";
            listBox1.Items.Clear();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT course_id,course_name FROM course";
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["course_id"].ToString() + " " + dr["course_name"].ToString());
            }
            con.Close();
        }
        

        public class Proctor
        {
            public long Id;
            public string FName;
            public string LName;
        }


        List<Proctor> load()
        {
            List<Proctor> proctors = new List<Proctor>();

            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT proctor_id,first_name,last_name FROM proctor";

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Proctor proctor = new Proctor
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("proctor_id")),
                        FName = reader.GetString(reader.GetOrdinal("first_name")),
                        LName = reader.GetString(reader.GetOrdinal("last_name"))
                    };
                    proctors.Add(proctor);
                }

            }
            return proctors;
        }

        private void TextBox_lecturerID_Enter(object sender, EventArgs e)
        {
            listBox1.Name = "lecturer";
            listBox1.Items.Clear();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT lecturer_id,first_name,last_name FROM lecturer";
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["lecturer_id"].ToString() + " " + dr["first_name"].ToString()+ " " +dr["last_name"].ToString());
            }
            con.Close();
        }

        private void TextBox_class_number_Enter(object sender, EventArgs e)
        {
            listBox1.Name = "mapping";
            listBox1.Items.Clear();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT class_num FROM mapping";
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["class_num"].ToString());
            }
            con.Close();
        }

        private void TextBox_exam_date_Enter(object sender, EventArgs e)
        {
            calendar.Visible = true;
        }

        private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox_exam_date.Text = calendar.SelectionRange.Start.ToShortDateString();
            
        }

        private void TextBox_start_hour_Leave(object sender, EventArgs e)
        {
            if (!rx.IsMatch(textBox_start_hour.Text))
               MessageBox.Show("HH:MM אנא להזין שעת התחלה בפורמט");
        }

        private void TextBox_end_hour_Leave(object sender, EventArgs e)
        {
            if (!rx.IsMatch(textBox_end_hour.Text))
                MessageBox.Show("HH:MM אנא להזין שעת התחלה בפורמט");
        }
        private string dateChaging(string date)
        {
            
            string newdate = "";
            String[] str = date.Split('/');
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                    newdate += str[i];
                else
                    newdate += str[i] + "-";

            }
            return newdate;
        }

        private void TextBox_exam_date_Leave(object sender, EventArgs e)
        {
            calendar.Visible = false;
            listBox1.Items.Clear();
        }
    }
}



