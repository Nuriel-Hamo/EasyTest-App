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
    public partial class Main_Screen : Form
    {
        int minutes = 0;
        int seconds = 0;

        //private static readonly int collumn = 5;
        //private static readonly int row = 3;
        private static readonly int CARD_SIZE = 45;
        private static readonly int GAP = 1;
        private readonly Color FORGROUND_COLOR = Color.Black;
        public static Color BACKGROUND_COLOR_main = Color.LightGray;
        public static Button[,] mainMap = new Button[0, 0];
        public static Boolean firstTime = true;
        public static string send2profile;
        public static DataTable maping_table = new DataTable();
        public static string map_row = "";
        public static string map_collumn = "";
        public static Boolean StudentInToilet = false;



        public Main_Screen()
        {
            InitializeComponent();
        }

        private void BeginExamBTN_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void AddStudentBTN_Click(object sender, EventArgs e)
        {
            Add_Student add_student_screen = new Add_Student();
            add_student_screen.Show();
            Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(seconds == 60)
            {
                minutes++;
                seconds = 0;
            }
            if (minutes < 10 && seconds < 10)
            {
                label1.Text = "0" + minutes + ":0" + seconds;
            }
            else if (minutes < 10 && seconds > 10)
                label1.Text = "0" + minutes + ":" + seconds;
            else
                label1.Text = minutes + ":" + seconds;
            seconds++;

        }

        private void Main_Screen_Load(object sender, EventArgs e)
        {

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

                for (int i = 0; i < Int32.Parse(map_row); i++)
                {
                    for (int j = 0; j < Int32.Parse(map_collumn); j++)
                    {

                        id++;

                        mainMap[j, i] = new Button
                        {
                            Name = "card" + j + i,
                            Size = new Size(CARD_SIZE, CARD_SIZE),
                            Location = new Point(50 * GAP + j * (CARD_SIZE + GAP), 50 * GAP + i * (CARD_SIZE + GAP)),
                            TextAlign = ContentAlignment.MiddleCenter,
                            Font = new Font("david", 20),
                            ForeColor = FORGROUND_COLOR,
                            BackColor = BACKGROUND_COLOR_main,
                            Text = id.ToString(),

                        };
                        //groupBox1.Controls.Add(mainMap[j, i]);
                        Controls.Add(mainMap[j, i]);
                        //Controls.Add(mainMap[j, i]);
                        mainMap[j, i].Click += Button_Click;
                        mainMap[j, i].Enabled = false;






                    }
                    // groupBox1.AutoSize = true;
                    //groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                    // Controls.AutoSize = true;
                    // Controls.AutoSizeMode = AutoSizeMode.GrowAndShrink;

                }
                firstTime = false;

            }
            ///////////////////////////////////////////////////////




            string Query1 = "SELECT * FROM examination_log WHERE exam_id = @exam_id";
            MySqlConnection conn1 = new MySqlConnection("server=localhost;user id=root;database=easytest");
            conn1.Open();

            MySqlCommand cmd1 = new MySqlCommand(Query1, conn1);
            cmd1.Parameters.AddWithValue("@exam_id", Login.exam_table.Rows[0].ItemArray[0].ToString());
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
            DataTable log_table = new DataTable();
            da1.Fill(log_table);
            conn1.Close();
            if (log_table.Rows.Count > 0)
            {
                //int count = 0;
                for (int i = 0; i < Int32.Parse(Main_Screen.map_row); i++)
                {
                    for (int j = 0; j < Int32.Parse(Main_Screen.map_collumn); j++)
                    {
                        for (int t = 0; t < log_table.Rows.Count; t++)
                        {
                            if (Main_Screen.mainMap[j, i].Text == log_table.Rows[t][8].ToString())
                            {
                                Main_Screen.mainMap[j, i].BackColor = Color.Red;
                                Main_Screen.mainMap[j, i].Enabled = true;
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


        private void EndExamBTN_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
