using Spinzer_Managment_System__4._12_V_.Model.Queries;
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
    public partial class ShowEmployees : UserControl
    {
       
        public ShowEmployees()
        {
            InitializeComponent();

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
            Employee employee = new Employee(true,Convert.ToInt32(idLabel.Text));
            employee.ShowDialog();
        }

        private void delete_PictureBox_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.DeleteEmployee(Convert.ToInt32(idLabel.Text));
        }
    }
}
