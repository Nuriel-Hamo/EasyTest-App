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
    
    public partial class AdminUpdateForm : Form
    {
        public static bool needUpd = false;
        public static string exam,proctor;
        public static DataTable UpdtadeDataTable;
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=easytest");
        public AdminUpdateForm()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Login.adminF.Show();
            Hide();
        }

        private void AdminUpdateForm_Load(object sender, EventArgs e)
        {
            
            labelTxt.Text=AdminForm.for_label;
            

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (AdminForm.send == "exam")
            {
                con.Open();
                string Query = "SELECT * FROM `exam` WHERE `exam`.`exam_id`=@textBoxExamID";
                MySqlCommand cmd = new MySqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@textBoxExamID", textBoxExamID.Text);
                UpdtadeDataTable = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(UpdtadeDataTable);
                if (UpdtadeDataTable.Rows.Count == 0)
                    MessageBox.Show("המבחן שהוזן אינו קיים");
                else
                {
                    exam = textBoxExamID.Text;
                    needUpd = true;
                    AdminNewExamForm adminNew = new AdminNewExamForm();
                    Hide();
                    Login.adminF.Hide();
                    adminNew.Show();

                }
                con.Close();
            }
            else if(AdminForm.send == "proctor")
            {
                con.Open();
                string Query = "SELECT * FROM `proctor` WHERE `proctor`.`proctor_id`=@textBoxExamID";
                MySqlCommand cmd = new MySqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@textBoxExamID", textBoxExamID.Text);
                UpdtadeDataTable = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(UpdtadeDataTable);
                if (UpdtadeDataTable.Rows.Count == 0)
                    MessageBox.Show("ת.ז שהוזנה אינה קיים");
                else
                {
                    proctor = textBoxExamID.Text;
                    needUpd = true;
                    AddProctorForm add= new AddProctorForm();
                    Hide();
                    Login.adminF.Hide();
                    add.Show();

                }
                con.Close();
            }
        }

        private void AdminUpdateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
