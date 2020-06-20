using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace EasyTest_App
{
    public partial class NoteBook_Num : Form
    {
        
        public NoteBook_Num()
        {
            InitializeComponent();
        }
        public static string notebookNum;
        private static bool firstTime = true;
        private void notebookBTN_Click(object sender, EventArgs e)
        {
            Regex obj = new Regex("[0-9]");
            if (!obj.IsMatch(notebook_TEXTBOX.Text))
            {
                MessageBox.Show("נא להזין מספר מחברת", "הודעה");
                
            }
            else
            {
                notebookNum = notebook_TEXTBOX.Text;
                Map_Screen map = new Map_Screen();
                map.Show();
                Hide();
            }
           
            
            notebook_TEXTBOX.Text = "מס' מחברת";
            firstTime = true;











            /*
            SQLiteConnection conn = new SQLiteConnection("Data Source=DB_OF_PROJECT.db;version=3;");
            conn.Open();
            
            SQLiteCommand cmd = new SQLiteCommand(conn);

            cmd.CommandText = "DROP TABLE IF EXISTS cars";
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"CREATE TABLE cars(id INTEGER PRIMARY KEY,
                    name TEXT, price INT)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Audi',52642)";
            cmd.ExecuteNonQuery();
            */












            //cmd.CommandText = "INSERT INTO exam_log (student_id, notebook_num) VALUES (227799, 7575260);";
            //cmd.CommandType = System.Data.CommandType.Text;

            //cmd.ExecuteNonQuery();
            //conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     
        private void notebookBTN_back_Click(object sender, EventArgs e)
        {
            firstTime = true;
            Student_Information st = new Student_Information();
            st.Show();
            Hide();
        }

        private void notebook_TEXTBOX_TextChanged(object sender, EventArgs e)
        {
           
          
        }

        private void notebook_TEXTBOX_MouseClick(object sender, MouseEventArgs e)
        {
            if(firstTime)
            {
                notebook_TEXTBOX.Text = "";
                firstTime = false;
            }
          
            
        }

        private void homeBTN_Click(object sender, EventArgs e)
        {
            Login.main_screen.Show();
            Hide();
        }
    }
}
