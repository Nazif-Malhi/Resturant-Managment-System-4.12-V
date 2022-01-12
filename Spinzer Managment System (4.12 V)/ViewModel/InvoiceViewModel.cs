using Spinzer_Managment_System__4._12_V_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinzer_Managment_System__4._12_V_.ViewModel
{
    public class InvoiceViewModel
    {
        public DatatoInvoiceModel invoiceModel = new DatatoInvoiceModel
        {
            dataInvoice = new List<InvoiceModel>()
        };
        public int fillingData()
        {
            return  DataTableToListClass.getDataFromInvoiceTable();
        }
    }
}
