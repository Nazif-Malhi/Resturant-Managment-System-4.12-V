using Spinzer_Managment_System__4._12_V_.Model.Queries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spinzer_Managment_System__4._12_V_.View.StartUp_Autherization_Controll
{
    public partial class SignUp : UserControl
    {
       
        
        public SignUp()
        {
            InitializeComponent();
            confrimPassword_TextBox.Enabled = false;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
        private void userName_TextBox_Click(object sender, EventArgs e)
        {
            userName_TextBox.Text = "";
            userName_TextBox.ForeColor = Color.Black;
        }

        private void mail_TextBox_Click(object sender, EventArgs e)
        {
            mail_TextBox.Text = "";
            mail_TextBox.ForeColor = Color.Black;
        }

        private void password_TextBox_Click(object sender, EventArgs e)
        {
            password_TextBox.Text = "";
            password_TextBox.PasswordChar = Convert.ToChar('*');
            password_TextBox.ForeColor = Color.Black;
            confrimPassword_TextBox.Enabled = true;

        }

        private void confrimPassword_TextBox_Click(object sender, EventArgs e)
        {
            confrimPassword_TextBox.Text = "";
            confrimPassword_TextBox.PasswordChar = Convert.ToChar('*');
            confrimPassword_TextBox.ForeColor = Color.Black;
        }
      

        private void phone_TextBox_Click(object sender, EventArgs e)
        {
            phone_TextBox.Text = "";
            phone_TextBox.ForeColor = Color.Black;
        }

        private void address_TextBox_Click(object sender, EventArgs e)
        {
            
            address_TextBox.Text = "";
            address_TextBox.ForeColor = Color.Black;
        }

        private void termAndCondition_PictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You should be sign the printed Agreement");
        }

        public int signUpMethodCallFromMain()
        {
            int result = 0;

                if (userName_TextBox.Text == "" || userName_TextBox.Text == "User Name")
                {
                    userError_Label.Visible = true;
                result++;
                }
                else
                {
                    userError_Label.Visible = false;
                result--;
                }
                if (phone_TextBox.Text == "" || phone_TextBox.Text == "Phone")
                {
                    phoneError_Label.Visible = true;
                result++;
                }
                else
                {
                    phoneError_Label.Visible = false;
                result--;
                }
                if (address_TextBox.Text == "" || address_TextBox.Text == "Address")
                {
                    addressError_Label.Visible = true;
                result++;
                }
                else
                {
                    addressError_Label.Visible = false;
                result--;
                }
                if (mail_TextBox.Text == "" || mail_TextBox.Text == "Email @ Account .Com")
                {
                    emailError_Label.Visible = true;
                result++;
                }
                else
                {
                    emailError_Label.Visible = false;
                result--;
                }
                if (password_TextBox.Text == "" || password_TextBox.Text == "Password")
                {
                    passwrdError_Label.Visible = true;
                result++;
                }
                else
                {
                    passwrdError_Label.Visible = false;
                result--;
                }
                if (confrimPassword_TextBox.Text == "" || confrimPassword_TextBox.Text == "Phone")
                {
                    cnfirmError_Label.Visible = true;
                result++;
                }
                else
                {
                    cnfirmError_Label.Visible = false;
                result--;
                }
                if (confrimPassword_TextBox.Text != password_TextBox.Text)
                {
                    passwrdError_Label.Visible = true;
                    cnfirmError_Label.Visible = true;
                    passwrdError_Label.Text = "Not Mathced";
                    cnfirmError_Label.Text = "Not Matched";
                result++;
                }
                else
                {
                    cnfirmError_Label.Visible = false;
                    passwrdError_Label.Visible = false;
                    passwrdError_Label.Text = "!";
                    cnfirmError_Label.Text = "!";
                result--;
                }
            if (userError_Label.Visible != true || phoneError_Label.Visible != true || addressError_Label.Visible != true || emailError_Label.Visible != true || passwrdError_Label.Visible != true || cnfirmError_Label.Visible != true) {
                Insert insert = new Insert();
                insert.InsertUser(userName_TextBox.Text, mail_TextBox.Text, phone_TextBox.Text, password_TextBox.Text, address_TextBox.Text, "Full", "", 0);
            }
            return result;
           
        }
        private void signUp_PictureBox_Click(object sender, EventArgs e)
        {
            
           
        }
    }
}
