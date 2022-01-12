using Spinzer_Managment_System__4._12_V_.ExtraModulesCode.RoundRectForms;
using Spinzer_Managment_System__4._12_V_.Model.Queries;
using Spinzer_Managment_System__4._12_V_.View.MainControll;
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
    public partial class Stock : Form
    {
        private RoundRectForm roundRectForm = new RoundRectForm();
        private StockViewModel stockViewModel;
        public Stock()
        {
            InitializeComponent();
            roundRectForm.addingRegionForm(this);
        }

        private void cancel_PictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_PictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_PictureBox_Click(object sender, EventArgs e)
        {
            if (!validateForProceed()) {
                stockViewModel = new StockViewModel();
                ArrayList arrayList = new ArrayList();

                DataTable length = stockViewModel.fillingData();
                foreach (var stock in stockViewModel.stockModel.dataStock)
                {
                    arrayList.Add(stock.Name);    
                }
                if (arrayList.Contains(name_TextBox.Text))
                {
                    MessageBox.Show("Please Enter The Unique Name");
                    return;
                }
                else {
                    Insert insert = new Insert();
                    if (weight_TextBox.Enabled == true)
                    {
                        int id = -1;
                        insert.InsertStockWithWeight(Global.userId, name_TextBox.Text, Convert.ToDouble(weight_TextBox.Text), exp_TextBox.Text, desc_TextBox.Text, Convert.ToInt32(price_TextBox.Text));
                        stockViewModel = new StockViewModel();
                        DataTable dataTable = stockViewModel.fillingData();
                        foreach (var item in stockViewModel.stockModel.dataStock)
                        {
                            if (item.Name.Equals(name_TextBox.Text))
                            {
                                id = item.Id;
                            }
                        }
                        insert.InsertUpdateStockWithWeight(id, Convert.ToDouble(weight_TextBox.Text), Convert.ToInt32(price_TextBox.Text));
                    }
                    else if (qty_TextBox.Enabled == true)
                    {
                        int id = -1;
                        insert.InsertStockWithQTY(Global.userId, name_TextBox.Text, Convert.ToInt32(qty_TextBox.Text), exp_TextBox.Text, desc_TextBox.Text, Convert.ToInt32(price_TextBox.Text));
                        stockViewModel = new StockViewModel();
                        DataTable dataTable = stockViewModel.fillingData();
                        foreach (var item in stockViewModel.stockModel.dataStock)
                        {
                            if (item.Name.Equals(name_TextBox.Text))
                            {
                                id = item.Id;
                            }
                        }
                        insert.InsertUpdateStockWithQty(id, Convert.ToInt32(qty_TextBox.Text), Convert.ToInt32(price_TextBox.Text));
                    }
                    MessageBox.Show("Insert Succesfully");
                }
               
            }
            else {
                return;
            }
        }
        private bool validateForProceed() {
            bool check = false;
            
            if (name_TextBox.Text == "")
            {
                nameErrorlabel.Visible = true;
            }
            else {
                nameErrorlabel.Visible = false;
            }
            if ((weight_TextBox.Text == "" || weight_TextBox.Text == "0.00") && weight_TextBox.Enabled == true)
            {
                weightError_Label.Visible = true;
            }
            else {
                weightError_Label.Visible = false;
            }
            if (qty_TextBox.Text == "" && qty_TextBox.Enabled == true)
            {

                qtyError_Label.Visible = true;
            }
            else {
                qtyError_Label.Visible = false;
            }
           
            if (price_TextBox.Text == "")
            {
                priceError_Label.Visible = true;
            }
            else {

                priceError_Label.Visible = false;
            }
            if (nameErrorlabel.Visible == true || weightError_Label.Visible == true || qtyError_Label.Visible == true ||  priceError_Label.Visible == true)
            {
                check = true;
            }
            else
            {
                check = false;
            }

            return check;
        }

        private void weight_TextBox_TextChanged(object sender, EventArgs e)
        {
           
            if (weight_TextBox.Text == "")
            {
                qty_TextBox.Enabled = true;
            }
            else
            {
                qty_TextBox.Enabled = false;

            }
        }

        private void qty_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (qty_TextBox.Text == "") {
                weight_TextBox.Enabled = true;
            }
            else
            {
                weight_TextBox.Enabled = false;
            }
        }

        private void weight_TextBox_Click(object sender, EventArgs e)
        {
            weight_TextBox.Text = "";
            weight_TextBox.ForeColor = Color.Black;
        }
    }
}
