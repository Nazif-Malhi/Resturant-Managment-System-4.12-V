using Spinzer_Managment_System__4._12_V_.ExternalResoursces.QRCode;
using Spinzer_Managment_System__4._12_V_.Model;
using Spinzer_Managment_System__4._12_V_.Model.Queries;
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
    public partial class GetEmployeeDataGrid : UserControl
    {
        List<ShowEmployees> showEmployees;
        EmployeeViewModel employeeViewModel;
        private int start = 0, ends = 3, length = 0, limit = 3 ;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }



        public GetEmployeeDataGrid()
        {
            
            InitializeComponent();
            loadInitialize();
        }
        private void loadInitialize()
        {
            start = 0; ends = 3; length = 0;
            showEmployees = new List<ShowEmployees>();
            employeeViewModel = new EmployeeViewModel();
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
            length = employeeViewModel.fillingData();
            for (int i = 0; i < length; i++)
            {
                showEmployees.Add(new ShowEmployees());
                showEmployees[i].idLabel.Text = employeeViewModel.dataToEmployeeModel.dataEmployee[i].ID.ToString();
                showEmployees[i].employeeName_Label.Text = employeeViewModel.dataToEmployeeModel.dataEmployee[i].Name;
                showEmployees[i].address_Label.Text = employeeViewModel.dataToEmployeeModel.dataEmployee[i].Address;
                showEmployees[i].phone_Label.Text = employeeViewModel.dataToEmployeeModel.dataEmployee[i].Phone;
                showEmployees[i].doj_label.Text = employeeViewModel.dataToEmployeeModel.dataEmployee[i].DateOfJoining;
                showEmployees[i].email_Label.Text = employeeViewModel.dataToEmployeeModel.dataEmployee[i].Email;
                QR_Code qR_Code = new QR_Code();
                Bitmap resize = new Bitmap(qR_Code.encode(employeeViewModel.dataToEmployeeModel.dataEmployee[i].QRCode), new Size(100, 100));
                showEmployees[i].qR_PictureBox.Image = resize;

                showEmployees[i].update_PictureBox.Click += Update_PictureBox_Click;
                showEmployees[i].delete_PictureBox.Click += Delete_PictureBox_Click;
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
                flowLayoutPanel1.Controls.Add(showEmployees[i]);
            }
        }
    }
}
