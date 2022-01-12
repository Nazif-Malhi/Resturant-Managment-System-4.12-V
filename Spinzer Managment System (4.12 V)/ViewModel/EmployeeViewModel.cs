using Spinzer_Managment_System__4._12_V_.Model;
using Spinzer_Managment_System__4._12_V_.Model.Queries;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinzer_Managment_System__4._12_V_.ViewModel
{
    public class EmployeeViewModel
    {
       public DataToEmployeeModel dataToEmployeeModel = new DataToEmployeeModel
       {
           dataEmployee = new List<EmployeeModel>()
       };
       public int fillingData() {
            DataTable dt = DataTableToListClass.getDataFromEmployees();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                dataToEmployeeModel.dataEmployee.Add(new EmployeeModel
                {
                    ID = Convert.ToInt32(dr["id"]),
                    Name = dr["Name"].ToString(),
                    Phone = dr["Phone"].ToString(),
                    Address = dr["Address"].ToString(),
                    DateOfJoining = dr["Date_of_Joining"].ToString(),
                    QRCode = dr["QR_Code"].ToString()

                });
            }
            return dt.Rows.Count;
        }
    }
}
