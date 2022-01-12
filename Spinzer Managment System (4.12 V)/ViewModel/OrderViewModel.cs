using Spinzer_Managment_System__4._12_V_.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinzer_Managment_System__4._12_V_.ViewModel
{

    
    public class OrderViewModel
    {
        public DatatoOrdersModel ordersModel = new DatatoOrdersModel
        {
            dataOrders = new List<OrdersModel>()
        };
        public string fillingData()
        {
            #region MyRegion
            /*DataTable dataTable = DataTableToListClass.getDataLastOrders();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow dr = dataTable.Rows[i];
                ordersModel.dataOrders.Add(new OrdersModel
                {

                    Invoice = Convert.ToInt32(dr["invoice"]),
                    Date = (dr["Date"]).ToString(),
                    ItemPrice = Convert.ToInt32(dr["Item_Price"]),
                    DiscOnEach = Convert.ToInt32(dr["DiscOn_Each"]),
                    DiscOnFull = Convert.ToInt32(dr["DiscOn_Full"]),
                    DelevieryCharges = Convert.ToInt32(dr["DiliveryCharges"]),
                    ItemId = Convert.ToInt32(dr["Item_id"]),
                    CatId = Convert.ToInt32(dr["Cat_id"]),
                    QRCode = dr["QR_Code"].ToString(),
                    Qty = Convert.ToInt32(dr["qty"])

                });
            }*/
            #endregion
            return DataTableToListClass.getDataLastOrders();
        }
        public int AllfillingData()
        {
            DataTable dataTable = DataTableToListClass.getOrders();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow dr = dataTable.Rows[i];
                ordersModel.dataOrders.Add(new OrdersModel
                {

                    Invoice = Convert.ToInt32(dr["invoice"]),
                    Date = (dr["Date"]).ToString(),
                    ItemPrice = Convert.ToInt32(dr["Item_Price"]),
                    DiscOnEach = Convert.ToInt32(dr["DiscOn_Each"]),
                    DiscOnFull = Convert.ToInt32(dr["DiscOn_Full"]),
                    DelevieryCharges = Convert.ToInt32(dr["DiliveryCharges"]),
                    ItemId = Convert.ToInt32(dr["Item_id"]),
                    CatId = Convert.ToInt32(dr["Cat_id"]),
                    QRCode = dr["QR_Code"].ToString(),
                    Qty = Convert.ToInt32(dr["qty"])

                });
            }
            return dataTable.Rows.Count;
        }
    }

}
