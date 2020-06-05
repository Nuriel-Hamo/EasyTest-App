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

        public static string extraTime1 = "";
        public static string extraTime2 = "";
        public ExtraTimeForm()
        {
            InitializeComponent();
        }
        private int count = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if(Radio1.Checked || Radio2.Checked)
            {
                string T = "0";
                if (Radio1.Checked)
                {
                    if (count == 1)
                    {
                        T = "00:30:00";
                    }
                    else
                    {
                        T = "00:15:00";
                    }

                }
                if (Radio2.Checked)
                {
                    T = "00:30:00";
                }


                string query = "UPDATE `examination_log` SET `extra_time` = @extra_time WHERE exam_id = @exam_id";

                MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@extra_time", T);
                cmd.Parameters.AddWithValue("@exam_id", Login.exam_table.Rows[0].ItemArray[0].ToString());
                int flg = cmd.ExecuteNonQuery();
                //MySqlDataReader dr = cmd.ExecuteReader();

                if (flg > 0)
                {


                    if (T.Equals("00:30:00"))
                    {
                        extraTime1 = T;
                        Radio1.Enabled = false;
                        Radio2.Enabled = false;
                        button1.Enabled = false;
                    }
                    if (T.Equals("00:15:00"))
                    {

                        count++;
                        if (count == 2)
                        {
                            extraTime2 = "00:15:00";
                            Radio1.Enabled = false;
                            button1.Enabled = false;
                        }
                        else if (count == 1)
                        {
                            extraTime1 = T;
                            Radio2.Enabled = false;
                        }

                    }
                    MessageBox.Show("הארכת זמן בוצעה בהצלחה", "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                conn.Close();


            }
            else
            {
                MessageBox.Show("נא לבחור זמן הארכה", "הערה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login.main_screen.Show();
            Hide();
        }

        private void ExtraTimeForm_Load(object sender, EventArgs e)
        {
            string Query = "SELECT extra_time FROM examination_log WHERE exam_id = @exam_id";
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(Query, conn);

            cmd.Parameters.AddWithValue("@exam_id", Login.exam_table.Rows[0].ItemArray[0].ToString());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString().Equals("00:30:00"))
            {
                Radio1.Enabled = false;
                Radio2.Enabled = false;
                button1.Enabled = false;
            }
            if (dt.Rows[0][0].ToString().Equals("00:15:00"))
            {
                Radio2.Enabled = false;
                count++;

            }






            conn.Close();
        }
    }
}
