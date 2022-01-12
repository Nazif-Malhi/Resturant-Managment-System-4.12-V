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
    public partial class RecentOrder : Form
    {
        string invoice = "";
        public RecentOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter the invoice number");
            }
            else {
                invoice = textBox1.Text;
                this.Close();
            }
        }
        public string getValue() {
            return invoice;
        }
    }
}
