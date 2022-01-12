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
    public partial class UpdateQuantitiyFromOrder : Form
    {
        int qty = -1;
        public UpdateQuantitiyFromOrder(int qty)
        {
            InitializeComponent();
            this.qty = qty;
            textBox1.Text = qty.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") {
                qtyError_Label.Visible = true;
            }
            else
            {
                qty = Convert.ToInt32(textBox1.Text);
                this.Close();
            }
        }
        public int getValue() 
        {
            return qty;
        }
    }
}
