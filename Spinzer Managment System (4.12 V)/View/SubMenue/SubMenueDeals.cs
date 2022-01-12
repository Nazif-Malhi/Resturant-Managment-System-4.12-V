using Spinzer_Managment_System__4._12_V_.View.Small_Controlls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spinzer_Managment_System__4._12_V_.View.SubMenue
{
    public partial class SubMenueDeals : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
              int nLeftRect,     // x-coordinate of upper-left corner
              int nTopRect,      // y-coordinate of upper-left corner
              int nRightRect,    // x-coordinate of lower-right corner
              int nBottomRect,   // y-coordinate of lower-right corner
              int nWidthEllipse, // height of ellipse
              int nHeightEllipse // width of ellipse
        );
        public SubMenueDeals()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 41, 41));
        }

        private void newDeals_PictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adding_Deals adding_Deals = new Adding_Deals();
            adding_Deals.ShowDialog();
        }
    }
}
