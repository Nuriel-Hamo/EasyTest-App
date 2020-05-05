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
    public partial class Add_Student : Form
    {
        public static string SetValue = "";

        public Add_Student()
        {
            InitializeComponent();

        }
        public static Boolean ClickTextBox = false;
        public static string idForInfo;
        public static string nameForInfo;
        public static string emailForInfo;
        public static string phoneForInfo;


        private void InsertStudentBTN_Click(object sender, EventArgs e)
        {


            if (StudentID_textbox.Text.Trim() == "")
            {
                MessageBox.Show("יש להזין תוכן", "הודעה");
            }
            else
            {
                string AllowedQuery = "SELECT * FROM student WHERE student_id = @StudentID_textbox AND allowed = 1";
                MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(AllowedQuery, conn);
                cmd.Parameters.AddWithValue("@StudentID_textbox", StudentID_textbox.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();


                if (dt.Rows.Count > 0)
                {
                    nameForInfo = rdr.GetString(1) + " " + rdr.GetString(2);
                    idForInfo = rdr.GetString(0);
                    emailForInfo = rdr.GetString(3);
                    phoneForInfo = rdr.GetString(4);

                    conn.Close();
                    Student_Information si = new Student_Information();
                    si.Show();
                    Hide();


                }
                else
                {
                    MessageBox.Show(" הסטודנט אינו רשאי להבחן", "הודעה");
                }
                ClickTextBox = false;
                StudentID_textbox.Text = "הכנס ת.ז";

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
