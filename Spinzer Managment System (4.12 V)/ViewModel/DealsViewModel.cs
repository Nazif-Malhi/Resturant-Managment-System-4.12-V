using Spinzer_Managment_System__4._12_V_.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinzer_Managment_System__4._12_V_.ViewModel
{
    public class DealsViewModel
    {
        public DataToDealsModel dataDeals = new DataToDealsModel
        {
            dataDealsModel = new List<DealsModel>()
        };
        public int fillingData()
        {
            DataTable dt = DataTableToListClass.getDataFromDeals();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                dataDeals.dataDealsModel.Add(new DealsModel
                {
                    ID = Convert.ToInt32(dr["id"]),
                    Name = dr["Name"].ToString(),
                    Price = Convert.ToInt32(dr["price"]),
                });
            }
            return dt.Rows.Count;
        }

    }
}
