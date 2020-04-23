using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EasyTest_App
{
    public partial class Student_Information : Form
    {
        class student_info
        {
            //public int id;
            public string fullName;
        }
      
        public Student_Information()
        {
            InitializeComponent(); 
        }

        private void Student_Information_Load(object sender, EventArgs e)
        {
            /*
            IdAnsLABEL.Text = Add_Student.SetValue;
            IdAnsLABEL.Visible = true;

            SQLiteConnection conn = new SQLiteConnection("Data Source=DB_OF_PROJECT.db;version=3;");
            conn.Open();

            string query = "SELECT full_name FROM examinee WHERE student_id = @IdAnsLABEL";

            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@IdAnsLABEL", IdAnsLABEL.Text);

            SQLiteDataReader rdr = cmd.ExecuteReader();

            List<student_info> InfoList = new List<student_info>();
            while(rdr.Read())
            {
                var info_for_list = new student_info() {fullName=rdr.GetString(0)};
                InfoList.Add(info_for_list);
            }
            FirstNameAnsLABEL.Text = InfoList[0].fullName.ToString();
            FirstNameAnsLABEL.Visible = true;
            conn.Close();
            */




        }

        private void IdAnsLABEL_Click(object sender, EventArgs e)
        {
            
        }

        private void nootbookBTN_Click(object sender, EventArgs e)
        {
            NoteBook_Num NBN = new NoteBook_Num();
            NBN.Show();
            Hide();
        }

        private void StudentInformation_backBTN_Click(object sender, EventArgs e)
        {
            Add_Student ast = new Add_Student();
            ast.Show();
            Hide();
            
        }
    }
}
