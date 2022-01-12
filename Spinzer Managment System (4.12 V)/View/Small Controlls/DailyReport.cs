using Spinzer_Managment_System__4._12_V_.Model;
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
    public partial class DailyReport : Form
    {
        ItemViewModel itemViewModel; 
        public DailyReport()
        {
            InitializeComponent();
            date_Timer.Start();
            getDataInDataGrid();
            
        }

        private void InitilaizeOnLoad() {
            DateTime dateTime = DateTime.Now;
            time_Label.Text = dateTime.ToString();
        }
        private void Close_pictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void date_Timer_Tick(object sender, EventArgs e)
        {
            InitilaizeOnLoad();
        }
        private void getDataInDataGrid() {
            int numberOfItemSold=0, TotalIncome = 0;
            itemViewModel = new ItemViewModel();
            int lengthy = itemViewModel.fillingData();
            DataTable dt = new DataTable();
            dt=DataTableToListClass.getDailyOrderReport();
            foreach (DataRow row in dt.Rows)
            {
                int itemId = Convert.ToInt32(row["Item_id"]);
                int count = Convert.ToInt32(row["Count All Items"]);
                foreach (var item in itemViewModel.itemModel.dataItem)
                {
                    if (item.Id.Equals(itemId))
                    {
                        dataGridView1.Rows.Add(item.Item_Name, count.ToString(), (count * item.Price).ToString());
                        numberOfItemSold += count;
                        TotalIncome += (count * item.Price);
                    }
                }

            }

            itemsSold_Label.Text = numberOfItemSold.ToString();
            totalIncome_Label.Text = TotalIncome.ToString();
        }
    }
}
