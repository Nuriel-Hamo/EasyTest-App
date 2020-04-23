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
    public partial class Main_Screen : Form
    {
        int minutes = 0;
        int seconds = 0;
        //public static int coutEnters = 0;
        
        public Main_Screen()
        {
            InitializeComponent();
        }

        private void BeginExamBTN_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void AddStudentBTN_Click(object sender, EventArgs e)
        {
            Add_Student add_student_screen = new Add_Student();
            add_student_screen.Show();
            Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(seconds == 60)
            {
                minutes++;
                seconds = 0;
            }
            if (minutes < 10 && seconds < 10)
            {
                label1.Text = "0" + minutes + ":0" + seconds;
            }
            else if (minutes < 10 && seconds > 10)
                label1.Text = "0" + minutes + ":" + seconds;
            else
                label1.Text = minutes + ":" + seconds;
            seconds++;

        }

        private void Main_Screen_Load(object sender, EventArgs e)
        {
            /*
            if (coutEnters!=0)
            {
                button1.BackColor = Map_Screen.btn1.BackColor;
                button2.BackColor = Map_Screen.btn2.BackColor;
                button3.BackColor = Map_Screen.btn3.BackColor;
                button4.BackColor = Map_Screen.btn4.BackColor;
                button5.BackColor = Map_Screen.btn5.BackColor;
                button6.BackColor = Map_Screen.btn6.BackColor;
                button7.BackColor = Map_Screen.btn7.BackColor;
                button8.BackColor = Map_Screen.btn8.BackColor;
                button9.BackColor = Map_Screen.btn9.BackColor;

            }
            */
            

        }

        private void EndExamBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReportBTN_Click(object sender, EventArgs e)
        {

        }
        public void setName(string name)
        {
            labelName.Text = "Hello" + name;
        }

        private void ExtraTimeBTN_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            Hide();
        }
    }
}
