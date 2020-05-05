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
    
    public partial class AdminForm : Form
    {
        
        public AdminForm()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            AdminNewExamForm admN = new AdminNewExamForm();
            admN.Show();
            Hide();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ButtonSearchExam_Click(object sender, EventArgs e)
        {
            AdminSearchForm admSearch = new AdminSearchForm();
            Hide();
            admSearch.Show();
        }

        private void ButtonAddProctor_Click(object sender, EventArgs e)
        {
            AddProctorForm addProctor = new AddProctorForm();
            Hide();
            addProctor.Show();
        }
    }
}
