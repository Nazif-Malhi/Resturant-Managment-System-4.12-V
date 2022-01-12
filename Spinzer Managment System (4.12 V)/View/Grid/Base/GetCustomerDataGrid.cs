using Spinzer_Managment_System__4._12_V_.ExternalResoursces.QRCode;
using Spinzer_Managment_System__4._12_V_.View.Grid.Cards;
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

namespace Spinzer_Managment_System__4._12_V_.View.Grid.Base
{
    public partial class GetCustomerDataGrid : UserControl
    {
        List<ShowCustomer> showCustomers;
        CustomerViewModel customerViewModel;
        private int start = 0, ends = 3, length = 0, limit=3;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

      
        public GetCustomerDataGrid()
        {
            InitializeComponent();
            loadInitialize();
        }
        private void loadInitialize()
        {
            start = 0; ends = 3; length = 0;
            showCustomers = new List<ShowCustomer>();
            customerViewModel = new CustomerViewModel();
            gettingExtensionData();
        }
        private void forward_Picturebox_MouseDown(object sender, MouseEventArgs e)
        {
            if (ends >= length) return;
            int cal = length - ends;
            if (cal < limit)
            {
                start = ends;
                ends += cal;
            }
            else
            {
                start += 3;
                ends += 3;
            }
            gettingExtensionData();
            loadGrid();
        }

        private void backward_PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (start == 0) return;
            if (ends == length)
            {
                ends = start;
                start -= 3;
            }
            else
            {
                start -= 3;
                ends -= 3;
            }
            gettingExtensionData();
            loadGrid();
        }
        private void gettingExtensionData()
        {
            length = customerViewModel.fillingData();
            for (int i = 0; i < length; i++)
            {
                showCustomers.Add(new ShowCustomer());
                showCustomers[i].idLabel.Text = customerViewModel.dataToCustomerModel.dataCustomer[i].ID.ToString();
                showCustomers[i].employeeName_Label.Text = customerViewModel.dataToCustomerModel.dataCustomer[i].Name;
                showCustomers[i].address_Label.Text = customerViewModel.dataToCustomerModel.dataCustomer[i].Address;
                showCustomers[i].phone_Label.Text = customerViewModel.dataToCustomerModel.dataCustomer[i].Phone;
                showCustomers[i].email_Label.Text = customerViewModel.dataToCustomerModel.dataCustomer[i].Email;
                QR_Code qR_Code = new QR_Code();
                Bitmap resize = new Bitmap(qR_Code.encode(customerViewModel.dataToCustomerModel.dataCustomer[i].QRCode), new Size(100, 100));
                showCustomers[i].qR_PictureBox.Image = resize;
                showCustomers[i].update_PictureBox.Click += Update_PictureBox_Click;
                showCustomers[i].delete_PictureBox.Click += Delete_PictureBox_Click;
            }


            loadGrid();
        }

        private void Delete_PictureBox_Click(object sender, EventArgs e)
        {
            loadInitialize();
        }

        private void Update_PictureBox_Click(object sender, EventArgs e)
        {
            loadInitialize();

        }

        private void loadGrid()
        {
            int index = 0;
            if (length < ends)
            {

                index = length;
            }
            else
            {
                index = ends;
            }

            range_Label.Text = start + " . . . " + ends;
            flowLayoutPanel1.Controls.Clear();
            for (int i = start; i < index; i++)
            {
                flowLayoutPanel1.Controls.Add(showCustomers[i]);
            }
        }
    }
}
