using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EasyTest_App
{
    
    public partial class AddProctorForm : Form
    {
        
        Regex rx = new Regex("^\\d{9}$");
        Regex rxPhone = new Regex("^[0][5][0-9]{8}$");
        public AddProctorForm()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Login.adminF.Show();
            Hide();
        }

        private void textBoxID_Leave(object sender, EventArgs e)
        {
            if (textBoxID.Text == "" || buttonBack.Focused)
                ;                
            else if (ProctorExist() && buttonAdd.Text=="הוסף")
            {
                MessageBox.Show("המשגיח כבר קיים במערכת", "שגיאה");
                textBoxID.Focus();
            }

            else if (!rx.IsMatch(textBoxID.Text))
            {
                MessageBox.Show("אנא הזן ת.ז בת 9 ספרות כולל ספרת ביקורת", "שגיאה");
                textBoxID.Focus();
            }
            
        }
        private Boolean ProctorExist()
        {
            string Query = "SELECT proctor_id FROM proctor WHERE proctor_id = @textBoxID";
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=easytest");
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@textBoxID", textBoxID.Text);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
                return false;
            else
                return true;
        }

        private void AddProctorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void textBoxPhoneNum_Leave(object sender, EventArgs e)
        {
            if (textBoxPhoneNum.Text == "" || buttonBack.Focused)
                ;
            else if (!rxPhone.IsMatch(textBoxPhoneNum.Text))
            {
                MessageBox.Show("אנא הזן מספר טלפון תקין בעל 10 ספרות ", "שגיאה");
                textBoxPhoneNum.Focus();
            }
        }
        private Boolean IsOK()
        {
            if (textBoxID.Text != "" && textBoxPass.Text != "" && textBoxFName.Text != "" && textBoxLName.Text != "" && textBoxPhoneNum.Text != ""&&comboBox1.SelectedItem!=null)
                return true;
            else
                return false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (buttonAdd.Text == "הוסף")
            {
                if (IsOK())
                {
                    string addExamQuery = "INSERT INTO `proctor` (`proctor_id`, `proctor_pass`, `first_name`, `last_name`, `phone_num`, `type`) VALUES (@textBoxID, @textBoxPass, @textBoxFName, @textBoxLName,@textBoxPhoneNum, @comboBox1)";
                    MySqlConnection con2 = new MySqlConnection("server=localhost;user id=root;database=easytest");
                    con2.Open();
                    MySqlCommand cmd = new MySqlCommand(addExamQuery, con2);



                    cmd.Parameters.AddWithValue("@textBoxID", textBoxID.Text);
                    cmd.Parameters.AddWithValue("@textBoxPass", textBoxPass.Text);
                    cmd.Parameters.AddWithValue("@textBoxFName", textBoxFName.Text);
                    cmd.Parameters.AddWithValue("@textBoxLName", textBoxLName.Text);
                    cmd.Parameters.AddWithValue("@textBoxPhoneNum", textBoxPhoneNum.Text);
                    cmd.Parameters.AddWithValue("@comboBox1", TypeConvertor());


                    cmd.ExecuteNonQuery();

                    con2.Close();
                    MessageBox.Show("משגיח הוזן בהצלחה", "הודעת מערכת");
                }
                else
                    ErrorMsgs();
            }
            if(buttonAdd.Text == "עדכן")
            {
                if(IsOK())
                {
                    string addExamQuery = "UPDATE `proctor` SET `proctor_id` = @textBoxID, `proctor_pass` = @textBoxPass, `first_name` = @textBoxFName, `last_name` = @textBoxLName,`phone_num` = @textBoxPhoneNum, `type` = @comboBox1 WHERE `proctor`.`proctor_id` = @textBoxID";
                    MySqlConnection con2 = new MySqlConnection("server=localhost;user id=root;database=easytest");
                    con2.Open();
                    MySqlCommand cmd = new MySqlCommand(addExamQuery, con2);



                    cmd.Parameters.AddWithValue("@textBoxID", textBoxID.Text);
                    cmd.Parameters.AddWithValue("@textBoxPass", textBoxPass.Text);
                    cmd.Parameters.AddWithValue("@textBoxFName", textBoxFName.Text);
                    cmd.Parameters.AddWithValue("@textBoxLName", textBoxLName.Text);
                    cmd.Parameters.AddWithValue("@textBoxPhoneNum", textBoxPhoneNum.Text);
                    cmd.Parameters.AddWithValue("@comboBox1", TypeConvertor());
                    
                    cmd.ExecuteNonQuery();

                    con2.Close();


                    MessageBox.Show("משגיח עודכן בהצלחה");

                    Hide();
                    Login.adminF.Show();
                }    
            }
        }
        private string TypeConvertor()
        {
            if (comboBox1.SelectedItem.ToString().Equals("מנהל מערכת"))
                return "1";
            return "0";
            

        }
        private void ErrorMsgs()
        {
            if (textBoxID.Text == "")
                errorProviderID.SetError(textBoxID, "אנא הזן ת.ז");
            else
                errorProviderID.Clear();
            if (textBoxPass.Text == "")
                errorProviderPass.SetError(textBoxPass, "אנא הזן סיסמא");
            else
                errorProviderPass.Clear();
            if (textBoxFName.Text == "")
                errorProviderFName.SetError(textBoxFName, "אנא הזן שם פרטי");
            else
                errorProviderFName.Clear();
            if (textBoxLName.Text == "")
                errorProviderLName.SetError(textBoxLName, "אנא הזן שם משפחה");
            else
                errorProviderLName.Clear();
            if (textBoxPhoneNum.Text == "")
                errorProviderPhoneNum.SetError(textBoxPhoneNum, "אנא הזן מספר טלפון");
            else
                errorProviderPhoneNum.Clear();
            if (comboBox1.SelectedItem == null)
                errorProviderType.SetError(comboBox1, "אנא בחר סוג");
            else
                errorProviderType.Clear();

        }

        private void AddProctorForm_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            label6.BackColor = Color.FromArgb(0, 0, 0, 0);
            label7.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            if (AdminUpdateForm.needUpd)
            {
                label1.Text = "עדכון משגיח בחינה";
                buttonAdd.Text = "עדכן";
                foreach (DataRow dr in AdminUpdateForm.UpdtadeDataTable.Rows)
                {
                    textBoxID.Text = dr["proctor_id"].ToString();
                    textBoxPass.Text = dr["proctor_pass"].ToString();
                    textBoxFName.Text = dr["first_name"].ToString();
                    textBoxLName.Text = dr["last_name"].ToString();
                    textBoxPhoneNum.Text = dr["phone_num"].ToString();
                    comboBox1.Text = WhichType(dr["type"].ToString()); 
                    
                }
                AdminUpdateForm.needUpd = false;
            }
        }
        private string WhichType(string str)
        {
            if (str == "0")
                return "משגיח בחינה";
            return "מנהל מערכת";
        }

    }
}
