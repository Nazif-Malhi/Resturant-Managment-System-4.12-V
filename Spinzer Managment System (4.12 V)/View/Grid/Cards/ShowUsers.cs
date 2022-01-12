
using Spinzer_Managment_System__4._12_V_.Model.Queries;
using Spinzer_Managment_System__4._12_V_.View.Grid.Base;
using Spinzer_Managment_System__4._12_V_.View.Small_Controlls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spinzer_Managment_System__4._12_V_.View.Grid.Cards
{
    public partial class ShowUsers : UserControl
    {
       
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
        public ShowUsers()
        {
           
         
            InitializeComponent();
            idlabel.Visible = false;
        }

        private void update_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            update_PictureBox.BackgroundImage = Properties.Resources.btn_updateHoverLibrary;
        }

        private void update_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            update_PictureBox.BackgroundImage = Properties.Resources.btn_UpdateLibrary;
        }

        private void delete_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            delete_PictureBox.BackgroundImage = Properties.Resources.btn_deleteHoverLibrary;
        }

        private void delete_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            delete_PictureBox.BackgroundImage = Properties.Resources.btn_deleteLibrary;
        }

        private void update_PictureBox_Click(object sender, EventArgs e)
        {
            User user = new User(Convert.ToInt32(idlabel.Text));
            user.ShowDialog();
        }

        private void delete_PictureBox_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.DeleteEntites(Convert.ToInt32(idlabel.Text));
        }

      
    }
}
