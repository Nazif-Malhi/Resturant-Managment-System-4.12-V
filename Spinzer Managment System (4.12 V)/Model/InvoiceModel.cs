using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinzer_Managment_System__4._12_V_.Model
{
    public class DatatoInvoiceModel
    {
        public List<InvoiceModel> dataInvoice { get; set; }
    }
    public class InvoiceModel
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        private int invoiceNumber;

        public int InvoiceNumber
        {
            get { return invoiceNumber; }
            set { invoiceNumber = value; }
        }

    }
}
