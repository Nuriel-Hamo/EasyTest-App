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
    public partial class Map_Screen : Form
    {
        public static string saveColor;
        public static Button btn1;
        public static Button btn2;
        public static Button btn3;
        public static Button btn4;
        public static Button btn5;
        public static Button btn6;
        public static Button btn7;
        public static Button btn8;
        public static Button btn9;
        public Map_Screen()
        {
            InitializeComponent();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TURNOFF();
            button1.BackColor = Color.Green;
            saveColor = button1.Name;
            //btn1.BackColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TURNOFF();
            button2.BackColor = Color.Green;
            //btn2.BackColor = Color.Green;
        }

        private void Map_Screen_Load(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            NoteBook_Num nb = new NoteBook_Num();
            nb.Show();
            Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Main_Screen.coutEnters++;
            Main_Screen ms = new Main_Screen();
            ms.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TURNOFF();
            button3.BackColor = Color.Green;
            //btn3.BackColor = Color.Green;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TURNOFF();
            button4.BackColor = Color.Green;
            //btn4.BackColor = Color.Green;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TURNOFF();
            button5.BackColor = Color.Green;
            //btn5.BackColor = Color.Green;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TURNOFF();
            button6.BackColor = Color.Green;
            //btn6.BackColor = Color.Green;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TURNOFF();
            button7.BackColor = Color.Green;
            //btn7.BackColor = Color.Green;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TURNOFF();
            button8.BackColor = Color.Green;
            //btn8.BackColor = Color.Green;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TURNOFF();
            button9.BackColor = Color.Green;
            //btn9.BackColor = Color.Green;
        }
        public void TURNOFF()
        {
            button1.BackColor = Color.Gray;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;
            button5.BackColor = Color.Gray;
            button6.BackColor = Color.Gray;
            button7.BackColor = Color.Gray;
            button8.BackColor = Color.Gray;
            button9.BackColor = Color.Gray;
            /*
            btn1.BackColor = Color.Gray;
            btn2.BackColor = Color.Gray;
            btn3.BackColor = Color.Gray;
            btn4.BackColor = Color.Gray;
            btn5.BackColor = Color.Gray;
            btn6.BackColor = Color.Gray;
            btn7.BackColor = Color.Gray;
            btn8.BackColor = Color.Gray;
            btn9.BackColor = Color.Gray;
            */
        }
    }
}
