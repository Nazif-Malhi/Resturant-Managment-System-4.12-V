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
    public partial class Items : Form
    {
        StockViewModel stockViewModel = new StockViewModel();
        CategoriesViewModel categoriesViewModel = new CategoriesViewModel();
        ItemViewModel itemViewModel = new ItemViewModel();
        MaterialViewModel materialViewModel = new MaterialViewModel();

        private RoundRectForm roundRectForm = new RoundRectForm();
        private bool updateSwitch = false;
        private int idToBeUpdated;
        private int indexRow = -1, itemID = -1;
        public Items()
        {
            InitializeComponent();
            roundRectForm.addingRegionForm(this);
            fillUsedMaterials();
            available_ComboBox.SelectedIndex = 0;
        }
        public Items(bool updateSwitch, int idToBeUpdated)
        {
            InitializeComponent();
            roundRectForm.addingRegionForm(this);
            fillUsedMaterials();
            available_ComboBox.SelectedIndex = 0;
            this.updateSwitch = updateSwitch;
            this.idToBeUpdated = idToBeUpdated;
            update();
        }

        private void fillUsedMaterials()
        {
            DataTable dataTable = stockViewModel.fillingData();
            int length = dataTable.Rows.Count;
            int length1 = categoriesViewModel.fillingData();

            ////////Yhan Kaam krna hai agr stock or categories khali hojain too  exception Not Working Form (Krna hai )/// 

            foreach (var item in stockViewModel.stockModel.dataStock)
            {
                usedMaterial_ComboBox.Items.Add(item.Name);
            }

            foreach (var item in categoriesViewModel.catModel.dataCat)
            {
                category_ComboBox.Items.Add(item.CategoriesName);
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

            Insert insert = new Insert();
            Update updatei = new Update();
            Delete delete = new Delete();
            if (!turningOnMaterialMode()) return;

            int catId = -1;
            foreach (var item in categoriesViewModel.catModel.dataCat)
            {
                if (item.CategoriesName.Equals(category_ComboBox.SelectedItem))
                {
                    catId = item.CategoriesID;
                }
            }

            if (!updateSwitch)
            {
                insert.InsertItems(name_TextBox.Text, catId, available_ComboBox.SelectedItem.ToString(), Convert.ToInt32(price_TextBox.Text));
            }
            else {
                updatei.UpdateItems(idToBeUpdated, name_TextBox.Text, catId, available_ComboBox.SelectedItem.ToString(), Convert.ToInt32(price_TextBox.Text));
            }
            int length = itemViewModel.fillingData();
            foreach (var item in itemViewModel.itemModel.dataItem)
            {
                if (item.Item_Name.Equals(name_TextBox.Text))
                {
                    itemID = item.Id;
                }
            }

            //
            /// Inserting the materials that used
            if (!updateSwitch)
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.Cells[1].Value.ToString().Equals(string.Empty))
                        {
                            insert.InsertMaterialWithQty(row.Cells[0].Value.ToString(), Convert.ToInt32(row.Cells[1].Value.ToString()), itemID);

                        }
                        else if (!row.Cells[2].Value.ToString().Equals(string.Empty))
                        {
                            insert.InsertMaterialWithWeight(row.Cells[0].Value.ToString(), Convert.ToDouble(row.Cells[2].Value.ToString()), itemID);
                        }
                    }

                }
            }
            else {
                delete.DeleteMaterials(idToBeUpdated.ToString());
                if (dataGridView1.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.Cells[1].Value.ToString().Equals(string.Empty))
                        {
                            insert.InsertMaterialWithQty(row.Cells[0].Value.ToString(), Convert.ToInt32(row.Cells[1].Value.ToString()), itemID);

                        }
                        else if (!row.Cells[2].Value.ToString().Equals(string.Empty))
                        {
                            insert.InsertMaterialWithWeight(row.Cells[0].Value.ToString(), Convert.ToDouble(row.Cells[2].Value.ToString()), itemID);
                        }
                    }

                }
            }

        }
       

       

       
     

        private void saveMaterials_PictureBox_Click(object sender, EventArgs e)
        {

            if (!validateMaterialModeTextBoxes()) return;
            dataGridView1.Rows.Add(usedMaterial_ComboBox.SelectedItem, qty_TextBox.Text, weight_TextBox.Text);
        }
        private void clear_PictureBox_Click(object sender, EventArgs e)
        {
            if (indexRow == -1)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
            }
            else
            {
                dataGridView1.Rows.RemoveAt(indexRow);
                indexRow = -1;
            }
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
        }
        
        private bool turningOnMaterialMode() {

            bool operant = false;
            if (name_TextBox.Text == "") { nameErrorLabel.Visible = true; }
            else { nameErrorLabel.Visible = false; }
            if (category_ComboBox.SelectedIndex == -1) { categoryErrorLabel.Visible = true; }
            else { categoryErrorLabel.Visible = false; }
            if (price_TextBox.Text == "" || price_TextBox.Text == "0") { pricaeErrorLabel.Visible = true; }
            else { pricaeErrorLabel.Visible = false; }
            if (nameErrorLabel.Visible == true || categoryErrorLabel.Visible == true || pricaeErrorLabel.Visible == true)
            {
                operant = false;
            }
            else {
                operant = true;
            }
            return operant;
        }
        private void qty_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (qty_TextBox.Text != "")
            {
                weight_TextBox.Enabled = false;
            }
            else {
                weight_TextBox.Enabled = true;
            }
        }

        private void weight_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (weight_TextBox.Text != "")
            {
                qty_TextBox.Enabled = false;
            }
            else {
                qty_TextBox.Enabled = true;
            }
        }


        private bool validateMaterialModeTextBoxes()
        {

            bool operant = false;
            if (usedMaterial_ComboBox.SelectedIndex == -1 || usedMaterial_ComboBox.Text == "") { used_errorLabel.Visible = true; }
            else { used_errorLabel.Visible = false; }
            if (qty_TextBox.Text == "" && qty_TextBox.Enabled == true) { qty_errorLabel.Visible = true; }
            else { qty_errorLabel.Visible = false; }
            if (weight_TextBox.Text == "" && weight_TextBox.Enabled == true) { weight_errorLabel.Visible = true; }
            else { weight_errorLabel.Visible = false; }
            if (used_errorLabel.Visible == true || qty_errorLabel.Visible == true || weight_errorLabel.Visible == true)
            {
                operant = false;
            }
            else
            {
                operant = true;
            }
            return operant;
        }
        private void update()
        {
            int lenght = materialViewModel.fillingData();
            foreach (var item in materialViewModel.dataToMaterialModel.dataMaterials)
            {
                if (item.ItemId.Equals(idToBeUpdated))
                {
                    dataGridView1.Rows.Add(item.Name, item.Qty, item.Weight);
                }
            }
            int length2 = itemViewModel.fillingData();
            int lenght3 = categoriesViewModel.fillingData();
            foreach (var item in itemViewModel.itemModel.dataItem)
            {
                if (item.Id.Equals(idToBeUpdated))
                {
                    name_TextBox.Text = item.Item_Name;
                    foreach (var item1 in categoriesViewModel.catModel.dataCat)
                    {
                        if (item1.CategoriesID.Equals(item.Cat_ID))
                        {
                            category_ComboBox.SelectedItem = (item1.CategoriesName);
                        }
                    }
                    available_ComboBox.SelectedItem.Equals(item.Availabel);
                    price_TextBox.Text = item.Price.ToString();
                }
            }
        }
    }
}
