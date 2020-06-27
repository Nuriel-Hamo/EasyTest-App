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

    

    public partial class ReportManagerForm : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        public delegate void ReportStatus(string StatusString, string Details);
        public static event ReportStatus StatusEvent;


        public ReportManagerForm()
        {
            InitializeComponent();
        }

       
        private void ReportManagerForm_Load(object sender, EventArgs e)
        {
            string Query1 = "SELECT * FROM exam_report WHERE status = '0'";
            conn.Open();
            MySqlCommand cmd1 = new MySqlCommand(Query1, conn);
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
            da1.Fill(dt1);
            conn.Close();

            foreach (DataRow dr in dt1.Rows)
            {
                listBox1.Items.Add(string.Format("{0}: {1} | {2}: {3} | {4}: {5}", "משתמש", dr["proctor_id"].ToString(),"מס' כיתה", dr["class_num"].ToString(), "פירוט התקלה", dr["proctor_comment"].ToString()));
                //listBox1.Items.Add("סוג: " + dr["type"].ToString());
                //listBox1.Items.Add("מס' כיתה: " + dr["class_num"].ToString());
                //listBox1.Items.Add("פירוט:" + dr["proctor_comment"].ToString());
                //listBox1.Items.Add("______________________________________________________");

            }

            string Query2 = "SELECT * FROM exam_report WHERE status = '1'";
            conn.Open();
            MySqlCommand cmd2 = new MySqlCommand(Query2, conn);
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            da2.Fill(dt2);
            conn.Close();

            foreach (DataRow dr in dt2.Rows)
            {
                listBox2.Items.Add(string.Format("{0}: {1} | {2}: {3} | {4}: {5}", "משתמש", dr["proctor_id"].ToString(), "מס' כיתה", dr["class_num"].ToString(), "פירוט התקלה", dr["proctor_comment"].ToString()));

            }

            string Query3 = "SELECT * FROM exam_report WHERE status = '2'";
            conn.Open();
            MySqlCommand cmd3 = new MySqlCommand(Query3, conn);
            MySqlDataAdapter da3 = new MySqlDataAdapter(cmd3);
            da3.Fill(dt3);
            conn.Close();

            foreach (DataRow dr in dt3.Rows)
            {
                listBox3.Items.Add(string.Format("{0}: {1} | {2}: {3} | {4}: {5}", "משתמש", dr["proctor_id"].ToString(), "מס' כיתה", dr["class_num"].ToString(), "פירוט התקלה", dr["proctor_comment"].ToString()));

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string ReportId = "";
                string text = listBox1.GetItemText(listBox1.SelectedItem);
                int indexInList = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(indexInList);
                listBox2.Items.Add(text);

                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    if (indexInList == i)
                    {
                        ReportId = dt1.Rows[i][0].ToString();
                        dt2.Rows.Add(dt1.Rows[i].ItemArray);
                        StatusEvent?.Invoke("בטיפול", dt1.Rows[i][6].ToString());
                        dt1.Rows.Remove(dt1.Rows[i]);
                        //dt2.NewRow(); //= dt1.Rows[i];

                    }
                }


                string query = "UPDATE `exam_report` SET status = '1' WHERE exam_report_id = @exam_report_id";
                MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@exam_report_id", ReportId);
                cmd.ExecuteNonQuery();

                conn.Close();


            }

        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                string ReportId = "";
                string text = listBox2.GetItemText(listBox2.SelectedItem);
                int indexInList = listBox2.SelectedIndex;
                listBox2.Items.RemoveAt(indexInList);
                listBox3.Items.Add(text);

                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    if (indexInList == i)
                    {
                        ReportId = dt2.Rows[i][0].ToString();
                        dt3.Rows.Add(dt2.Rows[i].ItemArray);
                        StatusEvent?.Invoke("טופל", dt2.Rows[i][6].ToString());
                        dt2.Rows.Remove(dt2.Rows[i]);                     
                        //dt2.NewRow(); //= dt1.Rows[i];

                    }
                }


                string query = "UPDATE `exam_report` SET status = '2' WHERE exam_report_id = @exam_report_id";
                MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@exam_report_id", ReportId);
                cmd.ExecuteNonQuery();

                conn.Close();
            }

        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            af.Show();
            Hide();
        }
    }
}
