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
    public partial class Category : Form
    {
        private RoundRectForm roundRectForm = new RoundRectForm();
        private bool updateSwitch = false;
        private int idToBeUpdated;
        private CategoriesViewModel categoriesViewModel = new CategoriesViewModel();
        public Category()
        {
            InitializeComponent();
            roundRectForm.addingRegionForm(this);
            availablity_ComboBox.SelectedIndex = 0;
        }
        public Category(bool updateSwitch, int idToBeUpdated)
        {
            InitializeComponent();
            roundRectForm.addingRegionForm(this);
            availablity_ComboBox.SelectedIndex = 0;
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
            if (nameErrorlabel.Visible == false) {
                
                if (!updateSwitch)
                {
                    Insert insert = new Insert();
                    insert.InsertCategory(name_TextBox.Text, availablity_ComboBox.Text, Global.userId);
                    MessageBox.Show(name_TextBox.Text + " Category has been Added");
                }
                else {
                    Update update = new Update();
                    update.UpdateCategory(idToBeUpdated,name_TextBox.Text, availablity_ComboBox.Text, Global.userId);
                }
                name_TextBox.Text = "";
                availablity_ComboBox.SelectedIndex = 0;
            }
        }
        private void update() {
            int length = categoriesViewModel.fillingData();
            foreach (var item in categoriesViewModel.catModel.dataCat)
            {
                if (item.CategoriesID.Equals(idToBeUpdated)) {
                    name_TextBox.Text = item.CategoriesName;
                    availablity_ComboBox.Text = item.Availibilty;

                }
            }
        }
    }
}
