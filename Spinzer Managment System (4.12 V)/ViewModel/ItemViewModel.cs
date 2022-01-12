using Spinzer_Managment_System__4._12_V_.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spinzer_Managment_System__4._12_V_.ViewModel
{
    public class ItemViewModel
    {
        public DatatoItemModel itemModel = new DatatoItemModel
        {
            dataItem = new List<ItemsModel>()
        };

        public int fillingData() {
            DataTable dataTable = DataTableToListClass.getDataFromSqlMyItems();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow dr = dataTable.Rows[i];
                itemModel.dataItem.Add(new ItemsModel
                {
                    Id=Convert.ToInt32(dr["id"]),
                    Cat_ID = Convert.ToInt32(dr["Cat_id"]),
                    Item_Name = dr["Name"].ToString(),
                    Price = Convert.ToInt32(dr["Price"]),
                    Availabel=dr["Availibility"].ToString()

                });
            }
            return dataTable.Rows.Count;
        }
        public Tuple<int, string, int,int> fillingData(KeyEventArgs e)
        {
            string result = e.KeyCode.ToString();
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) || (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9))
            {
                result = e.KeyCode.ToString().Substring(e.KeyCode.ToString().Length - 1);
            }
            int length = 0;
            string text = "";
            int price = 0;
            int catID = 0;
            DataTable dt = DataTableToListClass.getSearchDataFromSqlMyCategories(result);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                text = dr["Name"].ToString();

                DataTable dtItem = DataTableToListClass.getDataFromSqlMyItems(Convert.ToInt32(dr["id"]));
                length = dtItem.Rows.Count;
                for (int j = 0; j < dtItem.Rows.Count; j++)
                {
                    DataRow drItem = dtItem.Rows[j];
                    price = Convert.ToInt32(drItem["Price"]);
                    itemModel.dataItem.Add(new ItemsModel
                    {
                        Cat_ID = Convert.ToInt32(drItem["Cat_id"]),
                        Item_Name = drItem["Name"].ToString(),
                        Price = Convert.ToInt32(drItem["Price"])
                    });
                    catID = Convert.ToInt32(drItem["Cat_id"]);
                }
            }
            return new Tuple<int, string, int,int>(length, text, price,catID);
        }
        public Tuple<int, string, int, int> fillingData(string e)
        {
           
            int length = 0;
            string text = "";
            int price = 0;
            int catID = 0;
            DataTable dt = DataTableToListClass.getSearchDataFromSqlMyCategories(e);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                text = dr["Name"].ToString();

                DataTable dtItem = DataTableToListClass.getDataFromSqlMyItems(Convert.ToInt32(dr["id"]));
                length = dtItem.Rows.Count;
                for (int j = 0; j < dtItem.Rows.Count; j++)
                {
                    DataRow drItem = dtItem.Rows[j];
                    price = Convert.ToInt32(drItem["Price"]);
                    itemModel.dataItem.Add(new ItemsModel
                    {
                        Cat_ID = Convert.ToInt32(drItem["Cat_id"]),
                        Item_Name = drItem["Name"].ToString(),
                        Price = Convert.ToInt32(drItem["Price"])
                    });
                    catID = Convert.ToInt32(drItem["Cat_id"]);
                }
            }
            return new Tuple<int, string, int, int>(length, text, price, catID);
        }
    }
}
