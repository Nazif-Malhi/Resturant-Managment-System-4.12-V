using Spinzer_Managment_System__4._12_V_.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinzer_Managment_System__4._12_V_.ViewModel
{

    public class CustomerViewModel
    {
        public DataToCustomerModel dataToCustomerModel = new DataToCustomerModel
        {
            dataCustomer = new List<CustomerModel>()
        };
        public int fillingData()
        {
            DataTable dt = DataTableToListClass.getDataFromCustomers();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                dataToCustomerModel.dataCustomer.Add(new CustomerModel
                {
                    ID = Convert.ToInt32(dr["id"]),
                    Name = dr["Name"].ToString(),
                    Phone = dr["Phone"].ToString(),
                    Address = dr["Address"].ToString(),
                    Email = dr["Email"].ToString(),
                    QRCode = dr["QR_Code"].ToString()

                });
            }
            return dt.Rows.Count;
        }
    }
}
