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
using System.Net.Mail;
using System.Net;

namespace EasyTest_App
{
    public partial class StudentProfileForm : Form
    {
        DataTable student_table = new DataTable();
        DataTable examination_log_table = new DataTable();






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
            string query = "SELECT * FROM examination_log WHERE table_num = @table_num";

            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@table_num", Main_Screen.send2profile);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(examination_log_table);
            string result = examination_log_table.Rows[0].ItemArray[1].ToString();

            string query2 = "SELECT * FROM student WHERE student_id = @result";

            MySqlCommand cmd2 = new MySqlCommand(query2, conn);
            cmd2.Parameters.AddWithValue("@result", result);

            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            da2.Fill(student_table);
            //conn.Close();
            String selectQuery = "SELECT image FROM student WHERE student_id = '" + student_table.Rows[0].ItemArray[0].ToString() + "'";

            MySqlCommand command;
            MySqlDataAdapter da3;

            command = new MySqlCommand(selectQuery, conn);

            da3 = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da3.Fill(table);

            byte[] img = (byte[])table.Rows[0][0];

            MemoryStream ms = new MemoryStream(img);

            pictureBox1.Image = Image.FromStream(ms);

            da3.Dispose();
            conn.Close();


            nameLBL.Text = student_table.Rows[0].ItemArray[1].ToString() + " " + student_table.Rows[0].ItemArray[2].ToString();
            idLBL.Text = student_table.Rows[0].ItemArray[0].ToString();
            scLBL.Text = student_table.Rows[0].ItemArray[5].ToString();
            tableBTN.Text = Main_Screen.send2profile;



        }

        private void nootbookBTN_Click(object sender, EventArgs e)
        {

            ReportForm RF = new ReportForm();
            RF.Show();
            Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Main_Screen.log_table.Rows[0][12].ToString().Equals("00:00:00"))
            {
                int startHour = Main_Screen.GetHoures(Main_Screen.log_table.Rows[0][12].ToString(), Main_Screen.getTime());
                int startMinutes = Main_Screen.GetMinutes(Main_Screen.log_table.Rows[0][12].ToString(), Main_Screen.getTime());
                if (startHour >= 1 || startMinutes >= 30)
                {
                    string query = "UPDATE `examination_log` SET `end_time` = @endTime WHERE exam_id = @exam_id AND student_id = @student_id";

                    MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@endTime", Main_Screen.getTime());
                    cmd.Parameters.AddWithValue("@exam_id", Login.exam_table.Rows[0].ItemArray[0].ToString());
                    cmd.Parameters.AddWithValue("@student_id", idLBL.Text);

                    int flg = cmd.ExecuteNonQuery();
                    //MySqlDataReader dr = cmd.ExecuteReader();
                    conn.Close();
                    if (flg > 0)
                    {

                        Main_Screen.tableForIcone = tableBTN.Text;
                        Main_Screen.typeForIcone = "finish";
                        Main_Screen.newFinished = true;
                        MessageBox.Show("סטודנט הגיש בחינה");


                        string query4 = "SELECT course_name FROM course WHERE course_id = @courseId";

                        MySqlConnection conn4 = new MySqlConnection("server=localhost;user id=root;database=easytest");
                        conn4.Open();

                        MySqlCommand cmd4 = new MySqlCommand(query4, conn4);
                        cmd4.Parameters.AddWithValue("@courseId", Login.exam_table.Rows[0][3].ToString());

                        MySqlDataAdapter da4 = new MySqlDataAdapter(cmd4);
                        DataTable dt4 = new DataTable();
                        da4.Fill(dt4);

                        try
                        {
                            SmtpClient clientDetails = new SmtpClient();
                            clientDetails.Port = 587;
                            clientDetails.Host = "smtp.gmail.com";
                            clientDetails.EnableSsl = true;
                            clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                            clientDetails.UseDefaultCredentials = false;
                            clientDetails.Credentials = new NetworkCredential("finalprojectachva@gmail.com", "Project1234");

                            MailMessage mailDetails = new MailMessage();
                            mailDetails.From = new MailAddress("finalprojectachva@gmail.com");
                            mailDetails.To.Add(student_table.Rows[0][3].ToString());
                            mailDetails.Subject = nameLBL.Text + " להלן פרטי הבחינה  בקורס " + dt4.Rows[0][0].ToString();
                            mailDetails.IsBodyHtml = false;
                            mailDetails.Body = " הודעה אטומטית ממערכת EasyTest:" + " מספר מחברת - " + examination_log_table.Rows[0][7].ToString();
                            clientDetails.Send(mailDetails);
                            MessageBox.Show("מייל נשלח בהצלחה", "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conn4.Close();

                        }
                        catch
                        {
                            MessageBox.Show("שגיאה בשליחת מייל", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }


                }
                else
                {
                    MessageBox.Show("ניתן להגיש בחינה רק לאחר חצי שעה");
                }

            }
            else
            {
                MessageBox.Show("ניתן להגיש בחינה רק לאחר חצי שעה");
            }



        }
    }
}