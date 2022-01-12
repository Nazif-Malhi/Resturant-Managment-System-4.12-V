using Spinzer_Managment_System__4._12_V_.View.Small_Controlls;
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

namespace Spinzer_Managment_System__4._12_V_.View.UserControll
{
    public partial class StockUserController : UserControl
    {
        StockViewModel stockViewModel = new StockViewModel();
        public StockUserController()
        {
            InitializeComponent();
            fillingDataInDataGridView();
            style_DataGrid(dataGridView1);
            updateListTimer.Start();
        }

       

        private void update_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            update_PictureBox.BackgroundImage = Properties.Resources.btn_StockUpdateHover;
        }

        private void update_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            update_PictureBox.BackgroundImage = Properties.Resources.btn_StockUpdate;
        }

        private void delete_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            delete_PictureBox.BackgroundImage = Properties.Resources.btn_StockDeleteHover;
        }

        private void delete_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            delete_PictureBox.BackgroundImage = Properties.Resources.btn_StockDelete;
        }

        private void modify_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            modify_PictureBox.BackgroundImage = Properties.Resources.btn_StockModifyHover;
        }

        private void modify_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            modify_PictureBox.BackgroundImage = Properties.Resources.btn_StockModify;
        }

        private void report_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            report_PictureBox.BackgroundImage = Properties.Resources.btn_StockReportHover;
        }

        private void report_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            report_PictureBox.BackgroundImage = Properties.Resources.btn_StockReport;
        }

        private void csv_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            csv_PictureBox.BackgroundImage = Properties.Resources.btn_StockCSVHover;
        }

        private void csv_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            csv_PictureBox.BackgroundImage = Properties.Resources.btn_StockCSV;
        }

        private void csv_PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void report_PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void modify_PictureBox_Click(object sender, EventArgs e)
        {
            StockModify stockModify = new StockModify();
            stockModify.ShowDialog();
            fillingDataInDataGridView();
        }


        private void update_PictureBox_Click(object sender, EventArgs e)
        {
            UpdatingStock updatingStock = new UpdatingStock();
            updatingStock.ShowDialog();
            fillingDataInDataGridView();
        }

        private void delete_PictureBox_Click(object sender, EventArgs e)
        {
            DeletingStock deletingStock = new DeletingStock();
            deletingStock.ShowDialog();
            fillingDataInDataGridView();

        }
        private void fillingDataInDataGridView() {


            DataTable dataTable = stockViewModel.fillingData();

            name.DataPropertyName = dataTable.Columns["Name"].ToString();
            qty.DataPropertyName = dataTable.Columns["Qty"].ToString();
            weight.DataPropertyName = dataTable.Columns["Weight"].ToString();
            expiryDate.DataPropertyName = dataTable.Columns["Expiry_Date"].ToString();
            description.DataPropertyName = dataTable.Columns["Description"].ToString();
            id.DataPropertyName = dataTable.Columns["id"].ToString();
            userId.DataPropertyName = dataTable.Columns["User_id"].ToString();
            dataGridView1.DataSource = dataTable;
        }
        #region DataGridView Style
        public void style_DataGrid(DataGridView dataGridView)
        {
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        #endregion

        private void fillingDataInListBox() 
        {
            stockViewModel = new StockViewModel();
            var i = stockViewModel.fillingData();
            listBox1.Items.Clear();
            foreach (var item in stockViewModel.stockModel.dataStock)
            {
                if (item.Qty < 5 ) {
                   
                    listBox1.Items.Add(item.Name +"          QTY = "+item.Qty);
                }
                if (item.Weight < 5)
                {

                    listBox1.Items.Add(item.Name + "          Weight = " + item.Weight);
                }
            }

        }

        private void updateListTimer_Tick(object sender, EventArgs e)
        {
            if (label1.Visible == true)
            {
                label1.Visible = false;
            }
            else {
                label1.Visible = true;
            }
            fillingDataInListBox();
        }
    }
}
