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
using System.IO;


namespace EasyTest_App
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }
        Boolean TimerClick = false;
        private void ReportForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT student_id FROM examination_log WHERE table_num = @table_num";

            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@table_num", Main_Screen.send2profile);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string result = dt.Rows[0].ItemArray[0].ToString();

            string query2 = "SELECT * FROM student WHERE student_id = @result";

            MySqlCommand cmd2 = new MySqlCommand(query2, conn);
            cmd2.Parameters.AddWithValue("@result", result);

            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            //conn.Close();
            String selectQuery = "SELECT image FROM student WHERE student_id = '" + dt2.Rows[0].ItemArray[0].ToString() + "'";

            MySqlCommand command;
            MySqlDataAdapter da3;

            command = new MySqlCommand(selectQuery, conn);

            da3 = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da3.Fill(table);

            byte[] img = (byte[])table.Rows[0][0];

            MemoryStream ms = new MemoryStream(img);

            pictureBox.Image = Image.FromStream(ms);

            da3.Dispose();
            conn.Close();


            FullNamAnsLABEL.Text = dt2.Rows[0].ItemArray[1].ToString() + " " + dt2.Rows[0].ItemArray[2].ToString();
            IDAnsLABEL.Text = dt2.Rows[0].ItemArray[0].ToString();
            tableBTN.Text = Main_Screen.send2profile;


        }

        private void toilet_CheckedChanged(object sender, EventArgs e)
        {
            if (toilet.Checked == true)
            {
                ContentNote.Visible = false;
                comboBox.Visible = false;
                TimerBTN.Visible = true;
                ReturnBTN2.Visible = true;
                ExitTimeLBL2.Visible = true;

            }
        }

        private void note_CheckedChanged(object sender, EventArgs e)
        {
            if (note.Checked == true)
            {
                TimerBTN.Visible = false;
                ReturnBTN2.Visible = false;
                ExitTimeLBL2.Visible = false;
                ContentNote.Visible = true;
                comboBox.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*if (note.Checked)
            {
                string query = "INSERT INTO `examination_log` (`exam_id`, `student_id`," +
                " `lecturer_id`, `proctor_id`, `report_id`, `course_id`, `class_num`," +
                " `notebook_num`, `table_num`, `start_time`, `end_time`," +
                " `extra_time`) VALUES (@exam_id, @student_id, @lecturer_id, @proctor_id, ''," +
                " @course_id, @class_num, @notebook_num, @table_num, '', '', '')";

                MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@exam_id", Login.exam_table.Rows[0].ItemArray[0].ToString());
                cmd.Parameters.AddWithValue("@student_id", Add_Student.StudentID);
                cmd.Parameters.AddWithValue("@lecturer_id", Login.exam_table.Rows[0].ItemArray[2].ToString());
                cmd.Parameters.AddWithValue("@proctor_id", Login.exam_table.Rows[0].ItemArray[1].ToString());
                cmd.Parameters.AddWithValue("@course_id", Login.exam_table.Rows[0].ItemArray[3].ToString());
                cmd.Parameters.AddWithValue("@class_num", Login.exam_table.Rows[0].ItemArray[4].ToString());
                cmd.Parameters.AddWithValue("@notebook_num", NoteBook_Num.notebookNum);
                cmd.Parameters.AddWithValue("@table_num", lastBTN);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            if(toilet.Checked)
            {

            }*/

        }

        private void TimerBTN_Click(object sender, EventArgs e)
        {
            note.Visible = false;
            DateTime now = DateTime.Now;
            if (!TimerClick)
            {
                if (now.Minute < 10)
                {
                    ExitTimeLBL.Text = now.Hour.ToString() + ":0" + now.Minute.ToString();
                }
                else if(now.Hour<10)
                {
                    ExitTimeLBL.Text = "0" + now.Hour.ToString() + ":" + now.Minute.ToString();
                }
                else if(now.Hour<10 && now.Minute < 10)
                {
                    ExitTimeLBL.Text = "0" + now.Hour.ToString() + ":0" + now.Minute.ToString();
                }
                else if(now.Minute == 0)
                {
                    ExitTimeLBL.Text = now.Hour.ToString() + ":00";
                }
                else if (now.Minute == 0)
                {
                    ExitTimeLBL.Text = now.Hour.ToString() + ":00";
                }
                else if(now.Hour == 0)
                {
                    ExitTimeLBL.Text = "00" + now.Hour.ToString() + ":" + now.Minute.ToString();
                }
                else if(now.Hour==0 && now.Minute == 0)
                {
                    ExitTimeLBL.Text = "00" + now.Hour.ToString() + ":00" + now.Minute.ToString();

                }
                else
                {
                    ExitTimeLBL.Text = now.Hour.ToString() + ":" + now.Minute.ToString();

                }
                ExitTimeLBL.Visible = true;
                TimerBTN.Text = "סיים טיימר";
            }           
            if(TimerClick)
            {
                if (now.Minute < 10)
                {
                    ReturnBTN.Text = now.Hour.ToString() + ":0" + now.Minute.ToString();
                }
                else if (now.Hour < 10)
                {
                    ReturnBTN.Text = "0" + now.Hour.ToString() + ":" + now.Minute.ToString();
                }
                else if (now.Hour < 10 && now.Minute < 10)
                {
                    ReturnBTN.Text = "0" + now.Hour.ToString() + ":0" + now.Minute.ToString();
                }
                else if (now.Minute == 0)
                {
                    ReturnBTN.Text = now.Hour.ToString() + ":00";
                }
                else if (now.Minute == 0)
                {
                    ReturnBTN.Text = now.Hour.ToString() + ":00";
                }
                else if (now.Hour == 0)
                {
                    ReturnBTN.Text = "00" + now.Hour.ToString() + ":" + now.Minute.ToString();
                }
                else if (now.Hour == 0 && now.Minute == 0)
                {
                    ReturnBTN.Text = "00" + now.Hour.ToString() + ":00" + now.Minute.ToString();

                }
                else
                {
                    ReturnBTN.Text = now.Hour.ToString() + ":" + now.Minute.ToString();

                }
                ReturnBTN.Visible = true;
                TimerBTN.Text = "התחל טיימר";
            }
            TimerClick = true;
        }
        
    }
}
