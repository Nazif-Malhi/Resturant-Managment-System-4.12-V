using Spinzer_Managment_System__4._12_V_.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinzer_Managment_System__4._12_V_.ViewModel
{
    public class CustomerOrderViewModel
    {
        public DataToCustomerOrderModel dataToCustomerOrderModel = new DataToCustomerOrderModel
        {
            dataCustomerOrder = new List<CustomerOrderModel>()
        };
        public int fillingData()
        {
            DataTable dt = DataTableToListClass.getDataFromCustomersOrder();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                dataToCustomerOrderModel.dataCustomerOrder.Add(new CustomerOrderModel
                {
                    ID = Convert.ToInt32(dr["id"]),
                    Invoice = dr["@Invoice_QRCode"].ToString(),
                    Name = dr["Name"].ToString(),
                    Phone = dr["Phone"].ToString(),
                    Address = dr["Address"].ToString(),
                    Email = dr["Email"].ToString()

                });
            }
            return dt.Rows.Count;
        }
    }
}
