using Spinzer_Managment_System__4._12_V_.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinzer_Managment_System__4._12_V_.ViewModel
{
    public class DealsItemViewModel
    {
        public DataToDealsItemModel dataDealsItem = new DataToDealsItemModel
        {
            dataDealsItemModel = new List<DealsItemModel>()
        };
        public int fillingData()
        {
            DataTable dt = DataTableToListClass.getDataFromDealsItem();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                dataDealsItem.dataDealsItemModel.Add(new DealsItemModel
                {
                    ID = Convert.ToInt32(dr["id"]),
                    Cat_id = Convert.ToInt32(dr["Cat_id"]),
                    Item_id = Convert.ToInt32(dr["Item_id"]),
                    Deals_id=Convert.ToInt32(dr["Deals_id"]),
                    Qty=Convert.ToInt32(dr["Qty"])
                });
            }
            return dt.Rows.Count;
        }
    }
}
