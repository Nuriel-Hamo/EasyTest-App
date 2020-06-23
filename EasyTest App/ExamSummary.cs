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


namespace EasyTest_App
{
    public partial class ExamSummary : Form
    {
        public ExamSummary()
        {
            InitializeComponent();
        }

        private void ExamSummary_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM `exam_summary`";
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            conn.Close();
            
            foreach (DataRow row in dt.Rows)
            {
                dataGridView.Rows.Add(row.ItemArray);
            }
           

        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            af.Show();
            Hide(); 
        }

       
    }
}
