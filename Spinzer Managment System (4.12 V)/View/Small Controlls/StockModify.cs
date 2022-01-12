using Spinzer_Managment_System__4._12_V_.View.MainControll;
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

namespace Spinzer_Managment_System__4._12_V_.View.Small_Controlls
{
    public partial class StockModify : Form
    {
        StockViewModel stockViewModel = new StockViewModel();
       
        public StockModify()
        {
            InitializeComponent();
            DataTable dataTable = stockViewModel.fillingData();
            fillDataInNameComboBox();
        }

      

        private void cancel_PictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_PictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void fillDataInNameComboBox() {
            foreach (var item in stockViewModel.stockModel.dataStock)
            {
                name_ComboBox.Items.Add(item.Name);
            }
        }

        private void name_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            foreach (var item in stockViewModel.stockModel.dataStock)
            {
                if (item.Name.Equals(name_ComboBox.SelectedItem.ToString())) {
                    weight_TextBox.Text = item.Weight.ToString();
                    qty_TextBox.Text = item.Qty.ToString();
                    if (weight_TextBox.Text == string.Empty)
                    {
                        weight_TextBox.Enabled = false;
                    }
                    else {
                        weight_TextBox.Enabled = true;
                    }
                    if (qty_TextBox.Text == string.Empty)
                    {
                        qty_TextBox.Enabled = false;
                    }
                    else {
                        qty_TextBox.Enabled = true;
                    }
                }
            }
        }

        private void name_ComboBox_TextChanged(object sender, EventArgs e)
        {
            if (name_ComboBox.Text == string.Empty)
            {
                weight_TextBox.Text = "";
                qty_TextBox.Text = "";
            }
        }
        private void save_PictureBox_Click(object sender, EventArgs e)
        {
            int id = 0, UserId = 0, price = 0;
            string name = "", expiryDate = "", description = "";
            DataTable dataTable = stockViewModel.fillingData();
            foreach (var item in stockViewModel.stockModel.dataStock)
            {
                if (item.Name.Equals(name_ComboBox.SelectedItem)) {
                    id = item.Id;
                    UserId = Global.userId;
                    price = item.Price;
                    name = item.Name;
                    expiryDate = item.ExpiryDate;
                    description = item.Description;
                }
            }
            var value = minusStockCalculation();
            int newPrice = Convert.ToInt32(updateStockPrice(price));
            if (qty_TextBox.Enabled == true)
            {
                StockViewModel.transactionBegin(value, "qty",id,UserId,name,expiryDate,description,newPrice,qty_TextBox.Text);
            }
            else if (weight_TextBox.Enabled == true) {
                StockViewModel.transactionBegin(value, "weight", id, UserId, name, expiryDate, description, newPrice,weight_TextBox.Text);
            }
        }

        private string minusStockCalculation() {
            Nullable<int> oldQty = 0;
            Nullable<double> oldWeight = 0;
            int? newQty=0;
            double? newWeight=0;
            string returnForm = "";
            foreach (var item in stockViewModel.stockModel.dataStock)
            {
                if (item.Name.Equals(name_ComboBox.SelectedItem)) {
                    if (item.Qty != null) {
                        newQty = item.Qty;
                    }
                    if (item.Weight != null) {
                        newWeight = item.Weight;
                    }
                }
            }
            if (qty_TextBox.Enabled == true) {
                oldQty = Convert.ToInt32(qty_TextBox.Text);
                int? resultQty = newQty - oldQty;
                returnForm = resultQty.ToString();

            }
            if (weight_TextBox.Enabled == true) {
                oldWeight = Convert.ToDouble(weight_TextBox.Text);
                double? resultWeigth = newWeight - oldWeight;
                returnForm = resultWeigth.ToString();
            }
            return returnForm;

        }
        private int? updateStockPrice(int ? price)
        {
            Nullable<int> oldQty = 0;
            Nullable<double> oldWeight = 0;
            

            
            foreach (var item in stockViewModel.stockModel.dataStock)
            {
                if (item.Name.Equals(name_ComboBox.SelectedItem))
                {
                    if (item.Qty != null)
                    {
                        oldQty = item.Qty;
                    }
                    if (item.Weight != null)
                    {
                        oldWeight = item.Weight;
                    }
                }
            }
            if (qty_TextBox.Enabled == true)
            {
                int? resultPrice = (price / oldQty);
                resultPrice *= Convert.ToInt32(qty_TextBox.Text);
                price -= resultPrice;
            }
            if (weight_TextBox.Enabled == true)
            {
                double? resultWeigth = (price / oldWeight);
                resultWeigth *= Convert.ToDouble(weight_TextBox.Text);
                price -= Convert.ToInt32(resultWeigth);
            }
          
            return price;
        }
    }
}
