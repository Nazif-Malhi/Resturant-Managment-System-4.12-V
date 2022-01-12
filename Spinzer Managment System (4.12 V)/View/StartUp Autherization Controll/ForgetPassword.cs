using Spinzer_Managment_System__4._12_V_.Model.Queries;
using Spinzer_Managment_System__4._12_V_.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spinzer_Managment_System__4._12_V_.View.StartUp_Autherization_Controll
{
    public partial class ForgetPassword : UserControl
    {
        UserViewModel userViewModel = new UserViewModel();
        int temp_Password;
        int id, remember;
        string Name, Email, phone, Address, Authenticated, Description;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
        public ForgetPassword()
        {
            InitializeComponent();
            for (int i = 0; i < userViewModel.fillingData(); i++)
            {
                mail_TextBox.Text = userViewModel.userModel.dataUser[0].Email;
                id = userViewModel.userModel.dataUser[0].Id;
                Name = userViewModel.userModel.dataUser[0].Name;
                Email = userViewModel.userModel.dataUser[0].Email;
                phone = userViewModel.userModel.dataUser[0].Phone;
                Address = userViewModel.userModel.dataUser[0].Address;
                Authenticated = userViewModel.userModel.dataUser[0].Authentication;
                Description = userViewModel.userModel.dataUser[0].Description;
                remember = userViewModel.userModel.dataUser[0].Remember;
            }
        }

        
        private void sendReqxt_PictureBox_Click(object sender, EventArgs e)
        {
            
            string to, from, passwordOfSender;
            to = mail_TextBox.Text;
            from = ("*****.com");
            Random rnd = new Random();
            temp_Password = rnd.Next(00000, 99999);
            
            passwordOfSender = "*****";
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(to);
            mailMessage.From = new MailAddress(from);
            mailMessage.Body = createBody();
            mailMessage.IsBodyHtml = true;
            mailMessage.Subject = "Recovery of Password";
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(from, passwordOfSender);
            try
            {

                smtpClient.Send(mailMessage);
                MessageBox.Show("Temproray Password Send Successfully to " + to, "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updating();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail is Not send to \n" + to + "\nDue to following Exception\n" + ex.Message, "Recovery Password mail is Not send !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string createBody() {
            string body = string.Empty;
            using (StreamReader stream = new StreamReader(@"D:\Users\Nazif\source\repos\Spinzer Managment System (4.12 V) - Copy\Spinzer Managment System (4.12 V)\Spinzer Managment System (4.12 V)\ExtraModulesCode\MailBody\EmailTemplate.html"))
            {
                body = stream.ReadToEnd();
            }
            body = body.Replace("{ResetPassword}", temp_Password.ToString());
            body = body.Replace("{Name}", Name);
            return body;
        }
        private void updating() {
            Update update = new Update();
            update.UpdateUser(id, Name, Email, phone, temp_Password.ToString(), Address, Authenticated, Description, remember);
        }

    }
}
