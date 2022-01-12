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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dailyReport_PictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
            DailyReport dailyReport = new DailyReport();
            dailyReport.ShowDialog();

        }
    }
}
