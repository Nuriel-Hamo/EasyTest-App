using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace EasyTest_App
{
    public partial class Main_Screen : Form
    {
        int seconds = 60;
        int minutes = 0;
        int hours = 0;
        Boolean firstTimer = true;

        Boolean extraTime1Tick = false;
        Boolean timer1Tick = false;


        //private static readonly int collumn = 5;
        //private static readonly int row = 3;
        private static int CARD_SIZE = 80;
        private static readonly int GAP = 1;
        private readonly Color FORGROUND_COLOR = Color.Black;
        public static Color BACKGROUND_COLOR_main = Color.LightGray;
        public static Button[,] mainMap = new Button[0, 0];
        public static Boolean firstTime = true;
        public static string send2profile;
        public static DataTable maping_table = new DataTable();
        public static DataTable log_table = new DataTable();
        public static string map_row = "";
        public static string map_collumn = "";
        public static Boolean StudentInToilet = false;
        public static Boolean TestBegin =false;
        public static Boolean EmptyClass = true;
        public static Boolean BeginBTN = false;
        public static bool first = true;
        //  public static Button beginBTN;
        public static string class_start_time;
        Boolean FiveMinutes = false;

        public static string tableForIcone = "";
        public static string typeForIcone = "";
        public static Boolean newFinished = false;
        //public static Boolean fristOne = false;
        // private Map_Screen map_screen;
       



        // לסדר את זה שכאשר אני מוסיף את הסטודנט הראשון הכפתור של התחל בחינה יהיה זמין וכו


        public Main_Screen()
        {
            InitializeComponent();
          
            
          
            //map_screen = new Map_Screen();
            //map_screen.ButtonWasClicked += new Map_Screen.ClickButton(map_screen_ButtonWasClicked);

        }
        /* void map_screen_ButtonWasClicked()
         {
             BeginExamBTN.Enabled = true;
         }*/
       
       
        private void BeginExamBTN_Click(object sender, EventArgs e)
        {
            if(BeginExamBTN.Text.Equals("התחל בחינה"))
            {
                TestBegin = true;

                var startMessaage = MessageBox.Show("?האם להתחיל את המבחן", "הודעה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (startMessaage == DialogResult.Yes)
                {
                    string query = "UPDATE `examination_log` SET `start_time` = @startTime, `class_start_time` = @startTime WHERE exam_id = @exam_id";

                    MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    class_start_time = getTime();
                    cmd.Parameters.AddWithValue("@startTime", getTime());
                    cmd.Parameters.AddWithValue("@exam_id", Login.exam_table.Rows[0].ItemArray[0].ToString());
                    int flg = cmd.ExecuteNonQuery();
                    //MySqlDataReader dr = cmd.ExecuteReader();

                    if (flg > 0)
                    {
                        minutes = GetMinutes(Login.exam_table.Rows[0][6].ToString(), Login.exam_table.Rows[0][7].ToString());
                        hours = GetHoures(Login.exam_table.Rows[0][6].ToString(), Login.exam_table.Rows[0][7].ToString());

                        timer1.Enabled = true;
                        timer1.Start();
                        
                        ExtraTimeBTN.Enabled = true;

                        //////////////////////////////////////////////////////////////
                        ///בודק כל הזמן המעדכן אם הכיתה התחילה בחינה - עבור הציאה לשירותים
                        string Query1 = "SELECT * FROM examination_log WHERE exam_id = @exam_id";
                        MySqlConnection conn1 = new MySqlConnection("server=localhost;user id=root;database=easytest");
                        conn1.Open();

                        MySqlCommand cmd1 = new MySqlCommand(Query1, conn1);
                        cmd1.Parameters.AddWithValue("@exam_id", Login.exam_table.Rows[0].ItemArray[0].ToString());
                        MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);

                        da1.Fill(Main_Screen.log_table);
                        conn1.Close();

                        BeginExamBTN.Text = "סיים בחינה";

                    }
                    else { MessageBox.Show("שגיאה", "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Warning); }



                    conn.Close();
                }



            }
            else if(BeginExamBTN.Text.Equals("סיים בחינה"))
            {
                string Query1 = "SELECT * FROM examination_log WHERE exam_id = @exam_id AND end_time = '00:00:00'";
                MySqlConnection conn1 = new MySqlConnection("server=localhost;user id=root;database=easytest");
                conn1.Open();

                MySqlCommand cmd1 = new MySqlCommand(Query1, conn1);
                cmd1.Parameters.AddWithValue("@exam_id", Login.exam_table.Rows[0].ItemArray[0].ToString());
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                DataTable finishTable = new DataTable();
                da1.Fill(finishTable);
                if (finishTable.Rows.Count > 0)
                {
                    MessageBox.Show("יש להמתין שכלל הסטודנטים יגישו בחינה","הודעה",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                }
                else
                {
                    string query = "UPDATE `examination_log` SET `class_end_time` = @class_end_time WHERE exam_id = @exam_id";

                    MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@class_end_time", getTime());
                    cmd.Parameters.AddWithValue("@exam_id", Login.exam_table.Rows[0].ItemArray[0].ToString());
                    int flg = cmd.ExecuteNonQuery();

                    if (flg > 0)
                    {
                        MessageBox.Show("מבחן הסתיים בהצלחה", "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else { MessageBox.Show("שגיאה", "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                }

                conn1.Close();
            }


        }

        private void AddStudentBTN_Click(object sender, EventArgs e)
        {
            Add_Student add_student_screen = new Add_Student();
            add_student_screen.Show();
            Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1Tick = true;
            if (hours == 0 && minutes <5 && !FiveMinutes)
            {
                TimerLBL.ForeColor = Color.Red;
                FiveMinutes = true;
            }
            if (hours==0 && minutes == 0 && seconds == 0)
            {

                timer1.Stop();
                if (!ExtraTimeForm.extraTime1.Equals(""))
                {
                    minutes = Int32.Parse(ExtraTimeForm.extraTime1.Substring(3, 2));
                    hours = 0;
                    firstTimer = true;
                    FiveMinutes = false;
                    timer1Tick = false;
                    timerExtra1.Start();

                }
                else
                {
                    MessageBox.Show("המבחן הסתיים");

                }
            }
            else
            {
                if (firstTimer)
                {
                    //label1.Text = "0" + hours + ":00:00";
                    if (minutes < 10)
                    {
                        TimerLBL.Text = "0" + hours + ":0" + minutes + ":00";
                    }
                    else
                    {
                        TimerLBL.Text = "0" + hours + ":" + minutes + ":00";
                    }
                    if (minutes != 0) { minutes--; }
                    else
                    {
                        if (hours != 0) { hours--; minutes = 59; }
                    }
                }
                else
                {
                    if (seconds == 0)
                    {
                        if(hours!=0 && minutes == 0)
                        {
                            minutes = 59;
                            hours--;
                        }
                        else
                        {
                            minutes--;
                        }
                       
                        seconds = 60;

                    }
                    if (minutes == 0)
                    {
                        if (hours == 0)
                        {
                            minutes = 0;
                        }
                        else if (hours!=0 && seconds!=0)
                        {
                            minutes = 0;
                        }
                        else
                        {
                            hours--;
                            minutes = 59;
                        }
                      
                    }
                    seconds--;

                    if (hours < 10 && minutes < 10 && seconds < 10)
                    {
                        TimerLBL.Text = "0" + hours + ":0" + minutes + ":0" + seconds;
                    }
                    else if (hours < 10 && minutes < 10 && seconds >= 10)
                    {
                        TimerLBL.Text = "0" + hours + ":0" + minutes + ":" + seconds;
                    }
                    else if (hours < 10 && minutes >= 10 && seconds >= 10)
                    {
                        TimerLBL.Text = "0" + hours + ":" + minutes + ":" + seconds;
                    }
                    else if (hours < 10 && minutes >= 10 && seconds < 10)
                    {
                        TimerLBL.Text = "0" + hours + ":" + minutes + ":0" + seconds;
                    }


                }
                firstTimer = false;

            }
            

        }

        private void Main_Screen_Load(object sender, EventArgs e)
        {





                ////////////////////////////////////////////////////////////////////
                labelName.Text = "." + Login.proctor_table.Rows[0][2].ToString() + " " + Login.proctor_table.Rows[0][3].ToString();
                dateLBL.Text = DateTime.Now.ToString("dd/MM/yyyy");


            ////////////////////////////////////////////////////////////////////

            string Query = "SELECT * FROM mapping WHERE class_num = @class_num";
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@class_num", Login.exam_table.Rows[0].ItemArray[4].ToString());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(maping_table);

            map_row = maping_table.Rows[0].ItemArray[1].ToString();
            map_collumn = maping_table.Rows[0].ItemArray[2].ToString();

            mainMap = new Button[Int32.Parse(map_collumn), Int32.Parse(map_row)];
            conn.Close();





            if (firstTime)
            {
                int id = 0;
                /*if(Int32.Parse(map_row)>5 || Int32.Parse(map_collumn) > 6)
                {
                    CARD_SIZE = 60;
                }*/
                
                for (int i = 0; i < Int32.Parse(map_row); i++)
                {
                    for (int j = 0; j < Int32.Parse(map_collumn); j++)
                    {

                        id++;

                        mainMap[j, i] = new Button
                        {
                            Name = "card" + j + i,
                            Size = new Size(CARD_SIZE, CARD_SIZE),
                            Location = new Point(GAP + j * (CARD_SIZE + GAP),GAP + i * (CARD_SIZE + GAP)),
                            TextAlign = ContentAlignment.MiddleCenter,
                            Font = new Font("david", 20),
                            ForeColor = FORGROUND_COLOR,
                            BackColor = BACKGROUND_COLOR_main,
                            Text = id.ToString(),
                            

                        };
                        //mainMap[j, i].Location = new Point(1, 1);
                        panel1.Controls.Add(mainMap[j, i]);
                        panel1.AutoSize = true;
                        panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                        //panel1.Location = new Point(12, 17);
                        //panel1.Size = new Size(400, 200);
                        //Controls.Add(mainMap[j, i]);
                        //Controls.Add(mainMap[j, i]);
                        mainMap[j, i].Click += Button_Click;
                        mainMap[j, i].Enabled = false;






                    }
                    // groupBox1.AutoSize = true;
                    //groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                    // Controls.AutoSize = true;
                    // Controls.AutoSizeMode = AutoSizeMode.GrowAndShrink;

                }
                string Query1 = "SELECT * FROM examination_log WHERE exam_id = @exam_id";
                MySqlConnection conn1 = new MySqlConnection("server=localhost;user id=root;database=easytest");
                conn1.Open();

                MySqlCommand cmd1 = new MySqlCommand(Query1, conn1);
                cmd1.Parameters.AddWithValue("@exam_id", Login.exam_table.Rows[0].ItemArray[0].ToString());
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                
                da1.Fill(log_table);
                conn1.Close();
                if (log_table.Rows.Count > 0)
                {

                    if (!(log_table.Rows[0][12].ToString().Equals("00:00:00")))
                    {
                        BeginExamBTN.Text = "סיים בחינה";
                        TestBegin = true;
                        EmptyClass = false;
                        class_start_time = log_table.Rows[0][12].ToString();
                        ExtraTimeBTN.Enabled = true;

                        minutes = GetMinutes(getTime(), ChangeEndTime());
                        hours = GetHoures(getTime(), ChangeEndTime());

                        timer1.Start();

                        /////////////////////////////////////////////////////////////

                        string query2 = "SELECT * FROM report WHERE exam_id = @exam_id AND type = 'toilet' AND end = ''";

                        MySqlConnection conn2 = new MySqlConnection("server=localhost;user id=root;database=easytest");
                        conn2.Open();

                        MySqlCommand cmd2 = new MySqlCommand(query2, conn2);

                        cmd2.Parameters.AddWithValue("@exam_id", Login.exam_table.Rows[0].ItemArray[0].ToString());

                        MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();

                        da2.Fill(dt2);

                        if (dt2.Rows.Count > 0)
                        {
                            string query3 = "SELECT table_num FROM examination_log WHERE exam_id = @exam_id AND student_id = @student_id";


                            MySqlCommand cmd3 = new MySqlCommand(query3, conn2);

                            cmd3.Parameters.AddWithValue("@exam_id", dt2.Rows[0].ItemArray[1].ToString());
                            cmd3.Parameters.AddWithValue("@student_id", dt2.Rows[0].ItemArray[2].ToString());

                            MySqlDataAdapter da3 = new MySqlDataAdapter(cmd3);
                            DataTable dt3 = new DataTable();

                            da3.Fill(dt3);

                            SetIcone(dt3.Rows[0][0].ToString(),"toilet");


                        }
                        conn2.Close();







                    }
                    else
                    {
                        BeginExamBTN.Enabled = true;
                        TestBegin = false;
                        EmptyClass = false;

                        minutes = GetMinutes(Login.exam_table.Rows[0][6].ToString(), Login.exam_table.Rows[0][7].ToString());
                        hours = GetHoures(Login.exam_table.Rows[0][6].ToString(), Login.exam_table.Rows[0][7].ToString());

                    }

                    //int count = 0;
                    for (int i = 0; i < Int32.Parse(Main_Screen.map_row); i++)
                    {
                        for (int j = 0; j < Int32.Parse(Main_Screen.map_collumn); j++)
                        {
                            for (int t = 0; t < log_table.Rows.Count; t++)
                            {
                                if (Main_Screen.mainMap[j, i].Text == log_table.Rows[t][8].ToString() && log_table.Rows[t][10].ToString().Equals("00:00:00"))
                                {
                                    Main_Screen.mainMap[j, i].BackColor = Color.Green;
                                    Main_Screen.mainMap[j, i].Enabled = true;
                                }
                                else if(Main_Screen.mainMap[j, i].Text == log_table.Rows[t][8].ToString() && !log_table.Rows[t][10].ToString().Equals("00:00:00"))
                                {
                                    Main_Screen.mainMap[j, i].BackColor = Color.DimGray;
                                    Main_Screen.mainMap[j, i].Enabled = false;
                                    SetIcone(log_table.Rows[t][8].ToString(),"finish");

                                }

                            }

                            /*if (Main_Screen.mainMap[j, i].Text == log_table.Rows[count][8].ToString())
                            {
                                Main_Screen.mainMap[j, i].BackColor = Color.Red;
                                Main_Screen.mainMap[j, i].Enabled = true;
                            }*/

                        }
                    }
                }
                else 
                {
                    BeginExamBTN.Enabled = false;
                    EmptyClass = true;
                    TestBegin = false;
                }   


                firstTime = false;

            }
            ///////////////////////////////////////////////////////




            





            


        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            send2profile = btn.Text;
            StudentProfileForm st = new StudentProfileForm();
            st.Show();
            Hide();

            /*             
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    if (btn == cards[i, j])
                    {
                      
                    }
                }
            }*/
        }   


        

        private void ReportBTN_Click(object sender, EventArgs e)
        {

        }
        public void setName(string name)
        {
            labelName.Text = "Hello" + name;
        }

        private void ExtraTimeBTN_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static string getTime()
        {
            string time = "";

            DateTime now = DateTime.Now;

            if (now.Minute < 10)
            {
                time = now.Hour.ToString() + ":0" + now.Minute.ToString() + ":00";
            }
            else if (now.Hour < 10)
            {
                time = "0" + now.Hour.ToString() + ":" + now.Minute.ToString() + ":00";
            }
            else if (now.Hour < 10 && now.Minute < 10)
            {
                time = "0" + now.Hour.ToString() + ":0" + now.Minute.ToString() + ":00";
            }
            else if (now.Minute == 0)
            {
                time = now.Hour.ToString() + ":00" + ":00";
            }
            else if (now.Minute == 0)
            {
                time = now.Hour.ToString() + ":00" + ":00";
            }
            else if (now.Hour == 0)
            {
                time = "00" + now.Hour.ToString() + ":" + now.Minute.ToString() + ":00";
            }
            else if (now.Hour == 0 && now.Minute == 0)
            {
                time = "00" + now.Hour.ToString() + ":00" + now.Minute.ToString() + ":00";

            }
            else
            {
                time = now.Hour.ToString() + ":" + now.Minute.ToString() + ":00";

            }
            return time;
            

        }

        private void Main_Screen_Activated(object sender, EventArgs e)
        {
            if (!first)
            {
                BeginExamBTN.Enabled = true;
                first = true;
            }
            if (StudentInToilet)
            {
                SetIcone(ReportForm.studentInToiletTable,"toilet");
            }
            if (ReportForm.backFromToilet)
            {
                toiletError.Clear();
                ReportForm.backFromToilet = false;
            }
            if(!tableForIcone.Equals("") && !typeForIcone.Equals("") && newFinished)
            {
                SetIcone(tableForIcone,typeForIcone);
                newFinished = false;
            }
            if (!ExtraTimeForm.extraTime1.Equals("")) { labelExTime1.Text = ExtraTimeForm.extraTime1; }
            if (!ExtraTimeForm.extraTime2.Equals("")) 
            {
                //labelExTime1.Text = ExtraTimeForm.extraTime2; 
                if (extraTime1Tick)
                {
                    extraTime1Tick = false;
                    minutes = minutes + Int32.Parse(ExtraTimeForm.extraTime2.Substring(3, 2));
                }
                if (timer1Tick)
                {
                    labelExTime1.Text = "00:30:00";
                }

            }



        }
        private void SetIcone(string table, string type)
        {
            for (int i = 0; i < Int32.Parse(Main_Screen.map_row); i++)
            {
                for (int j = 0; j < Int32.Parse(Main_Screen.map_collumn); j++)
                {
                    if (Main_Screen.mainMap[j, i].Text == table)
                    {
                        if (type.Equals("toilet"))
                        {
                            toiletError.SetError(Main_Screen.mainMap[j, i], "סטודנט/ית בשולחן " + table + " עדיין בשירותים");
                            toiletError.SetIconAlignment(Main_Screen.mainMap[j, i], ErrorIconAlignment.BottomRight);
                            toiletError.SetIconPadding(Main_Screen.mainMap[j, i], -32);

                        }
                        if (type.Equals("finish"))
                        {
                            finishError.SetError(Main_Screen.mainMap[j, i], "סטודנט/ית בשולחן " + table + " הגיש/ה בחינה");
                            finishError.SetIconAlignment(Main_Screen.mainMap[j, i], ErrorIconAlignment.BottomRight);
                            finishError.SetIconPadding(Main_Screen.mainMap[j, i], -32);
                            Main_Screen.mainMap[j, i].Enabled = false;
                            Main_Screen.mainMap[j, i].BackColor = Color.DimGray;

                        }
                        //Main_Screen.mainMap[j, i].



                    }
                }
            }

        }
        public static int GetHoures(string start, string end)
        {
            int hoursInMin = 0;
            int minutes = 0;
            int result = 0;

            int startHour = Int32.Parse(start.Substring(0, 2));
            int endMinutes = Int32.Parse(end.Substring(3, 2));
            int endHour = Int32.Parse(end.Substring(0, 2));
            int startMinutes = Int32.Parse(start.Substring(3, 2));
            
            hoursInMin = (endHour - startHour)*60;

            if (endMinutes > startMinutes)
            {
                minutes = endMinutes - startMinutes;
                result = (hoursInMin + minutes) / 60;
                return result;
            }
            else if (startMinutes > endMinutes)
            {
                minutes = startMinutes - endMinutes;    
                ///
            }
            else
            {
                minutes = startMinutes - endMinutes;
                //
            }

            result = (hoursInMin - minutes)/60;

            return result;
        }
        public static int GetMinutes(string start, string end)
        {
            int minutes = 0;
            int result = 0;

            int endMinutes = Int32.Parse(end.Substring(3, 2));
            int startMinutes = Int32.Parse(start.Substring(3, 2));

            minutes = 60 - startMinutes;

            if (endMinutes > startMinutes)
            {
                result = endMinutes - startMinutes;
            }
            else if (startMinutes > endMinutes)
            {
                result = minutes + endMinutes;
            }
            else
            {
                result = 0;
            }
            return result;


        }
        public static string ChangeEndTime()
        {
            string result = "";
            string endTimeExam = Login.exam_table.Rows[0][7].ToString();
            string startOrg = Login.exam_table.Rows[0][6].ToString();
            string startReal = log_table.Rows[0][12].ToString();
            int startOrgHour = Int32.Parse(startOrg.Substring(0, 2));
            int startOrgMinutes = Int32.Parse(startOrg.Substring(3, 2));
            int startRealHour = Int32.Parse(startReal.Substring(0, 2));
            int startRealMinutes = Int32.Parse(startReal.Substring(3, 2));

            if (startOrgHour == startRealHour)
            {
                int x = startRealMinutes - startOrgMinutes;
                int finalMinutes = x + Int32.Parse(endTimeExam.Substring(3, 2));
                if (finalMinutes < 60)
                {
                    if (finalMinutes < 10)
                    {
                        result = endTimeExam.Substring(0, 2) + ":0" + finalMinutes.ToString() + ":00";
                    }
                    else if (finalMinutes >= 10)
                    {
                        result = endTimeExam.Substring(0, 2) + ":" + finalMinutes.ToString() + ":00";

                    }

                }
                else if (finalMinutes > 60)
                {
                    finalMinutes = finalMinutes - 60;
                    if (finalMinutes < 10)
                    {
                        result = (Int32.Parse(endTimeExam.Substring(0, 2))+1).ToString()  + ":0" + finalMinutes.ToString() + ":00";
                    }
                    else if (finalMinutes >= 10)
                    {
                        result = (Int32.Parse(endTimeExam.Substring(0, 2)) + 1).ToString() + ":" + finalMinutes.ToString() + ":00";

                    }
                }
                else
                {
                    result = (Int32.Parse(endTimeExam.Substring(0, 2)) + 1).ToString() + ":00" + ":00";
                }
            }        
            else if (startRealHour > startOrgHour)
            {
                int x = (60 - startOrgMinutes) + startRealMinutes;
                int endMinutes = Int32.Parse(endTimeExam.Substring(3, 2));
                int finalMinutes = 0;
                if (endMinutes == 0)
                {
                    finalMinutes = (endMinutes + x);
                }
                else
                {
                    finalMinutes = (endMinutes + x) - 60;
                }
                if (finalMinutes + endMinutes > 60)
                {
                    if (finalMinutes < 10)
                    {
                        result = (Int32.Parse(endTimeExam.Substring(0, 2)) + 1).ToString() + ":0" + finalMinutes.ToString() + ":00";
                    }
                    else
                    {
                        result = (Int32.Parse(endTimeExam.Substring(0, 2)) + 1).ToString() + ":" + finalMinutes.ToString() + ":00";

                    }

                }
                else
                {
                    if (finalMinutes < 10)
                    {
                        result = (Int32.Parse(endTimeExam.Substring(0, 2))).ToString() + ":0" + finalMinutes.ToString() + ":00";
                    }
                    else
                    {
                        result = (Int32.Parse(endTimeExam.Substring(0, 2))).ToString() + ":" + finalMinutes.ToString() + ":00";

                    }
                }

            }
            return result;



        }

        private void timerExtra1_Tick(object sender, EventArgs e)
        {
            extraTime1Tick = true;

            if (minutes < 5 && !FiveMinutes)
            {
                labelExTime1.ForeColor = Color.Red;
                FiveMinutes = true;
            }
            if (minutes == 0 && seconds == 0)
            {

                timerExtra1.Stop();
                MessageBox.Show("המבחן הסתיים");

                
            }
            else
            {
                if (firstTimer)
                {
                    //label1.Text = "0" + hours + ":00:00";
                    if (minutes < 10)
                    {
                        labelExTime1.Text = "0" + hours + ":0" + minutes + ":00";
                    }
                    else
                    {
                        labelExTime1.Text = "0" + hours + ":" + minutes + ":00";
                    }
                    if (minutes != 0) { minutes--; }
                    else
                    {
                        if (hours != 0) { hours--; minutes = 59; }
                    }
                }
                else
                {
                    if (seconds == 0)
                    {
                        if (hours != 0 && minutes == 0)
                        {
                            minutes = 59;
                            hours--;
                        }
                        else
                        {
                            minutes--;
                        }

                        seconds = 60;

                    }
                    if (minutes == 0)
                    {
                        if (hours == 0)
                        {
                            minutes = 0;
                        }
                        else if (hours != 0 && seconds != 0)
                        {
                            minutes = 0;
                        }
                        else
                        {
                            hours--;
                            minutes = 59;
                        }

                    }
                    seconds--;

                    if (hours < 10 && minutes < 10 && seconds < 10)
                    {
                        labelExTime1.Text = "0" + hours + ":0" + minutes + ":0" + seconds;
                    }
                    else if (hours < 10 && minutes < 10 && seconds >= 10)
                    {
                        labelExTime1.Text = "0" + hours + ":0" + minutes + ":" + seconds;
                    }
                    else if (hours < 10 && minutes >= 10 && seconds >= 10)
                    {
                        labelExTime1.Text = "0" + hours + ":" + minutes + ":" + seconds;
                    }
                    else if (hours < 10 && minutes >= 10 && seconds < 10)
                    {
                        labelExTime1.Text = "0" + hours + ":" + minutes + ":0" + seconds;
                    }


                }
                firstTimer = false;

            }


        }

    }
}
