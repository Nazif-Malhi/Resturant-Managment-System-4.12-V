using Spinzer_Managment_System__4._12_V_.Model;
using Spinzer_Managment_System__4._12_V_.Model.Queries;
using Spinzer_Managment_System__4._12_V_.View.MainControll;
using Spinzer_Managment_System__4._12_V_.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spinzer_Managment_System__4._12_V_.View.StartUp_Autherization_Controll
{
    public partial class LogIn : UserControl
    {
        UserViewModel userViewModel = new UserViewModel();
        private bool lockState = false;
        public bool rememberLock = false;
        public string authRoll = "";
        public int UserID = -1;

        public LogIn()
        {

            InitializeComponent();

         
            for (int i = 0; i < userViewModel.fillingData(); i++)
            {
                if (userViewModel.userModel.dataUser[i].Remember == 1) {
                    this.BackgroundImage = Properties.Resources.Sign_in_page_remember;
                    UserName_TextBox.Text = userViewModel.userModel.dataUser[i].Name;
                    password_textBox.Text = userViewModel.userModel.dataUser[i].Password;
                    authRoll = userViewModel.userModel.dataUser[i].Authentication;
                    UserID = userViewModel.userModel.dataUser[i].Id;
                    rememberLock = true;
                }
                
            }
           
         
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

        private void rememberMe_PictureBox_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            if (!rememberLock)
            {
                this.BackgroundImage = Properties.Resources.Sign_in_page_remember;
                rememberLock = true;
               
               
            }
            else
            {
                this.BackgroundImage = Properties.Resources.Sign_in_page;
                rememberLock = false;
            }

        }

      


        #region TextBox Properties
        private void UserName_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            resetingUsersTextBox();
        }

        private void password_textBox_MouseClick(object sender, MouseEventArgs e)
        {
            resetingPasswordTextBox();
        }

        private void UserName_TextBox_TextChanged(object sender, EventArgs e)
        {
            userNameError_Label.Text = "User Name not matched";
        }

        private void password_textBox_TextChanged(object sender, EventArgs e)
        {
            
            passwordError_Label.Text = "Password not matched";
        }
        #endregion

        #region Reseting User and Pass TextBox
        private void resetingUsersTextBox()
        {

            UserName_TextBox.Text = "";
            UserName_TextBox.ForeColor = Color.Black;
            lockState = true;
            userNameError_Label.Visible = false;
        }
        private void resetingPasswordTextBox()
        {
            password_textBox.Text = "";
            password_textBox.ForeColor = Color.Black;
            lockState = true;
            passwordError_Label.Visible = false;
        }


        #endregion
    }
}
