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
    public partial class StudentProfileForm : Form
    {
        public StudentProfileForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login.main_screen.Show();
            Hide();
        }

        private void StudentProfileForm_Load(object sender, EventArgs e)
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
            conn.Close();

            nameLBL.Text = dt2.Rows[0].ItemArray[1].ToString() + " " + dt2.Rows[0].ItemArray[2].ToString();
            idLBL.Text = dt2.Rows[0].ItemArray[0].ToString();
            scLBL.Text = dt2.Rows[0].ItemArray[5].ToString();
            tableBTN.Text = Main_Screen.send2profile;



        }
    }
}
