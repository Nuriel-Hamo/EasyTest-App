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
            return list;

        }
        public static void ExamSummary(string examTime, string subject, string lecturerName, string proctors, string extraTime, string studentNum)
        {
            string query = "INSERT INTO `exam_summary` (`Date`, `Time`, RealTime, `Subject`, `ClassNum`, `LecturerName`, `Proctors`, `ExtraTime`, `Reports`, `StudentNum`) " +
                "VALUES (@date, @time, @real_time, @subject, @clasNum, @lecturerName, @proctors, @extraTime, @Reports, @StudentNum)";
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@date", DateTime.Now);
            cmd.Parameters.AddWithValue("@time", Login.exam_table.Rows[0].ItemArray[7].ToString().Substring(0, 5) + " - " + Login.exam_table.Rows[0].ItemArray[6].ToString().Substring(0, 5));
            cmd.Parameters.AddWithValue("@real_time", examTime);
            cmd.Parameters.AddWithValue("@subject", subject);
            cmd.Parameters.AddWithValue("@clasNum", Login.exam_table.Rows[0].ItemArray[4].ToString());
            cmd.Parameters.AddWithValue("@lecturerName", lecturerName);
            cmd.Parameters.AddWithValue("@proctors", proctors);
            cmd.Parameters.AddWithValue("@extraTime", extraTime);
            cmd.Parameters.AddWithValue("@Reports", GeneralReports());
            cmd.Parameters.AddWithValue("@StudentNum", studentNum);



            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static string GeneralReports()
        {
            string query = "Select proctor_comment FROM exam_report WHERE exam_id = @exam_id";
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@exam_id", Login.exam_table.Rows[0].ItemArray[0].ToString());
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            conn.Close();
            string result = "";
            foreach (DataRow row in dt.Rows)
            {
                result += row[0].ToString() + ", ";
            }
            return result;

        }
        public static string TypOfUser(string userID)
        {

            string Query = "SELECT * FROM proctor WHERE proctor_id = @UserID_textbox";
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@UserID_textbox", userID);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();


            if (dt.Rows.Count > 0)
            {
                return "proctor";

            }

            ///////////////////////////////////////////////////////////////////////// otherwise
            ///

            string Query2 = "SELECT * FROM lecturer WHERE lecturer_id = @UserID";
            MySqlConnection conn2 = new MySqlConnection("server=localhost;user id=root;database=easytest");
            conn2.Open();

            MySqlCommand cmd2 = new MySqlCommand(Query2, conn2);
            cmd2.Parameters.AddWithValue("@UserID", userID);
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            conn2.Close();


            if (dt2.Rows.Count > 0)
            {
                return "lecturer";

            }

            return "null";
        }

        public static string GetCourseName(string courseID)
        {

            string Query = "SELECT course_name FROM course WHERE course_id = @courseID";
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@courseID", courseID);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt.Rows[0][0].ToString();
        }

    }
}
