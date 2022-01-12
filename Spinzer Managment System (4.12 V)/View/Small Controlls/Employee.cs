using Spinzer_Managment_System__4._12_V_.ExternalResoursces.QRCode;
using Spinzer_Managment_System__4._12_V_.ExtraModulesCode.RoundRectForms;
using Spinzer_Managment_System__4._12_V_.Model.Queries;
using Spinzer_Managment_System__4._12_V_.View.MainControll;
using Spinzer_Managment_System__4._12_V_.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spinzer_Managment_System__4._12_V_.View.Small_Controlls
{
    public partial class Employee : Form
    {
        private RoundRectForm roundRectForm = new RoundRectForm();
        private bool updateSwitch = false;
        private int idToBeUpdated;
        private EmployeeViewModel employeeViewModel = new EmployeeViewModel();
        private QR_Code qR_Code = new QR_Code();

        public Employee()
        {
            InitializeComponent();
            roundRectForm.addingRegionForm(this);
            DateTime dateAndTime = DateTime.Now;
            DOJ_TextBox.Text = dateAndTime.ToString("yyyy-MM-dd");
        }
        public Employee(bool updateSwitch,int idToBeUpdated)
        {
            InitializeComponent();
            roundRectForm.addingRegionForm(this);
            DateTime dateAndTime = DateTime.Now;
            DOJ_TextBox.Text = dateAndTime.ToString("yyyy-MM-dd");
            this.updateSwitch = updateSwitch;
            this.idToBeUpdated = idToBeUpdated;
            update();
        }

        private void close_PictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancel_PictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_PictureBox_Click(object sender, EventArgs e)
        {
            if (name_TextBox.Text == "")
            {
                nameErrorlabel.Visible = true;
            }
            else {
                nameErrorlabel.Visible = false;
            }
            if (DOJ_TextBox.Text == "")
            {
                datelabel.Visible = true;
            }
            else {
                datelabel.Visible = false;
            }
            if (salary_TextBox.Text == "")
            {
                salary_ErrorLabel.Visible = true;
            }
            else {
                salary_ErrorLabel.Visible = false;
            }
            if (datelabel.Visible == false && nameErrorlabel.Visible == false && salary_ErrorLabel.Visible==false) {

                if (!updateSwitch)
                {
                    Insert insert = new Insert();
                    insert.InsertEmployee(name_TextBox.Text, email_TextBox.Text, phone_TextBox.Text, address_TextBox.Text, DOJ_TextBox.Text, name_TextBox.Text, Global.userId,Convert.ToInt32(salary_TextBox.Text));
                    MessageBox.Show(name_TextBox.Text + " Employee has been saved");
                }
                else {
                    Update update = new Update();
                    update.UpdateEmployee(idToBeUpdated, name_TextBox.Text, email_TextBox.Text, phone_TextBox.Text, address_TextBox.Text, DOJ_TextBox.Text, name_TextBox.Text, Global.userId, Convert.ToInt32(salary_TextBox.Text));
                }
               
                name_TextBox.Text = "";
                email_TextBox.Text = "";
                phone_TextBox.Text = "";
                address_TextBox.Text = "";
                DOJ_TextBox.Text = "";
                salary_TextBox.Text = "";
                pictureBox1.Image = null;
                name_TextBox.Focus();
                DateTime dateAndTime = DateTime.Now;
                DOJ_TextBox.Text = dateAndTime.ToString("yyyy-MM-dd");

            }
        }

        private void name_TextBox_TextChanged(object sender, EventArgs e)
        {
           
            pictureBox1.Image= qR_Code.encode(name_TextBox.Text);
        }
        private void update() {
            int length = employeeViewModel.fillingData();
            foreach (var item in employeeViewModel.dataToEmployeeModel.dataEmployee)
            {
                if (item.ID.Equals(idToBeUpdated)) {
                    name_TextBox.Text = item.Name;
                    email_TextBox.Text = item.Email;
                    phone_TextBox.Text = item.Phone;
                    address_TextBox.Text = item.Address;
                    DOJ_TextBox.Text = item.DateOfJoining;
                    salary_TextBox.Text = "";
                    pictureBox1.Image = qR_Code.encode(item.Name);
                }
            }
        }
    }
}
