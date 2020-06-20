using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace EasyTest_App.DB
{
    //singleton
    public class DBManager
    {
        public delegate void DBDelegate();
        public static event DBDelegate DBEvent;
        public static bool SetMadorReport(string type, string commentText)
        {

            try
            {
                string query = "INSERT INTO `exam_report` (`exam_report_id`, `exam_id`, `proctor_id`, `type`, `start`, `end`, `proctor_comment`, `admin_comment`, `class_num`, `status`) VALUES (NULL, @exam_id, @proctor_id, @type, @start, '', @comment, '', @class_num, 0)";
                MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@exam_id", Login.exam_table.Rows[0].ItemArray[0].ToString());
                cmd.Parameters.AddWithValue("@class_num", Login.exam_table.Rows[0].ItemArray[4].ToString());
                cmd.Parameters.AddWithValue("@proctor_id", Login.exam_table.Rows[0].ItemArray[1].ToString());
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@start", Main_Screen.getTime());
                cmd.Parameters.AddWithValue("@comment", commentText);
                cmd.ExecuteNonQuery();
                conn.Close();
                DBEvent?.Invoke();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static List<string> GetStudentName(int studentID)
        {
            List<string> list = new List<string>();
            string query = "Select first_name, last_name FROM student WHERE student_id = @studentID";
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@studentID", studentID);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            conn.Close();
            list.Add(dt.Rows[0][0].ToString());
            list.Add(dt.Rows[0][1].ToString());
            return  list;

        }
    }
}
