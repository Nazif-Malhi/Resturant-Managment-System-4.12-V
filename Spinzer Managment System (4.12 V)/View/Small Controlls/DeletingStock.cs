using Spinzer_Managment_System__4._12_V_.Model.Queries;
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
    public partial class DeletingStock : Form
    {
        StockViewModel stockViewModel = new StockViewModel();
        public DeletingStock()
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
        private void fillDataInNameComboBox()
        {
            foreach (var item in stockViewModel.stockModel.dataStock)
            {
                name_ComboBox.Items.Add(item.Name);
            }
        }

        private void delete_PictureBox_Click(object sender, EventArgs e)
        {
            if (name_ComboBox.SelectedIndex == -1)
            {
                nameErrorlabel.Visible = true;
            }
            else {
                int id = -1;
                foreach (var item in stockViewModel.stockModel.dataStock)
                {
                    if (item.Name.Equals(name_ComboBox.SelectedItem.ToString())) {
                        id = item.Id;
                    }
                }
                nameErrorlabel.Visible = false;
                Delete delete = new Delete();
                delete.DeleteStock(id);
            }
        }
    }
}
