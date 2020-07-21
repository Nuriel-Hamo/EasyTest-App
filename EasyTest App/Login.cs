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
using EasyTest_App.BL;

namespace EasyTest_App
{
    public partial class Login : Form
    {
        public static string admin_id;
        public static Boolean startProgram = false;
        public static Boolean ClickTextBox1 = false;
        public static Boolean ClickTextBox2 = false;
        public static AdminForm adminF = new AdminForm();
        public static DataTable exam_table = new DataTable();
        public static Main_Screen main_screen = new Main_Screen();
        public static DataTable proctor_table = new DataTable();



        public Login()
        {
            InitializeComponent();
        }


        private void LoginBTN_Click(object sender, EventArgs e)
        {
            Regex IdReg = new Regex("[0-9]{9}");
            Regex PassReg = new Regex("[0-9]{5}");
            if (!startProgram)
            {

                if (!IdReg.IsMatch(UserID_textbox.Text))
                {
                    MessageBox.Show("יש להזין ת.ז כולל ספרת ביקורת", "הודעה");
                    if (!PassReg.IsMatch(Pass_textbox.Text)) { MessageBox.Show("יש להזין סיסמה עם 5 ספרות", "הודעה"); }
                }
                else if (!PassReg.IsMatch(Pass_textbox.Text))
                {
                    MessageBox.Show("יש להזין סיסמה עם 5 ספרות", "הודעה");

                }
                else
                {

                    string Query = "SELECT * FROM proctor WHERE proctor_id = @UserID_textbox AND " +
                        "proctor_pass = @Pass_textbox";
                    MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(Query, conn);
                    cmd.Parameters.AddWithValue("@UserID_textbox", UserID_textbox.Text);
                    cmd.Parameters.AddWithValue("@Pass_textbox", Pass_textbox.Text);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(proctor_table);
                    conn.Close();


                    if (proctor_table.Rows.Count > 0)
                    {
                       

                        if (proctor_table.Rows[0][5].ToString() == "0")
                        {
                            //create an copy table of exam (local table)..........................................................................
                            startProgram = true;////  לשנות



                            //////
                            conn.Open();
                            MySqlCommand cmdExam = new MySqlCommand("SELECT * FROM exam WHERE proctor_id = @UserID_textbox", conn);
                            cmdExam.Parameters.AddWithValue("@UserID_textbox", UserID_textbox.Text);
                            MySqlDataAdapter dataAD = new MySqlDataAdapter(cmdExam);
                            dataAD.Fill(exam_table);
                            if (exam_table.Rows.Count > 0)
                            {
                                exam_table = Service.CheckExamDateTime(exam_table);
                                //Main_Screen main_screen = new Main_Screen();
                                conn.Close();
                                main_screen.Show();
                                //Hide();

                            }
                            else { MessageBox.Show("משגיח אינו משובץ לבחינה", "הערה", MessageBoxButtons.OK, MessageBoxIcon.Warning); }



                        }
                        else if (proctor_table.Rows[0][5].ToString() == "1")
                        {
                            conn.Close();
                            admin_id = proctor_table.Rows[0][0].ToString();
                            adminF.Show();
                            proctor_table.Clear();
                            ///Hide();
                            //// לשנות



                           
                        }

                    }
                    else { MessageBox.Show("שם משתמש או סיסמה שגויים", "הודעה"); }
                }

            }
            else if (startProgram)// Login for lecturer
            {
                string Query = "SELECT * FROM lecturer WHERE lecturer_id = @UserID_textbox AND " +
                       "lecturer_pass = @Pass_textbox";
                MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(Query, conn);
                cmd.Parameters.AddWithValue("@UserID_textbox", UserID_textbox.Text);
                cmd.Parameters.AddWithValue("@Pass_textbox", Pass_textbox.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    if (SummaryForm.send == "summary")
                    {
                        SummaryForm.send = "lecturer";
                        Main_Screen.s.Show();
                        Hide();

                    }
                    else
                    {
                        conn.Close();
                        ExtraTimeForm ex = new ExtraTimeForm();
                        ex.Show();
                        Hide();
                    }

                }
                else
                {
                    MessageBox.Show("שם משתמש או סיסמה שגויים", "הודעה");

                }
            }
            else MessageBox.Show("שם משתמש או סיסמה שגויים", "הודעה");

            ClickTextBox1 = false;
            ClickTextBox2 = false;
            UserID_textbox.Text = "הכנס ת.ז";
            Pass_textbox.Text = "הכנס סיסמה";


        }

        private void LoginBTN_MouseHover(object sender, EventArgs e)
        {
            LoginBTN.BackColor = Color.CornflowerBlue; 
        }

     

        private void Login_Load(object sender, EventArgs e)
        {
            

            if (startProgram) { login_backBTN.Visible = true; }
            panel3.BackColor = Color.FromArgb(150, 0, 0, 0);
           
        }

        private void login_backBTN_Click(object sender, EventArgs e)
        {
            main_screen.Show();
            Hide();
        }

        private void UserID_textbox_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (!ClickTextBox1)
            {
                UserID_textbox.Text = "";
                ClickTextBox1 = true;
              
            }
            
        }

        private void Pass_textbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (!ClickTextBox2)
            {
                Pass_textbox.Text = "";
                ClickTextBox2 = true;
            }
        }

        private void LoginBTN_MouseLeave(object sender, EventArgs e)
        {
            LoginBTN.BackColor = Color.RoyalBlue;
        }
    }
}
