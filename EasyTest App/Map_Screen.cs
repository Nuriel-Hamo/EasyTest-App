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
    public partial class Map_Screen : Form
    {
        //public delegate void ClickButton();
        //public event ClickButton ButtonWasClicked;

        public static string saveColor;
        //private static readonly int collumn = 5;
        //private static readonly int row = 3;
        private static readonly int CARD_SIZE = 45;
        private static readonly int GAP = 1;
        public static  Boolean BoolEnabled = true;
        private readonly Color FORGROUND_COLOR = Color.Black;
        public static Color BACKGROUND_COLOR_map = Color.LightGray;
        public static Button[,] cards = new Button[Int32.Parse(Main_Screen.map_collumn), Int32.Parse(Main_Screen.map_row)];
        private static string lastBTN = "";


        public Map_Screen()
        {
            InitializeComponent();
            
            
        }
       
       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TURNOFF();
            //button1.BackColor = Color.Green;
            //saveColor = button1.Name;
            //btn1.BackColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TURNOFF();
            //button2.BackColor = Color.Green;
            //btn2.BackColor = Color.Green;
        }

        public void Map_Screen_Load(object sender, EventArgs e)
        {
                                           
            int id = 0;
            
            for (int i = 0; i < Int32.Parse(Main_Screen.map_row); i++)
            {
                for (int j = 0; j < Int32.Parse(Main_Screen.map_collumn); j++)
                {
                    id++;
                    if(Main_Screen.mainMap[j,i].BackColor == Color.Green)
                    {
                        BACKGROUND_COLOR_map = Color.Red;
                        BoolEnabled = false;
                    }
                    else
                    {
                        BACKGROUND_COLOR_map = Color.LightGray;
                        BoolEnabled = true;
                    }
                    cards[j, i] = new Button
                    {
                        Name = "card" + j + i,
                        Size = new Size(CARD_SIZE, CARD_SIZE),
                        Location = new Point(GAP + j * (CARD_SIZE + GAP), GAP + i * (CARD_SIZE + GAP)),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("david", 20),
                        ForeColor = FORGROUND_COLOR,
                        BackColor = BACKGROUND_COLOR_map,
                        Text = id.ToString(),
                        Enabled = BoolEnabled,

                        
                    };
                    panel1.Controls.Add(cards[j, i]);
                    panel1.AutoSize = true;
                    panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                    //Controls.Add(cards[j, i]);
                    cards[j, i].Click += Button_Click;
                   
                }               
            }                  
        }
        private void Button_Click(object sender, EventArgs e)
        {           
            Button btn = sender as Button;
            //MessageBox.Show(btn.Text);
            if(btn != null)

            {
                lastBTN = btn.Text;

                for (int i = 0; i < Int32.Parse(Main_Screen.map_row); i++)
                {
                    for (int j = 0; j < Int32.Parse(Main_Screen.map_collumn); j++)
                    {

                        if (btn == cards[j, i])
                        {
                            ResetBoard();
                            cards[j, i].BackColor = Color.Green;
                            
                        }
                    }
                }
            }
            
        }
        
            public void ResetBoard()
        {
            for (int i = 0; i < Int32.Parse(Main_Screen.map_row); i++)
            {
                for (int j = 0; j < Int32.Parse(Main_Screen.map_collumn); j++)
                {            
                    if(cards[j,i].BackColor == Color.Green)
                    {
                        cards[j, i].BackColor = Color.LightGray;
                    }
                       
                         
                    
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            NoteBook_Num nb = new NoteBook_Num();
            nb.Show();
            Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!lastBTN.Equals(""))
            {
                string query = "";
                if (Main_Screen.EmptyClass && !Main_Screen.TestBegin)
                {
                    Main_Screen.EmptyClass = false;
                    Main_Screen.BeginBTN = true;
                    Main_Screen.first = false;
                    /////////////////////////////////////////////////////      
                    
                  

                }
                if (Main_Screen.TestBegin)
                {
                    query = "INSERT INTO `examination_log` (`exam_id`, `student_id`," +
                   " `lecturer_id`, `proctor_id`, `report_id`, `course_id`, `class_num`," +
                   " `notebook_num`, `table_num`, `start_time`, `end_time`," +
                   " `extra_time`, `class_start_time`) VALUES (@exam_id, @student_id, @lecturer_id, @proctor_id, ''," +
                   " @course_id, @class_num, @notebook_num, @table_num, @startTime, '', '',@class_start_time)";
                }
                else
                {
                    query = "INSERT INTO `examination_log` (`exam_id`, `student_id`," +
                   " `lecturer_id`, `proctor_id`, `report_id`, `course_id`, `class_num`," +
                   " `notebook_num`, `table_num`, `start_time`, `end_time`," +
                   " `extra_time`, `class_start_time`) VALUES (@exam_id, @student_id, @lecturer_id, @proctor_id, ''," +
                   " @course_id, @class_num, @notebook_num, @table_num, '', '', '','')";
                }



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
                cmd.Parameters.AddWithValue("@startTime", Main_Screen.getTime());
                cmd.Parameters.AddWithValue("@class_start_time", Main_Screen.class_start_time);


                cmd.ExecuteNonQuery();

                conn.Close();
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




                // sending the result to main screen //

                for (int i = 0; i < Int32.Parse(Main_Screen.map_row); i++)
                {
                    for (int j = 0; j < Int32.Parse(Main_Screen.map_collumn); j++)
                    {
                        if (cards[j, i].BackColor == Color.Green)
                        {
                            Main_Screen.mainMap[j, i].BackColor = Color.Green;
                            Main_Screen.mainMap[j, i].Enabled = true;

                        }

                    }
                }




                Add_Student.student_table.Clear();
                Login.main_screen.Show();
                Hide();

            }
            else MessageBox.Show("נא לבחור מס' שולחן", "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            TURNOFF();
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TURNOFF();
            //button4.BackColor = Color.Green;
            //btn4.BackColor = Color.Green;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TURNOFF();
            //button5.BackColor = Color.Green;
            //btn5.BackColor = Color.Green;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TURNOFF();
            //button6.BackColor = Color.Green;
            //btn6.BackColor = Color.Green;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TURNOFF();
            //button7.BackColor = Color.Green;
            //btn7.BackColor = Color.Green;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TURNOFF();
            //button8.BackColor = Color.Green;
            //btn8.BackColor = Color.Green;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TURNOFF();
            //button9.BackColor = Color.Green;
            //btn9.BackColor = Color.Green;
        }
        public void TURNOFF()
        {
            //button1.BackColor = Color.Gray;
            //button2.BackColor = Color.Gray;
            //button3.BackColor = Color.Gray;
            //button4.BackColor = Color.Gray;
            //button5.BackColor = Color.Gray;
            //button6.BackColor = Color.Gray;
            //button7.BackColor = Color.Gray;
            //button8.BackColor = Color.Gray;
           // button9.BackColor = Color.Gray;
            /*
            btn1.BackColor = Color.Gray;
            btn2.BackColor = Color.Gray;
            btn3.BackColor = Color.Gray;
            btn4.BackColor = Color.Gray;
            btn5.BackColor = Color.Gray;
            btn6.BackColor = Color.Gray;
            btn7.BackColor = Color.Gray;
            btn8.BackColor = Color.Gray;
            btn9.BackColor = Color.Gray;
            */
        }
    }
}
