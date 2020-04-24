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
    public partial class Login : Form
    {
       // bool changed = false;
     
        public Login()
        {
            InitializeComponent();
        }
        public static Boolean startProgram = false;
        public static Boolean ClickTextBox1 = false; 
        public static Boolean ClickTextBox2 = false;


        private void LoginBTN_Click(object sender, EventArgs e)
        {
           

            if (!startProgram) 
            {

                if (UserID_textbox.Text.Trim() == "" && Pass_textbox.Text.Trim() == "")
                {
                    MessageBox.Show("יש להזין תוכן", "הודעה");
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
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    MySqlDataReader rdr = cmd.ExecuteReader();
                    rdr.Read();


                    if (dt.Rows.Count > 0)
                    {
                        startProgram = true;
                        if (rdr.GetString(5) == "0")
                        {
                            Main_Screen main_screen = new Main_Screen();
                            main_screen.Show();
                            Hide();
                          
                        }
                        if (rdr.GetString(5) == "1")
                        {

                            AdminForm admin = new AdminForm();
                            admin.Show();
                            Hide();
                          
                        }

                        conn.Close();

                    }
                    else
                    {
                        MessageBox.Show("שם משתמש או סיסמה שגויים", "הודעה");
                    }
                }

            }
            else if(startProgram)
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

                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();

                if (dt.Rows.Count > 0)
                {

                    conn.Close();
                    ExtraTimeForm ex = new ExtraTimeForm();
                    ex.Show();
                    Hide();

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
           
        }

        private void UserID_textbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Pass_textbox_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (startProgram) { login_backBTN.Visible = true; }
        }

        private void login_backBTN_Click(object sender, EventArgs e)
        {
            Main_Screen ms = new Main_Screen();
            ms.Show();
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
    }
}
