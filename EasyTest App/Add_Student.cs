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
    public partial class Add_Student : Form
    {
        public static string StudentID = "";


        public Add_Student()
        {
            InitializeComponent();

        }
        public static Boolean ClickTextBox = false;
        public static  DataTable student_table = new DataTable();


        private void InsertStudentBTN_Click(object sender, EventArgs e)
        {

            Regex IdReg = new Regex("[0-9]{9}");
            if (!IdReg.IsMatch(StudentID_textbox.Text))
            {
                MessageBox.Show("!יש להזין ת.ז כולל ספרת ביקורת", "הודעה");
            }
            else
            {

                string Query = "SELECT * FROM examination_log WHERE student_id = @UserID_textbox AND " +
                    "exam_id = @exam_id";
                MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(Query, conn);
                cmd.Parameters.AddWithValue("@UserID_textbox", StudentID_textbox.Text);
                cmd.Parameters.AddWithValue("@exam_id", Login.exam_table.Rows[0][0].ToString());
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("הסטודנט כבר קיים במבחן", "הודעה");
                    conn.Close();
                }
                else
                {

                    string Q = "SELECT * FROM student_courses WHERE student_id = @UserID_textbox AND " +
                    "course_id = @course_id";
                    

                    MySqlCommand cmd3 = new MySqlCommand(Q, conn);
                    cmd3.Parameters.AddWithValue("@UserID_textbox", StudentID_textbox.Text);
                    cmd3.Parameters.AddWithValue("@course_id", Login.exam_table.Rows[0][3].ToString());
                    MySqlDataAdapter dap = new MySqlDataAdapter(cmd3);
                    DataTable dta = new DataTable();
                    dap.Fill(dta);

                    if(dta.Rows.Count >0)
                    {
                        string Query1 = "SELECT * FROM student WHERE student_id = @UserID_textbox AND " +
                     "allowed = 1";


                        MySqlCommand cmd1 = new MySqlCommand(Query1, conn);
                        cmd1.Parameters.AddWithValue("@UserID_textbox", StudentID_textbox.Text);
                        MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);

                        da1.Fill(student_table);

                        // MySqlDataReader rdr = cmd.ExecuteReader();
                        // rdr.Read();


                        if (student_table.Rows.Count > 0)
                        {
                            StudentID = StudentID_textbox.Text;
                            conn.Close();
                            Student_Information si = new Student_Information();
                            si.Show();
                            Hide();

                        }
                        else
                        {
                            MessageBox.Show(" הסטודנט אינו רשאי להבחן", "הודעה");
                        }
                    }
                    else
                    {
                        MessageBox.Show("הסטודנט אינו רשום לקורס זה", "הודעה");
                    }

                   
                    

                }
                ClickTextBox = false;
                StudentID_textbox.Text = "הכנס ת.ז";


            }
        }
            private void addBackBTN_Click(object sender, EventArgs e)
            {
                
                Login.main_screen.Show();
                Hide();
            }

            private void StudentID_textbox_TextChanged(object sender, EventArgs e)
            {


            }

            private void StudentID_textbox_MouseClick(object sender, MouseEventArgs e)
            {
                if (!ClickTextBox)
                {
                    StudentID_textbox.Text = "";
                    ClickTextBox = true;
                }
            }
        
    }

}
