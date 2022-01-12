using Spinzer_Managment_System__4._12_V_.Model;
using Spinzer_Managment_System__4._12_V_.View.Grid.Cards;
using Spinzer_Managment_System__4._12_V_.View.Small_Controlls;
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

namespace Spinzer_Managment_System__4._12_V_.View.Grid.Base
{
    public partial class GetUserDataGrid : UserControl
    {
        public List<ShowUsers> showUsers;
        UserViewModel userViewModel;
        private int start = 0, ends = 3, length = 0, limit = 3;



       
        
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
        public GetUserDataGrid()
        {
            
            InitializeComponent();
            loadInitialize();
            
        }

      

        private void loadInitialize() {

            start = 0; ends = 3; length = 0;
            showUsers = new List<ShowUsers>();
           
            userViewModel = new UserViewModel();
            gettingExtensionData();
        }

        private void backward_PictureBox_Click(object sender, EventArgs e)
        {
            if (start == 0) return;
            if (ends == length)
            {
                ends = start;
                start -= 3;
            }
            else {
                start -= 3;
                ends -= 3;
            }
            gettingExtensionData();
            loadGrid();
        }

        private void forward_Picturebox_Click(object sender, EventArgs e)
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
        private void gettingExtensionData()
        {
            length = userViewModel.fillingData();
           
            for (int i = 0; i < length; i++)
            {
                showUsers.Add(new ShowUsers());
                showUsers[i].idlabel.Text = userViewModel.userModel.dataUser[i].Id.ToString();
                showUsers[i].userName_Label.Text = userViewModel.userModel.dataUser[i].Name;
                showUsers[i].address_Label.Text = userViewModel.userModel.dataUser[i].Address;
                showUsers[i].authentication_Label.Text = userViewModel.userModel.dataUser[i].Authentication;
                showUsers[i].password_Label.Text = userViewModel.userModel.dataUser[i].Password;
                showUsers[i].email_Label.Text = userViewModel.userModel.dataUser[i].Email;
                showUsers[i].phone_label.Text = userViewModel.userModel.dataUser[i].Phone;
                showUsers[i].update_PictureBox.Click += Update_PictureBox_Click;
                showUsers[i].delete_PictureBox.Click += Delete_PictureBox_Click;
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
            else {
                index = ends;
            }
            
            range_Label.Text = start + " . . . " + ends;
            flowLayoutPanel1.Controls.Clear();
            for (int i = start; i < index; i++)
            {
                flowLayoutPanel1.Controls.Add(showUsers[i]);
            }
        }
       

    }
}
