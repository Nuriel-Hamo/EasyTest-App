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
    public partial class ExtraTimeForm : Form
    {
        public ExtraTimeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* 
            string T = "0";
            if (Radio1.Checked)
            {
                T = "15";
            }
            if (Radio2.Checked)
            {
                T = "30";
            }
            */

            /*string query = "UPDATE `examination_log` SET `start_time` = @startTime WHERE exam_id = @exam_id";

            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@startTime", getTime());
            cmd.Parameters.AddWithValue("@exam_id", Login.exam_table.Rows[0].ItemArray[0].ToString());
            int flg = cmd.ExecuteNonQuery();
            //MySqlDataReader dr = cmd.ExecuteReader();

            if (flg > 0)
            {
                timer1.Enabled = true;
                timer1.Start();
                BeginExamBTN.Enabled = false;
            }
            else { MessageBox.Show("לא קיימים סטודנטים בבחינה", "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            conn.Close();*/
        }
    }
}
