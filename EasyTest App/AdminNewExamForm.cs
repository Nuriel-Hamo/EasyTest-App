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
    public partial class AdminNewExamForm : Form
    {
        public AdminNewExamForm()
        {
            InitializeComponent();
        }

        private void TextBoxCourseCode_TextChanged(object sender, EventArgs e)
        {
            if(textBoxCourseCode.Text!="")
            {
                textBox_proctorID.Enabled = true;
                textBox_lecturerID.Enabled = true;
                textBox_exam_date.Enabled = true;
                textBox_start_hour.Enabled = true;
                textBox_end_hour.Enabled = true;
                button_reset.Enabled = true;
            }
        }
    }
}
