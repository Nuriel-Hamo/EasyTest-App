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
        string [] current = new string [5];
        string [] data=new string[8];
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=easytest");
        Regex rx = new Regex("^(0[8-9]|1[0-9]|2[0-2]):[0-5][0-9]$");
        //Regex rx = new Regex("^(0?[1-9]|1[0-2]):[0-5][0-9]d$");


        public AdminNewExamForm()
        {
            
            InitializeComponent();
        }

        private void TextBoxCourseCode_TextChanged(object sender, EventArgs e)
        {
            if (current[0] == null)
                ;
            else if (textBoxCourseCode.Text.Length - current[0].Length < 0)
                textBoxCourseCode.Text = "";
            else if (listBox1.SelectedItem == null && textBoxCourseCode.Text.Substring(0, 4) != current[0])
                textBoxCourseCode.Text = current[0];
            if (notEmpty())
                button_confirm.Enabled = true;
        }
        private Boolean notEmpty()
        {
            if (textBox_proctorID.Text != "" && textBox_lecturerID.Text != "" && textBox_exam_date.Text != "" && textBox_start_hour.Text != "" && textBox_end_hour.Text != "" && comboBoxMoed.SelectedItem != null)
            {
                    return true;
            }
            
            return false;

        }

        private void TextBox_proctorID_TextChanged(object sender, EventArgs e)
        {

            if (current[1] == null)
                ;
            else if (textBox_proctorID.Text.Length - current[1].Length < 0)
                textBox_proctorID.Text = "";
            else if (listBox1.SelectedItem == null && textBox_proctorID.Text.Substring(0, 8) != current[1])
                textBox_proctorID.Text = current[1];
            if (notEmpty())
                button_confirm.Enabled = true;
            
        }

        private void TextBox_lecturerID_TextChanged(object sender, EventArgs e)
        {

            if (current[2] == null)
                ;
            else if (textBox_lecturerID.Text.Length - current[2].Length < 0)
                textBox_lecturerID.Text = "";
            else if (listBox1.SelectedItem == null && textBox_lecturerID.Text.Substring(0, 8) != current[2])
                textBox_lecturerID.Text = current[1];
            if (notEmpty())
                button_confirm.Enabled = true;
        }

        private void TextBox_exam_date_TextChanged(object sender, EventArgs e)
        {
            
            //if (textBox_exam_date.Text != "" && !textBox_exam_date.Text.Equals(calendar.SelectionRange.Start.ToShortDateString()))
             //   textBox_exam_date.Text = "";
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
            comboBoxMoed.Text = "";
        }

        private void Button_confirm_Click(object sender, EventArgs e)
        {
            errorProviderExam.Clear();
            if (button_confirm.Text == "אשר")
            {
                if (ExamValidtion())
                {

                    string addExamQuery = "INSERT INTO `exam` (`proctor_id`, `lecturer_id`, `course_id`, `class_num`, `test_date`, `start_time`, `end_time`, `exam_period`) VALUES (@textBox_proctorID, @textBox_lecturerID, @textBoxCourseCode, @textBox_class_number,@textBox_exam_date, @textBox_start_hour, @textBox_end_hour,@comboBoxMoed)";
                    MySqlConnection con2 = new MySqlConnection("server=localhost;user id=root;database=easytest");
                    con2.Open();
                    MySqlCommand cmd = new MySqlCommand(addExamQuery, con2);



                    cmd.Parameters.AddWithValue("@textBox_proctorID", textBox_proctorID.Text);
                    cmd.Parameters.AddWithValue("@textBox_lecturerID", textBox_lecturerID.Text);
                    cmd.Parameters.AddWithValue("@textBoxCourseCode", textBoxCourseCode.Text);
                    cmd.Parameters.AddWithValue("@textBox_class_number", textBox_class_number.Text);
                    cmd.Parameters.AddWithValue("@textBox_exam_date", dateChaging(textBox_exam_date.Text));
                    cmd.Parameters.AddWithValue("@textBox_start_hour", textBox_start_hour.Text);
                    cmd.Parameters.AddWithValue("@textBox_end_hour", textBox_end_hour.Text);
                    cmd.Parameters.AddWithValue("@comboBoxMoed", WhichExamPeriodIs());
                    cmd.ExecuteNonQuery();

                    con2.Close();


                    MessageBox.Show("המבחן הוזן בהצלחה");

                    Hide();
                    AdminForm admin = new AdminForm();
                    admin.Show();
                }
            }
            if (button_confirm.Text == "עדכן")
            {
                if (somethingChanged())
                {
                    if (ExamValidtion())
                    {

                        string addExamQuery = "UPDATE `exam` SET `proctor_id` = @textBox_proctorID, `course_id` = @textBoxCourseCode, `class_num` = @textBox_class_number, `test_date` = @textBox_exam_date,`start_time` = @textBox_start_hour, `end_time` = @textBox_end_hour, `exam_period` = @comboBoxMoed WHERE `exam`.`exam_id` = @exam";
                        MySqlConnection con2 = new MySqlConnection("server=localhost;user id=root;database=easytest");
                        con2.Open();
                        MySqlCommand cmd = new MySqlCommand(addExamQuery, con2);



                        cmd.Parameters.AddWithValue("@textBox_proctorID", textBox_proctorID.Text);
                        cmd.Parameters.AddWithValue("@textBox_lecturerID", textBox_lecturerID.Text);
                        cmd.Parameters.AddWithValue("@textBoxCourseCode", textBoxCourseCode.Text);
                        cmd.Parameters.AddWithValue("@textBox_class_number", textBox_class_number.Text);
                        cmd.Parameters.AddWithValue("@textBox_exam_date", dateChaging(textBox_exam_date.Text));
                        cmd.Parameters.AddWithValue("@textBox_start_hour", textBox_start_hour.Text);
                        cmd.Parameters.AddWithValue("@textBox_end_hour", textBox_end_hour.Text);
                        cmd.Parameters.AddWithValue("@comboBoxMoed", WhichExamPeriodIs());
                        cmd.Parameters.AddWithValue("@exam", AdminUpdateForm.exam);
                        cmd.ExecuteNonQuery();

                        con2.Close();


                        MessageBox.Show("המבחן עודכן בהצלחה");

                        Hide();
                        Login.adminF.Show();
                    }

                }
                else
                    MessageBox.Show("המידע שהוזן זהה למידע הקיים");

            }

            
        }

        private void TextBox_class_number_TextChanged(object sender, EventArgs e)
        {
            if (current[3] == null)
                ;
            else if (textBox_class_number.Text.Length - current[3].Length < 0)
                textBox_class_number.Text = "";
            else if (listBox1.SelectedItem == null && textBox_class_number.Text.Substring(0, 2) != current[3])
                textBox_class_number.Text = current[3];
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
            if (listBox1.SelectedItem == null)
                ;
            else if(listBox1.Name.Equals("proctors"))
            {
                text = text.Substring(0, 9);
                textBox_proctorID.Text = text;
                current[1] = text;
            }
            else if(listBox1.Name.Equals("courses"))
            {
                text = text.Substring(0, 5);
                textBoxCourseCode.Text = text;
                current[0] = text;
            }
            else if (listBox1.Name.Equals("lecturer"))
            {
                text = text.Substring(0, 10);
                textBox_lecturerID.Text = text;
                current[2] = text;
            }
            else if (listBox1.Name.Equals("mapping"))
            {
                text = text.Substring(0, 3);
                textBox_class_number.Text = text;
                current[3] = text;
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
            {
                textBox_start_hour.Focus();
                MessageBox.Show("HH:MM אנא להזין שעת התחלה בפורמט");
            }
            if (notEmpty())
                button_confirm.Enabled = true;
            

           // if (textBox_start_hour.Text == "")
             //   ;
            
                
            
        }

        private void TextBox_end_hour_Leave(object sender, EventArgs e)
        {

            if (!rx.IsMatch(textBox_end_hour.Text))
            {
                textBox_end_hour.Focus();
                MessageBox.Show(" HH:MM אנא להזין שעת התחלה בפורמט");

            }
            else
            {
                bool isOK = HourValidiation();
                if (notEmpty() && isOK)
                    button_confirm.Enabled = true;
            }
            //if (textBox_end_hour.Text == "")
            // ;





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
            //
            calendar.Visible = false;
            listBox1.Items.Clear();
        }
        private string WhichExamPeriodIs()
        {
            if (comboBoxMoed.SelectedItem.Equals("מועד א"))
                return "0";
            else if (comboBoxMoed.SelectedItem.Equals("מועד ב"))
                return "1";

            return "2";
        }
        private bool HourValidiation()
        {

            string s = textBox_start_hour.Text.Substring(0, 2), e = textBox_end_hour.Text.Substring(0, 2);

            int start = 0, end = 0;
            start = Convert.ToInt32(s);
            end = Convert.ToInt32(e);

            if (start >= end)
            {
                MessageBox.Show("שעת סיום לא יכולה להיות קטנה/שווה לשעת ההתחלה", "שגיאת הקלדה");
                textBox_end_hour.Focus();
                return false;
            }
            else if (end - start < 2)
            {
                MessageBox.Show("זמן מינימלי למבחן הוא שעתיים ומעלה", "שגיאת הקלדה");
                textBox_end_hour.Focus();
                return false;
            }
            else if (end - start > 3)
            {
                MessageBox.Show("זמן המבחן שהוקלד גבוה מדי אנא הזן שנית", "שגיאת הקלדה");
                return false;
            }
            return true;
        }

        private void comboBoxMoed_Leave(object sender, EventArgs e)
        {
            if (notEmpty())
                button_confirm.Enabled = true;
        }
        private bool ExamValidtion()
        {
            
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT proctor_id,course_id,class_num,test_date,exam_period FROM exam";
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);
            string[] date = textBox_exam_date.Text.Split('/');
            int year = Convert.ToInt32(date[2]),month= Convert.ToInt32(date[1]),day= Convert.ToInt32(date[0]);
            string[] comboIndex = comboBoxMoed.SelectedIndex.ToString().Split('/');
            // check the date 
            if (year <= DateTime.Today.Year)

                if (month <= DateTime.Today.Month)
                    if (day <= DateTime.Today.Day)
                    {
                        errorProviderExam.SetError(textBox_exam_date, "אנא בחר תאריך בעתיד");
                        con.Close();
                        return false;
                    }

            
            
            foreach (DataRow dr in dt.Rows)
            {
                //check if have exam in that date for the choosen course
                if (dr["test_date"].ToString().Substring(0, 10).Equals(textBox_exam_date.Text) && dr["course_id"].ToString().Equals(textBoxCourseCode.Text)&& !textBoxCourseCode.Text.Equals(data[2]))
                {
                    errorProviderExam.SetError(textBoxCourseCode, "בקורס זה קיים מבחן בתאריך זה");
                    con.Close();
                    return false;
                }
                //check if for proctor have exam in that day

                if (dr["proctor_id"].ToString().Equals(textBox_proctorID.Text) && dr["test_date"].ToString().Substring(0, 10).Equals(textBox_exam_date.Text) && !textBox_proctorID.Text.Equals(data[0]))
                
                {
                   
                    errorProviderExam.SetError(textBox_proctorID, "למשגיח זה קיימת בחינה באותו יום אנא בחר משגיח/ה אחר/ת");
                    con.Close();
                    return false;
                }

                //check the course & period
                string s = dr["exam_period"].ToString();

               if (dr["course_id"].ToString().Equals(textBoxCourseCode.Text) && dr["exam_period"].ToString().Equals(WhichExamPeriodIs())&& !textBoxCourseCode.Text.Equals(data[2]))
               {
                   errorProviderExam.SetError(textBoxCourseCode, "בקורס זה כבר יש " + comboBoxMoed.SelectedItem.ToString());
                    con.Close();
                    return false;
               }
               //check class num & date
                if(dr["test_date"].ToString().Substring(0, 10).Equals(textBox_exam_date.Text) && dr["class_num"].ToString().Equals(textBox_class_number.Text)&& !textBox_class_number.Text.Equals(data[3]))
                {
                    errorProviderExam.SetError(textBox_class_number, "כיתה " + textBox_class_number.Text+ " כבר תפוסה אנא בחר כיתה אחרת");
                    con.Close();
                    return false;
                }
            }

            con.Close();


            return true;
            
        }

        private void AdminNewExamForm_Load(object sender, EventArgs e)
        {
            if(AdminUpdateForm.needUpd)
            {
                label1.Text = "עדכון בחינה";
                button_confirm.Text = "עדכן";
                foreach(DataRow dr in AdminUpdateForm.UpdtadeDataTable.Rows)
                {
                    textBox_proctorID.Text = dr["proctor_id"].ToString();
                    textBox_lecturerID.Text = dr["lecturer_id"].ToString();
                    textBoxCourseCode.Text = dr["course_id"].ToString();
                    textBox_class_number.Text = dr["class_num"].ToString();
                    textBox_exam_date.Text = dr["test_date"].ToString().Substring(0,10);
                    textBox_start_hour.Text = dr["start_time"].ToString().Substring(0, 5);
                    textBox_end_hour.Text = dr["end_time"].ToString().Substring(0, 5);
                    comboBoxMoed.Text = ChangeMoed(dr["exam_period"].ToString());
                }
                AdminUpdateForm.needUpd = false;
                InsertData();


            }
        }
        private string ChangeMoed(string s)
        {
            if (s == "0")
                return "מועד א";
            if (s == "1")
                return "מועד ב";
            return "מועד מיוחד";
        }
        private void InsertData()
        {
            foreach (DataRow dr in AdminUpdateForm.UpdtadeDataTable.Rows)
            {
                data[0] = dr["proctor_id"].ToString();
                data[1] = dr["lecturer_id"].ToString();
                data[2] = dr["course_id"].ToString();
                data[3] = dr["class_num"].ToString();
                data[4] = dr["test_date"].ToString().Substring(0, 10);
                data[5] = dr["start_time"].ToString().Substring(0, 5);
                data[6] = dr["end_time"].ToString().Substring(0, 5);
                data[7] = ChangeMoed(dr["exam_period"].ToString());
            }

        }
        private bool somethingChanged()
        {
            if (textBox_proctorID.Text.Equals(data[0]) && textBox_lecturerID.Text.Equals(data[1]) && textBoxCourseCode.Text.Equals(data[2]) && textBox_class_number.Text.Equals(data[3]) && textBox_exam_date.Text.Equals(data[4]) && textBox_start_hour.Text.Equals(data[5]) && textBox_end_hour.Text.Equals(data[6]) && comboBoxMoed.Text.Equals(data[7]))
                return false;
            return true;
        }
    }
}



