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
    
    public partial class Customer : Form
    {
        private int idToBeUpdated;
        private bool updateSwitch = false;

        private CustomerViewModel customerViewModel = new CustomerViewModel();
        private RoundRectForm roundRectForm = new RoundRectForm();
        public Customer()
        {
            InitializeComponent();
            roundRectForm.addingRegionForm(this);
        }

        public Customer(int idToBeUpdated)
        {
            InitializeComponent();
            roundRectForm.addingRegionForm(this);
            this.idToBeUpdated = idToBeUpdated;
            updateSwitch = true;
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

        private void name_TextBox_TextChanged(object sender, EventArgs e)
        {
            QR_Code qR_Code = new QR_Code();
            pictureBox1.Image = qR_Code.encode(name_TextBox.Text);
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
            if (nameErrorlabel.Visible == false) {

                if (!updateSwitch)
                {
                    Insert insert = new Insert();
                    insert.InsertCustomer(name_TextBox.Text, email_TextBox.Text, phone_TextBox.Text, address_TextBox.Text, Global.userId, name_TextBox.Text);
                    MessageBox.Show(name_TextBox.Text + " Customer has been Added");

                   
                }
                else {
                    Update update1 = new Update();
                    update1.UpdateCustomer(idToBeUpdated, name_TextBox.Text, email_TextBox.Text, phone_TextBox.Text, address_TextBox.Text, Global.userId, name_TextBox.Text);
                }
                name_TextBox.Text = "";
                email_TextBox.Text = "";
                phone_TextBox.Text = "";
                address_TextBox.Text = "";
                name_TextBox.Focus();
            }

        }
        private void update() {
            var length = customerViewModel.fillingData();
            foreach (var item in customerViewModel.dataToCustomerModel.dataCustomer)
            {
                if (item.ID.Equals(idToBeUpdated))
                {
                    name_TextBox.Text = item.Name;
                    email_TextBox.Text = item.Email;
                    phone_TextBox.Text = item.Phone;
                    address_TextBox.Text = item.Address;
                }

            }
        }
    }
}
