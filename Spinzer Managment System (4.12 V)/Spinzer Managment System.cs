using Spinzer_Managment_System__4._12_V_.Model;
using Spinzer_Managment_System__4._12_V_.Model.Queries;
using Spinzer_Managment_System__4._12_V_.View.Grid.Base;
using Spinzer_Managment_System__4._12_V_.View.MainControll;
using Spinzer_Managment_System__4._12_V_.View.StartUp_Autherization_Controll;
using Spinzer_Managment_System__4._12_V_.View.SubMenue;
using Spinzer_Managment_System__4._12_V_.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spinzer_Managment_System__4._12_V_
{
    public partial class Spinzer : Form
    {
        
        private LogIn logIn;
        private SignUp signUp;
        private ForgetPassword forgetPassword;
        private Main main;
        private Order order;
        private UserViewModel userViewModel;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
        public Spinzer()
        {
            logIn = new LogIn();
            signUp = new SignUp();
            forgetPassword = new ForgetPassword();
            main = new Main();
            order = new Order();
           

            InitializeComponent();
            loadingControls();

            logIn.logIn_PictureBox.Click += LogIn_PictureBox_Click;
            logIn.signUp_pictureBox.Click += SignUp_pictureBox_Click;
            logIn.forgetPassword_PictureBox.Click += ForgetPassword_PictureBox_Click;
            signUp.signInAlreadyAccount_PictureBox.Click += SignInAlreadyAccount_PictureBox_Click;
            signUp.signUp_PictureBox.Click += SignUp_PictureBox_Click;
            forgetPassword.logIn_Label.Click += LogIn_Label_Click;
            main.orders_PictureBox.Click += Orders_PictureBox_Click;
            order.back_PictureBox.Click += Back_PictureBox_Click;
        }

      

        private void SignUp_PictureBox_Click(object sender, EventArgs e)
        {
            if (signUp.checkBox1.Checked)
            {
                if (signUp.signUpMethodCallFromMain() < 0) {
                    signUp.SendToBack();
                    logIn.BringToFront();
                }
            }
            else {
                MessageBox.Show("Please check Liscence and agreement");
            }
        }

        #region ClickEvents
        private void LogIn_PictureBox_Click(object sender, EventArgs e)
        {
            userViewModel = new UserViewModel();
            Update update = new Update();
            if (logIn.UserName_TextBox.Text == ""||logIn.UserName_TextBox.Text=="UserName") {
                logIn.userNameError_Label.Text = "User Name is Empty";
                logIn.userNameError_Label.Visible = true;
            }
            if (logIn.password_textBox.Text == "" || logIn.password_textBox.Text == "Password")
            {
                logIn.passwordError_Label.Text = "Password is Empty";
                logIn.passwordError_Label.Visible = true;
            }
            else
            {
                int length = userViewModel.fillingData();
                bool containLock = false;
                int index = -1;
                for (int i = 0; i < length; i++)
                {
                    if (userViewModel.userModel.dataUser[i].Name.Contains(logIn.UserName_TextBox.Text)) {
                        containLock = true;
                        index = i;
                    }
                }
                if (containLock)
                {
                    if (userViewModel.userModel.dataUser[index].Password == logIn.password_textBox.Text)
                    {
                        for (int i = 0; i < length; i++)
                        {
                            if (logIn.rememberLock)
                            {
                                if (userViewModel.userModel.dataUser[i].Name == logIn.UserName_TextBox.Text && userViewModel.userModel.dataUser[i].Password == logIn.password_textBox.Text)
                                {
                                    update.UpdateUser(userViewModel.userModel.dataUser[i].Id, userViewModel.userModel.dataUser[i].Name, userViewModel.userModel.dataUser[i].Email, userViewModel.userModel.dataUser[i].Phone, userViewModel.userModel.dataUser[i].Password, userViewModel.userModel.dataUser[i].Address, userViewModel.userModel.dataUser[i].Authentication, userViewModel.userModel.dataUser[i].Description, 1);
                                }
                                else
                                {
                                    update.UpdateUser(userViewModel.userModel.dataUser[i].Id, userViewModel.userModel.dataUser[i].Name, userViewModel.userModel.dataUser[i].Email, userViewModel.userModel.dataUser[i].Phone, userViewModel.userModel.dataUser[i].Password, userViewModel.userModel.dataUser[i].Address, userViewModel.userModel.dataUser[i].Authentication, userViewModel.userModel.dataUser[i].Description, 0);
                                }
                            }
                            else
                            {
                                update.UpdateUser(userViewModel.userModel.dataUser[i].Id, userViewModel.userModel.dataUser[i].Name, userViewModel.userModel.dataUser[i].Email, userViewModel.userModel.dataUser[i].Phone, userViewModel.userModel.dataUser[i].Password, userViewModel.userModel.dataUser[i].Address, userViewModel.userModel.dataUser[i].Authentication, userViewModel.userModel.dataUser[i].Description, 0);
                            }
                            logIn.Dispose();
                            signUp.Dispose();
                            forgetPassword.Dispose();
                            main.BringToFront();
                            //main.auth_Button.Text = logIn.authRoll;
                            main.auth_Button.Text = userViewModel.userModel.dataUser[index].Authentication;
                            main.id_Label.Text = userViewModel.userModel.dataUser[index].Id.ToString();
                            Global.userId = userViewModel.userModel.dataUser[index].Id;
                        }
                    }
                    else
                    {
                        logIn.passwordError_Label.Visible = true;
                    }
                    containLock = false;
                    index = -1;
                }
                else if (!containLock) {
                    logIn.userNameError_Label.Visible = true;
                }
            }
        }
        private void SignUp_pictureBox_Click(object sender, EventArgs e)
        {
            userViewModel = new UserViewModel();
            if (userViewModel.fillingData() > 0)
            {
                MessageBox.Show("Already an Account Please Contact for vendor for more querry");
            }
            else {
                signUp.BringToFront();
            }
          

        }
        private void ForgetPassword_PictureBox_Click(object sender, EventArgs e)
        {
                forgetPassword.BringToFront();
        }
        private void SignInAlreadyAccount_PictureBox_Click(object sender, EventArgs e)
        {
            logIn.BringToFront();
        }
        private void LogIn_Label_Click(object sender, EventArgs e)
        {
            logIn.BringToFront();
        }
        private void Orders_PictureBox_Click(object sender, EventArgs e)
        {

            logIn.Dispose();
            signUp.Dispose();
            forgetPassword.Dispose();

            main.Hide();
            order.Show();
            order.Refresh();
            order.BringToFront();
            order.mainFormToOrderFormLock = true;
        }
        private void Back_PictureBox_Click(object sender, EventArgs e)
        {
            order.Hide();
            order.mainFormToOrderFormLock = false;
            main.Show();
            main.BringToFront();
        }
        #endregion

        #region LoadingControls
        private void loadingControls()
        {
            userViewModel = new UserViewModel();
            this.Controls.Add(logIn);
            logIn.Location = new Point(0, 0);
            
            this.Controls.Add(signUp);
            signUp.Location = new Point(0, 0);
           

            this.Controls.Add(forgetPassword);
            forgetPassword.Location = new Point(0, 0);
            forgetPassword.SendToBack();

            this.Controls.Add(main);
            main.Location = new Point(0, 0);
            main.SendToBack();

            this.Controls.Add(order);
            order.Location = new Point(0, 0);
            order.SendToBack();

            if (userViewModel.fillingData() == 0)
            {
                signUp.BringToFront();
                logIn.SendToBack();
            }
            else {
                logIn.BringToFront();
                signUp.SendToBack();
            }
        }
        #endregion

        private void Spinzer_KeyDown(object sender, KeyEventArgs e)
        {
          
        }
    }
}
