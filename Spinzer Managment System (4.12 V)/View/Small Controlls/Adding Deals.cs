using Spinzer_Managment_System__4._12_V_.Model.Queries;
using Spinzer_Managment_System__4._12_V_.ViewModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spinzer_Managment_System__4._12_V_.View.Small_Controlls
{
    public partial class Adding_Deals : Form
    {
        private int idToBeUpdated;
        private bool updateSwitch = false;
        private int dealsId = -1;

        ItemViewModel itemViewModel;
        CategoriesViewModel categoriesViewModel;
        DealsViewModel dealsViewModel;
        DealsItemViewModel dealsItemViewModel;
        public Adding_Deals()
        {
            InitializeComponent();
            itemViewModel = new ItemViewModel();
            categoriesViewModel = new CategoriesViewModel();
            dealsViewModel = new DealsViewModel();
            dealsItemViewModel = new DealsItemViewModel();

            int length = itemViewModel.fillingData();
            int length1 = categoriesViewModel.fillingData();
            int length2 = dealsViewModel.fillingData();
            int length3 = dealsItemViewModel.fillingData();

            fillItemComboBox();
        }
        public Adding_Deals(int idToBeUpdated)
        {
            InitializeComponent();
            itemViewModel = new ItemViewModel();
            categoriesViewModel = new CategoriesViewModel();
            dealsViewModel = new DealsViewModel();

            int length = itemViewModel.fillingData();
            int length1 = categoriesViewModel.fillingData();
            int length2 = dealsViewModel.fillingData();

            fillItemComboBox();
            this.idToBeUpdated = idToBeUpdated;
            updateSwitch = true;
            update();
        }
        private void fillItemComboBox() {
            
            foreach (var item in itemViewModel.itemModel.dataItem)
            {
                foreach (var category in categoriesViewModel.catModel.dataCat) {
                    if (item.Cat_ID.Equals(category.CategoriesID)) {

                        string fullName = "";
                        string removing1stLetterFromString = "";
                        removing1stLetterFromString = item.Item_Name;
                        removing1stLetterFromString = removing1stLetterFromString.Substring(1, removing1stLetterFromString.Length - 1);
                        fullName = removing1stLetterFromString;
                        removing1stLetterFromString = category.CategoriesName;
                        removing1stLetterFromString = removing1stLetterFromString.Substring(1, removing1stLetterFromString.Length - 1);

                        fullName += " - "+removing1stLetterFromString;

                        item1_ComboBox.Items.Add(fullName);
                        item2_ComboBox.Items.Add(fullName);
                        item3_ComboBox.Items.Add(fullName);
                        item4_ComboBox.Items.Add(fullName);
                        item5_ComboBox.Items.Add(fullName);
                        item6_ComboBox.Items.Add(fullName);
                    }
                }
            }
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
            if (checkingForNulls()) {
                if (insertingAllDeals())
                {
                    if (item1_ComboBox.SelectedIndex > -1)
                    {
                        insertingAllDealsItems(item1_ComboBox, qtyItem1_TextBox);
                    }
                    if (item2_ComboBox.SelectedIndex > -1)
                    {
                        insertingAllDealsItems(item2_ComboBox, qtyItem2_TextBox);
                    }
                    if (item3_ComboBox.SelectedIndex > -1)
                    {
                        insertingAllDealsItems(item3_ComboBox, qtyItem3_TextBox);
                    }
                    if (item4_ComboBox.SelectedIndex > -1)
                    {
                        insertingAllDealsItems(item4_ComboBox, qtyItem4_TextBox);
                    }
                    if (item5_ComboBox.SelectedIndex > -1)
                    {
                        insertingAllDealsItems(item5_ComboBox, qtyItem5_TextBox);
                    }
                    if (item6_ComboBox.SelectedIndex > -1)
                    {
                        insertingAllDealsItems(item6_ComboBox, qtyItem6_TextBox);
                    }
                    MessageBox.Show("Inserted Succesfully");
                }
               
            }
            dealsId = -1;
        }
        private bool insertingAllDeals() {
            bool success = false;
            ArrayList arrayList = new ArrayList();

            foreach (var item in dealsViewModel.dataDeals.dataDealsModel)
            {
                arrayList.Add(item.Name);

            }


            if (!updateSwitch)
            {
                if (arrayList.Contains(name_TextBox.Text))
                {
                    MessageBox.Show("Deal Contains Please change Name to proceed");
                    success = false;
                }
                Insert insert = new Insert();
                insert.InsertDeals(name_TextBox.Text, Convert.ToInt32(price_TextBox.Text));
                success = true;
            }
            else
            {
                Update update1 = new Update();
                update1.UpdateDeals(idToBeUpdated, name_TextBox.Text, Convert.ToInt32(price_TextBox.Text));
                success = true;
                Delete delete = new Delete();
                delete.DeleteDealsItems(idToBeUpdated.ToString());
            }
            
          
            return success;

        }
        private void insertingAllDealsItems(ComboBox comboBox,TextBox textBox) {

            dealsViewModel = new DealsViewModel();
            int length3 = dealsViewModel.fillingData();
            foreach (var item in dealsViewModel.dataDeals.dataDealsModel)
            {
                if (item.Name.Equals(name_TextBox.Text)) {
                    dealsId = item.ID;
                }
            }
            foreach (var item in itemViewModel.itemModel.dataItem)
            {
                foreach (var category in categoriesViewModel.catModel.dataCat)
                {
                    if (item.Cat_ID.Equals(category.CategoriesID))
                    {

                        string fullName = "";
                        string removing1stLetterFromString = "";
                        removing1stLetterFromString = item.Item_Name;
                        removing1stLetterFromString = removing1stLetterFromString.Substring(1, removing1stLetterFromString.Length - 1);
                        fullName = removing1stLetterFromString;
                        removing1stLetterFromString = category.CategoriesName;
                        removing1stLetterFromString = removing1stLetterFromString.Substring(1, removing1stLetterFromString.Length - 1);

                        fullName += " - " + removing1stLetterFromString;

                        if (fullName.Equals(comboBox.SelectedItem.ToString()))
                        {
                            Insert insert = new Insert();
                            insert.InsertDealsItem(item.Id, category.CategoriesID, dealsId, Convert.ToInt32(textBox.Text));
                            
                        }
                    }
                }
            }

        }
        private bool checkingForNulls() {
            bool check = false;
            if (name_TextBox.Text == "")
            {
                nameErrorLabel.Visible = true;
            }
            else {
                nameErrorLabel.Visible = false;
            }
           
            if (price_TextBox.Text == "") {
                price_ErrorLabel.Visible = true;
            }
            else {
                price_ErrorLabel.Visible = false;
            }
            if (item1_ComboBox.SelectedIndex == -1 || qtyItem1_TextBox.Text == "")
            {
                itemErrorLabel.Visible = true;
            }
            else
            {
                itemErrorLabel.Visible = false;
            }
            if (item2_ComboBox.SelectedIndex > -1 && qtyItem2_TextBox.Text == "") {
                itemErrorLabel2.Visible = true;
            }
            else {
                itemErrorLabel2.Visible = false;
            }
            if (item3_ComboBox.SelectedIndex > -1 && qtyItem3_TextBox.Text == "") {
                itemErrorLabel3.Visible = true;
            }
            else {
                itemErrorLabel2.Visible = false;
            }
            if (item4_ComboBox.SelectedIndex > -1 && qtyItem4_TextBox.Text == "") {
                itemErrorLabel4.Visible = true;
            }
            else {
                itemErrorLabel2.Visible = false;
            }
            if (item5_ComboBox.SelectedIndex > -1 && qtyItem5_TextBox.Text == "") {
                itemErrorLabel5.Visible = true;
            }
            else {
                itemErrorLabel2.Visible = false;
            }
            if (item6_ComboBox.SelectedIndex > -1 && qtyItem6_TextBox.Text == "") {
                itemErrorLabel6.Visible = true;
            }
            else {
                itemErrorLabel2.Visible = false;
            }

           
            if (nameErrorLabel.Visible == true || price_ErrorLabel.Visible == true || itemErrorLabel.Visible == true || itemErrorLabel2.Visible==true || itemErrorLabel3.Visible == true || itemErrorLabel4.Visible == true || itemErrorLabel5.Visible == true || itemErrorLabel6.Visible == true)
            {
                check = false;
            }
            else {
                check = true;
            }
            return check;

        }

        private void update() {
            dealsViewModel = new DealsViewModel();
            dealsItemViewModel = new DealsItemViewModel();
            ArrayList arrayList = new ArrayList();

           
            int length = dealsViewModel.fillingData();
            int l = dealsItemViewModel.fillingData();
            foreach (var item in dealsViewModel.dataDeals.dataDealsModel)
            {
                if (item.ID.Equals(idToBeUpdated)) {
                    name_TextBox.Text = item.Name;
                    price_TextBox.Text = item.Price.ToString();
                }
            }

            foreach (var deals in dealsItemViewModel.dataDealsItem.dataDealsItemModel)
            {
                if (deals.Deals_id.Equals(idToBeUpdated)) {
                    string fullName = "";
                    string removing1stLetterFromString = "";
                    foreach (var item in itemViewModel.itemModel.dataItem)
                    {
                        if (item.Id.Equals(deals.Item_id)) {
                            
                            removing1stLetterFromString = item.Item_Name;
                            removing1stLetterFromString = removing1stLetterFromString.Substring(1, removing1stLetterFromString.Length - 1);
                            fullName = removing1stLetterFromString;
                        }
                    }
                    foreach (var category in categoriesViewModel.catModel.dataCat)
                    {
                        if (category.CategoriesID.Equals(deals.Cat_id)) {
                            removing1stLetterFromString = category.CategoriesName;
                            removing1stLetterFromString = removing1stLetterFromString.Substring(1, removing1stLetterFromString.Length - 1);
                            fullName += " - " + removing1stLetterFromString;
                        }
                    }
                    arrayList.Add(fullName);

                }
            }
            int i = 0;
            if (i == arrayList.Count) return;
            item1_ComboBox.SelectedItem = arrayList[i].ToString();
            i++;
            if (i == arrayList.Count) return;
            item2_ComboBox.SelectedItem = arrayList[i].ToString();
            i++;
            if (i == arrayList.Count) return;
            item3_ComboBox.SelectedItem = arrayList[i].ToString();
            i++;
            if (i == arrayList.Count) return;
            item4_ComboBox.SelectedItem = arrayList[i].ToString();
            i++;
            if (i == arrayList.Count) return;
            item5_ComboBox.SelectedItem = arrayList[i].ToString();
            i++;
            if (i == arrayList.Count) return;
            item6_ComboBox.SelectedItem = arrayList[i].ToString();
            i++;
            if (i == arrayList.Count) return;

        }

    }
}
