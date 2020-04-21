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

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            if(UserID_textbox.Text.Trim() == "" && Pass_textbox.Text.Trim() == "")
            {
                MessageBox.Show("יש להזין תוכן", "הודעה");
            }
            else
            {
               
                string Query = "SELECT * FROM users WHERE ID = @UserID_textbox AND Password = @Pass_textbox";
                MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(Query, conn);
                cmd.Parameters.AddWithValue("@UserID_textbox", UserID_textbox.Text);
                cmd.Parameters.AddWithValue("@Pass_textbox", Pass_textbox.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    
                   /* string fullName;
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        

                    }
                    */
                    Main_Screen main_screen = new Main_Screen();
                   // var info_for_list = fullName = rdr.GetString(1) + rdr.GetString(2);
                    conn.Close();
                    // main_screen.setName();
                    main_screen.Show();
                    Hide();
                    
                }
                else
                {
                    MessageBox.Show("שם משתמש או סיסמה שגויים", "הודעה");
                }
            }
            
            //AdminForm adm = new AdminForm();
            //adm.Show();
            //Hide();

        }

        private void LoginBTN_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void UserID_textbox_TextChanged(object sender, EventArgs e)
        {
            //if (!changed)
           // {
                //UserID_textbox.Text = "";
               // changed = true;
          //  }
        }

        private void Pass_textbox_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        
    }
}
