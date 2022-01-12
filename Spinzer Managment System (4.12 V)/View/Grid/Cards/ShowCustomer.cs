using Spinzer_Managment_System__4._12_V_.Model.Queries;
using Spinzer_Managment_System__4._12_V_.View.Small_Controlls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spinzer_Managment_System__4._12_V_.View.Grid.Cards
{
    public partial class ShowCustomer : UserControl
    {
        private Bitmap bitmap;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
        public ShowCustomer()
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
            Customer customer = new Customer(Convert.ToInt32(idLabel.Text));
            customer.ShowDialog();
        }

        private void delete_PictureBox_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.DeleteCustomers(idLabel.Text);
        }

        private void ShowCustomer_MouseClick(object sender, MouseEventArgs e)
        {
           
            DialogResult dialogResult = MessageBox.Show("Want to print Card For Customer ?", "Print Card", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                printCard();
            }
        }

        private void printCard()
        {
            Graphics graphics = this.CreateGraphics();
            bitmap = new Bitmap(this.Size.Width, this.Size.Height, graphics);
            Graphics megaGraphics = Graphics.FromImage(bitmap);
            megaGraphics.CopyFromScreen(400, 68, 0, 0, new Size(720, 222));
            PaperSize psize = new PaperSize("Custom", 280, 800);
            printDocument1.DefaultPageSettings.PaperSize = psize;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.TranslateTransform(30, 20);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawImage(bitmap, 0, -200);
            DateTime dateTime = DateTime.Now;
            e.Graphics.DrawString(dateTime.ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, 0, -240);
            e.Graphics.DrawString("Spinzer", new Font("Arial", 19, FontStyle.Bold), Brushes.Black, 300, -250);
            e.Graphics.DrawString("Customer Card", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, 265, -220);
        }
    }
}
