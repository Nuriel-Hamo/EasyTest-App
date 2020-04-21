using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace EasyTest_App
{
    public partial class Add_Student : Form
    {
        public static string SetValue = "";
        
        public Add_Student()
        {
            InitializeComponent();
            
        }
        



        private void InsertStudentBTN_Click(object sender, EventArgs e)
        {
            SetValue = StudentID_textbox.Text;
            if (StudentID_textbox.Text.Trim() == "")
            {
                MessageBox.Show("יש להקיש תעודת זהות", "!שים לב");
            }
            else
            {
                string AllowedQuery = "SELECT * FROM examinee WHERE student_id = @StudentID_textbox AND allowed = 1";
                SQLiteConnection conn = new SQLiteConnection("Data Source=DB_OF_PROJECT.db;version=3;");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(AllowedQuery, conn);
                cmd.Parameters.AddWithValue("@StudentID_textbox", StudentID_textbox.Text);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
               

                if (dt.Rows.Count > 0)
                {
                    conn.Close();
                    Student_Information student_information = new Student_Information();
                    student_information.Show();
                    Hide();
                   // MessageBox.Show("!הסטודנט נרשם בהצלחה", "הודעה");


                    

                    //cmd.CommandText = @"INSERT INTO exam_log (student_id) VALUES (@studentID_textbox)";
                    //cmd.Connection = conn;
                    //  cmd.Parameters.AddWithValue("@StudentID_textbox", StudentID_textbox.Text);
                    // conn.Open();


                }
                else
                {
                    MessageBox.Show("הסטודנט אינו רשאי להבחן", "הודעה");
                }
            }
        }

        private void addBackBTN_Click(object sender, EventArgs e)
        {
            Main_Screen msc = new Main_Screen();
            msc.Show();
            Hide();
        }

        private void StudentID_textbox_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
