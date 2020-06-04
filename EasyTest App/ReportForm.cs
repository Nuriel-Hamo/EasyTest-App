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


        Boolean TimerClick = false;
        int ClickCount = 0;
        DataTable report_dt = new DataTable();
        string EndTimeQuery = "";
        public static Boolean studentInToilet = false;
        public static string studentInToiletTable = "";
        public static Boolean backFromToilet = false;


        public ReportForm()
        {
            InitializeComponent();
        }
        private void ReportForm_Load(object sender, EventArgs e)
        {
            comboBox.Text = "חשד להעתקה";

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
                if (!Main_Screen.log_table.Rows[0][12].ToString().Equals("00:00:00"))
                {
                    int startHour = Main_Screen.GetHoures(Main_Screen.log_table.Rows[0][12].ToString(), Main_Screen.getTime());
                    int startMinutes = Main_Screen.GetMinutes(Main_Screen.log_table.Rows[0][12].ToString(), Main_Screen.getTime());
                    int endtHour = Main_Screen.GetHoures(Main_Screen.getTime(), Main_Screen.ChangeEndTime());
                    int endMinutes = Main_Screen.GetMinutes(Main_Screen.getTime(), Main_Screen.ChangeEndTime());
                    if(startHour !=0 && startMinutes != 0 || endtHour != 0 && endMinutes !=0 )
                    {
                        if (startHour >= 1 || startMinutes >= 30)
                        {
                            if (endtHour >= 1 || endMinutes >= 30)
                            {
                                string query2 = "SELECT * FROM report WHERE exam_id = @exam_id AND type = 'toilet' AND end = ''";

                                MySqlConnection conn2 = new MySqlConnection("server=localhost;user id=root;database=easytest");
                                conn2.Open();

                                MySqlCommand cmd2 = new MySqlCommand(query2, conn2);

                                cmd2.Parameters.AddWithValue("@exam_id", Login.exam_table.Rows[0].ItemArray[0].ToString());
                                cmd2.Parameters.AddWithValue("@student_id", IDAnsLABEL.Text);
                                //cmd.Parameters.AddWithValue("@start_time", ExitTimeLBL.Text);

                                MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
                                DataTable dt2 = new DataTable();

                                da2.Fill(dt2);

                                if (dt2.Rows.Count > 0)
                                {
                                    if (dt2.Rows[0][2].ToString().Equals(IDAnsLABEL.Text))
                                    {
                                        ContentNote.Visible = false;
                                        comboBox.Visible = false;
                                        TimerBTN.Enabled = true;
                                        ReturnBTN2.Visible = true;
                                        ExitTimeLBL2.Visible = true;
                                        button1.Visible = false;

                                        ExitTimeLBL.Text = dt2.Rows[0].ItemArray[4].ToString();
                                        ExitTimeLBL.Visible = true;
                                        TimerBTN.Text = "סיים טיימר";
                                        TimerClick = true; ClickCount++;
                                        //Main_Screen.StudentInToilet = true;

                                        /*string query = "SELECT report_id, start FROM report WHERE exam_id = @exam_id AND student_id = @student_id AND type = 'toilet' AND end = ''";

                                        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
                                        conn.Open();

                                        MySqlCommand cmd = new MySqlCommand(query, conn);

                                        cmd.Parameters.AddWithValue("@exam_id", Login.exam_table.Rows[0].ItemArray[0].ToString());
                                        cmd.Parameters.AddWithValue("@student_id", IDAnsLABEL.Text);
                                        //cmd.Parameters.AddWithValue("@start_time", ExitTimeLBL.Text);

                                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                                        da.Fill(report_dt);

                                        if (report_dt.Rows.Count > 0)
                                        {*/


                                        //}
                                        //conn.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("קיים סטודנט בשירותים", "הודעה");
                                    }
                                    conn2.Close();


                                }
                                else
                                {
                                    ContentNote.Visible = false;
                                    comboBox.Visible = false;
                                    TimerBTN.Enabled = true;
                                    ReturnBTN2.Visible = true;
                                    ExitTimeLBL2.Visible = true;
                                    button1.Visible = false;
                                }

                            }
                            else
                            {
                                MessageBox.Show("!היציאה לשירותים אסורה", "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }






                        }
                        else
                        {
                            MessageBox.Show("!היציאה לשירותים אסורה", "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }



                    }
                    else
                    {
                        MessageBox.Show("!היציאה לשירותים אסורה", "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("!היציאה לשירותים אסורה", "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }









            }

    }



                ///////////////////////////////////////////////////
  

       
        private void note_CheckedChanged(object sender, EventArgs e)
        {
            if (note.Checked == true)
            {

                button1.Visible = true;
                TimerBTN.Enabled = false;
                ReturnBTN2.Visible = false;
                ExitTimeLBL2.Visible = false;
                ContentNote.Visible = true;
                comboBox.Visible = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ContentNote.Text.Equals(""))
            {
                string query = "";

                if (comboBox.Text.Equals("התחצפות"))
                {
                    query = "INSERT INTO `report` (`report_id`, `exam_id`, `student_id`, `type`, `start`, `end`, `comment`) VALUES (NULL, @exam_id, @student_id, 'brutality', '', '', @comment)";
                }
                if (comboBox.Text.Equals("חשד להעתקה"))
                {
                    query = "INSERT INTO `report` (`report_id`, `exam_id`, `student_id`, `type`, `start`, `end`, `comment`) VALUES (NULL, @exam_id, @student_id, 'suspicion', '', '', @comment)";
                }

                if (!query.Equals(""))
                {
                    if (MessageBox.Show("הקש אישור לביצוע הדיווח", "הודעה", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
                        conn.Open();

                        MySqlCommand cmd = new MySqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("@exam_id", Login.exam_table.Rows[0].ItemArray[0].ToString());
                        cmd.Parameters.AddWithValue("@student_id", IDAnsLABEL.Text);
                        cmd.Parameters.AddWithValue("@comment", ContentNote.Text);

                        cmd.ExecuteNonQuery();

                        conn.Close();
                    }

                }



            }
            else
            {
                MessageBox.Show("נא להזין תוכן דיווח", "הערה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




        }

        private void TimerBTN_Click(object sender, EventArgs e)
        {
            if(ClickCount<2)
            {
                note.Visible = false;
                DateTime now = DateTime.Now;
                if (!TimerClick)
                {
                    if (now.Minute < 10)
                    {
                        ExitTimeLBL.Text = now.Hour.ToString() + ":0" + now.Minute.ToString();
                    }
                    else if (now.Hour < 10)
                    {
                        ExitTimeLBL.Text = "0" + now.Hour.ToString() + ":" + now.Minute.ToString();
                    }
                    else if (now.Hour < 10 && now.Minute < 10)
                    {
                        ExitTimeLBL.Text = "0" + now.Hour.ToString() + ":0" + now.Minute.ToString();
                    }
                    else if (now.Minute == 0)
                    {
                        ExitTimeLBL.Text = now.Hour.ToString() + ":00";
                    }
                    else if (now.Minute == 0)
                    {
                        ExitTimeLBL.Text = now.Hour.ToString() + ":00";
                    }
                    else if (now.Hour == 0)
                    {
                        ExitTimeLBL.Text = "00" + now.Hour.ToString() + ":" + now.Minute.ToString();
                    }
                    else if (now.Hour == 0 && now.Minute == 0)
                    {
                        ExitTimeLBL.Text = "00" + now.Hour.ToString() + ":00" + now.Minute.ToString();

                    }
                    else
                    {
                        ExitTimeLBL.Text = now.Hour.ToString() + ":" + now.Minute.ToString();

                    }
                    ExitTimeLBL.Visible = true;
                    TimerBTN.Text = "סיים טיימר";
                    ClickCount++;
                    studentInToilet = true;
                    studentInToiletTable = tableBTN.Text;

                    //Main_Screen.StudentInToilet = true;

                    string query = "INSERT INTO `report` (`report_id`, `exam_id`, `student_id`, `type`, `start`, `end`, `comment`) VALUES (NULL, @exam_id, @student_id, 'toilet', @start_time, '', '')";

                    MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@exam_id", Login.exam_table.Rows[0].ItemArray[0].ToString());
                    cmd.Parameters.AddWithValue("@student_id", IDAnsLABEL.Text);
                    cmd.Parameters.AddWithValue("@start_time", ExitTimeLBL.Text);

                    cmd.ExecuteNonQuery();

                    conn.Close();
                    Main_Screen.StudentInToilet = true;

                }

                if (TimerClick)
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
                    ClickCount++;
                    studentInToilet = false;
                    backFromToilet = true;

                    /*if(Main_Screen.StudentInToilet)
                    {
                        EndTimeQuery = "UPDATE `report` SET `end` = @end_time WHERE `report`.`report_id` = @report_id";

                    }
                    else
                    {
                        EndTimeQuery = "UPDATE `report` SET `end` = @end_time WHERE `report`.`exam_id` = @exam_id AND `report`.`student_id` = @student_id AND `report`.`end` = ''";

                    }*/
                    EndTimeQuery = "UPDATE `report` SET `end` = @end_time WHERE `report`.`exam_id` = @exam_id AND `report`.`student_id` = @student_id AND `report`.`type` = 'toilet' AND `report`.`end` = ''";

                    MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
                        conn.Open();

                        MySqlCommand cmd = new MySqlCommand(EndTimeQuery, conn);

                        cmd.Parameters.AddWithValue("@exam_id", Login.exam_table.Rows[0].ItemArray[0].ToString());
                        cmd.Parameters.AddWithValue("@student_id", IDAnsLABEL.Text);
                        cmd.Parameters.AddWithValue("@end_time", ReturnBTN.Text);
                         //if (Main_Screen.StudentInToilet) { cmd.Parameters.AddWithValue("@report_id", report_dt.Rows[0][0].ToString()); }
                        //cmd.Parameters.AddWithValue("@start_time", ExitTimeLBL.Text);

                        cmd.ExecuteNonQuery();

                        conn.Close();

                        Main_Screen.StudentInToilet = false;
                    
               


                    //Main_Screen.StudentInToilet = false;
                }
                TimerClick = true;
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                Login.main_screen.Show();
                Hide();
            
            
        }

        private void HomeBackBTN_Click(object sender, EventArgs e)
        {
            Login.main_screen.Show();
            Hide();
        }
    }
}
