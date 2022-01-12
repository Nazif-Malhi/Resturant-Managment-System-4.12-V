using Spinzer_Managment_System__4._12_V_.Accesible;
using Spinzer_Managment_System__4._12_V_.ExtraModulesCode.RoundRectForms;
using Spinzer_Managment_System__4._12_V_.Model.Queries;
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
    public partial class User : Form
    {
        private int id;
        private bool updateSwitch = false;
        RoundRectForm roundRectForm = new RoundRectForm();
        private UserViewModel userViewModel = new UserViewModel();
       
        public User()
        {
            InitializeComponent();
            roundRectForm.addingRegionForm(this);
        }
        public User(int id)
        {
            InitializeComponent();
            roundRectForm.addingRegionForm(this);
            this.id = id;
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

        private void save_PictureBox_Click(object sender, EventArgs e)
        {
            string line = "";
            string[] array = new string[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                array[i] = listBox1.Items[i].ToString();
            }
            line = string.Join(",", array);

            if (name_TextBox.Text == "")
            {
                nameErrorlabel.Visible = true;
            }
            else
            {
                nameErrorlabel.Visible = false;
            }
            if (authenticated_ComboBox.Text == "")
            {
                authenticatedErrorlabel.Visible = true;
            }
            else
            {
                authenticatedErrorlabel.Visible = false;
            }
            if (password__TextBox.Text == "")
            {
                passwordErrorlabel.Visible = true;
            }
            else
            {
                passwordErrorlabel.Visible = false;
            }
            if (nameErrorlabel.Visible == false && passwordErrorlabel.Visible == false && authenticatedErrorlabel.Visible == false)
            {
                if (!updateSwitch)
                {
                    Insert insert = new Insert();
                    insert.InsertUser(name_TextBox.Text, email_TextBox.Text, phone_TextBox.Text, password__TextBox.Text, address_TextBox.Text, line, desc_TextBox.Text, 0);
                    MessageBox.Show(name_TextBox.Text + " is inserted as user");
                }
                else {
                    Update update1 = new Update();
                    update1.UpdateUser(id,name_TextBox.Text, email_TextBox.Text, phone_TextBox.Text, password__TextBox.Text, address_TextBox.Text, line, desc_TextBox.Text, 0);
                    MessageBox.Show(name_TextBox.Text + " is updated as user");
                }
                
                name_TextBox.Text = "";
                email_TextBox.Text = "";
                phone_TextBox.Text = "";
                password__TextBox.Text = "";
                address_TextBox.Text = "";
                desc_TextBox.Text = "";
                authenticated_ComboBox.Text = "";
                listBox1.Items.Clear();
                name_TextBox.Focus();
            }

        }

        private void authenticated_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!listBox1.Items.Contains(authenticated_ComboBox.SelectedItem)) {
                listBox1.Items.Add(authenticated_ComboBox.SelectedItem);
            }
        }

        private void clear_PictureBox_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex==-1) {
                listBox1.Items.Clear();
            }
            else if (listBox1.Items.Count > 0) {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            listBox1.SelectedIndex = -1;
        }

        private void update() {
            int length = userViewModel.fillingData();
            foreach (var item in userViewModel.userModel.dataUser)
            {
                if (item.Id.Equals(id)) {
                    name_TextBox.Text = item.Name;
                    email_TextBox.Text = item.Email;
                    password__TextBox.Text = item.Password;
                    phone_TextBox.Text = item.Phone;
                    address_TextBox.Text = item.Address;
                    desc_TextBox.Text = item.Description;
                    List<string> auth = item.Authentication.Split(',').Reverse().ToList<string>();
                    foreach (var item1 in auth)
                    {
                        listBox1.Items.Add(item1);
                    }
                }
            }

        }
    }
}
