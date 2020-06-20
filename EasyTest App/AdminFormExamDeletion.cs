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
    public partial class AdminFormExamDeletion : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=easytest");
        public DataTable data= new DataTable();
        public AdminFormExamDeletion()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            
            AdminForm admin = new AdminForm();
            Hide();
            admin.Show();
        }

        private void AdminFormExamDeletion_Load(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.FromArgb(100, 0, 0, 0);

            dataE();
            con.Open();
            if (AdminForm.send == "exam")
            {

                string Query = "SELECT * FROM exam";
                MySqlCommand cmd = new MySqlCommand(Query, con);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    listBoxExams.Items.Add("מספר בחינה: " + dr["exam_id"].ToString() + " | קורס: " + getCourseName(dr["course_id"].ToString()) + " | בתאריך: " + dr["test_date"].ToString().Substring(0, 10) + "  | מועד:  " + ChangeMoed(dr["exam_period"].ToString()));
                }
            }
            if (AdminForm.send == "proctor")
            {

                string Query = "SELECT * FROM proctor";
                MySqlCommand cmd = new MySqlCommand(Query, con);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    listBoxExams.Items.Add("ת.ז משגיח: " + dr["proctor_id"].ToString() + " | שם : " + dr["first_name"].ToString() + " "+dr["last_name"].ToString());
                }

            }
            con.Close();
        }

        private void AdminFormExamDeletion_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private string ChangeMoed(string s)
        {
            if (s == "0")
                return "מועד א";
            if (s == "1")
                return "מועד ב";
            return "מועד מיוחד";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxExams.SelectedItem == null)
                MessageBox.Show("אנא בחר מבחן שברצונך למחוק", "שגיאה");
            else if (AdminForm.send == "exam")
            {
                if (MessageBox.Show("האם אתה בטוח שברצונך למחוק מבחן?", "אזהרה", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string[] s = listBoxExams.SelectedItem.ToString().Split('|');
                    string value = s[0].Substring(11);
                    con.Open();
                    string Query = "DELETE FROM `exam` WHERE `exam`.`exam_id` = @value";
                    MySqlCommand cmd = new MySqlCommand(Query, con);
                    cmd.Parameters.AddWithValue("@value", value);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("מבחן ב " + s[1].ToString() + " נמחק בהצלחה");
                    Hide();
                    AdminForm adm = new AdminForm();
                    adm.Show();
                }
            }
            else if (AdminForm.send == "proctor")
            {
                if (MessageBox.Show("האם אתה בטוח שברצונך למחוק משגיח?", "אזהרה", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string[] s = listBoxExams.SelectedItem.ToString().Split('|');
                    string value = s[0].Substring(10).Trim();
                    con.Open();
                    string Query = "DELETE FROM `proctor` WHERE `proctor`.`proctor_id` = @value";
                    MySqlCommand cmd = new MySqlCommand(Query, con);
                    cmd.Parameters.AddWithValue("@value", value);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("משגיח " + s[1].ToString() + " נמחק בהצלחה");
                    Hide();
                    AdminForm adm = new AdminForm();
                    adm.Show();
                }
            }
        }
       
        private void dataE()
        {
            if (AdminForm.send == "exam")
            {
                con.Open();

                string Query = "SELECT * FROM course";
                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(data);

                con.Close();
            }
            if(AdminForm.send=="proctor")
            {
                   con.Open();

                string Query = "SELECT * FROM course";
                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(data);

                con.Close();
            }

            
        }
        
        private string getCourseName(string courseID)
        {

            courseID = courseID.Substring(5).Trim(':');
                foreach (DataRow dr in data.Rows)
                {
                    if (dr["course_id"].ToString() == courseID.Trim())
                        return dr["course_name"].ToString();
                }
           
            return courseID;

        }

      
    }
}
