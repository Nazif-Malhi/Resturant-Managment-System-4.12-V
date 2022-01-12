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
    public partial class ShowItems : UserControl
    {
        public ShowItems()
        {
            InitializeComponent();
        }

        private void update_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            update_PictureBox.BackgroundImage = Properties.Resources.btnDataGrid_UpdateHover;
        }

        private void update_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            update_PictureBox.BackgroundImage = Properties.Resources.btnDataGrid_Update;
        }

        private void delete_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            delete_PictureBox.BackgroundImage = Properties.Resources.btnDataGrid_DeleteHover;
        }

        private void delete_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            delete_PictureBox.BackgroundImage = Properties.Resources.btnDataGrid_Delete;
        }


        private void update_PictureBox_Click(object sender, EventArgs e)
        {
            Items items = new Items(true,Convert.ToInt32(id_label.Text));
            items.ShowDialog();
        }

        private void delete_PictureBox_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.DeleteMaterials(id_label.Text);
            delete.DeleteItems(id_label.Text);
        }
    }
}
