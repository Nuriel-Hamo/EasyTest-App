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
    public partial class Student_Information : Form
    {
       
      
        public Student_Information()
        {
            InitializeComponent(); 
        }

        private void Student_Information_Load(object sender, EventArgs e)
        {
          
            FirstNameAnsLABEL.Text = Add_Student.student_table.Rows[0].ItemArray[1].ToString() + " " +
               Add_Student.student_table.Rows[0].ItemArray[2].ToString();
            IdAnsLABEL.Text = Add_Student.student_table.Rows[0].ItemArray[0].ToString();
            phoneANS.Text = "0" + Add_Student.student_table.Rows[0].ItemArray[4].ToString();
            mailANS.Text = Add_Student.student_table.Rows[0].ItemArray[3].ToString();
            scLABEL2.Text = Add_Student.student_table.Rows[0].ItemArray[5].ToString();
            phoneANS.Visible = true;
            scLABEL2.Visible = true;
            mailANS.Visible = true;
            FirstNameAnsLABEL.Visible = true;
            IdAnsLABEL.Visible = true;

            String selectQuery = "SELECT image FROM student WHERE student_id = '" + Add_Student.student_table.Rows[0].ItemArray[0].ToString() + "'";

            MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=easytest");
            MySqlCommand command;
            MySqlDataAdapter da;

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);

            //textBoxNAME.Text = table.Rows[0][1].ToString();
            //textBoxDESC.Text = table.Rows[0][2].ToString();

            byte[] img = (byte[])table.Rows[0][0];

            MemoryStream ms = new MemoryStream(img);

            pictureBox.Image = Image.FromStream(ms);

            da.Dispose();
            connection.Close();


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
