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
       
      
        public Student_Information()
        {
            InitializeComponent(); 
        }

        private void Student_Information_Load(object sender, EventArgs e)
        {
          
            FirstNameAnsLABEL.Text = Add_Student.nameForInfo;
            IdAnsLABEL.Text = Add_Student.idForInfo;
            phoneANS.Text = "0" + Add_Student.phoneForInfo;
            mailANS.Text = Add_Student.emailForInfo;
            phoneANS.Visible = true;
            mailANS.Visible = true;
            FirstNameAnsLABEL.Visible = true;
            IdAnsLABEL.Visible = true;
         

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
