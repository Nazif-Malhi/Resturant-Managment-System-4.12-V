using Spinzer_Managment_System__4._12_V_.Accesible;
using Spinzer_Managment_System__4._12_V_.Model;
using Spinzer_Managment_System__4._12_V_.Model.Queries;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spinzer_Managment_System__4._12_V_.ViewModel
{
    public class StockViewModel
    {
        static Connection connection = new Connection();
        public DataToStockModel stockModel = new DataToStockModel
        {
            dataStock = new List<StockModel>()
        };

        public DataTable fillingData() {
            DataTable dt = DataTableToListClass.getDataFromSqlStock();
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Nullable<int> qty=0;
                Nullable<double> weight = 0;
                DataRow dr = dt.Rows[i];

                if (dr["Qty"].ToString() == string.Empty)
                {
                    qty = null;
                   
                }
                else {
                   qty = Convert.ToInt32(dr["Qty"]);
                   
                }
                if (dr["Weight"].ToString() == string.Empty)
                {
                    weight = null;
                    
                }
                else
                {
                    weight = Convert.ToDouble(dr["Weight"]);
                   
                }
                    stockModel.dataStock.Add(new StockModel
                    {
                        Id = Convert.ToInt32(dr["id"]),
                        UserId = Convert.ToInt32(dr["User_id"]),
                        Name = dr["Name"].ToString(),
                        Qty = qty,
                        Weight = weight,
                        ExpiryDate = dr["Expiry_Date"].ToString(),
                        Description = dr["Description"].ToString(),
                        Price=Convert.ToInt32(dr["Price"])
                    });
                    
               

            }
            return dt;
        }

        
        public static void transactionBegin(string value, string method, int id, int UserId, string name, string expiryDate, string description, int price,string valueFromTextBox)
        {
            connection.conn.Open();
            Update update = new Update();
            Insert insert = new Insert();
            SqlTransaction sqlTransaction = connection.conn.BeginTransaction();
            try
            {
                if (method == "qty")
                {
                    int newValue = Convert.ToInt32(value);
                    int usedValue = Convert.ToInt32(valueFromTextBox);
                    update.UpdateStockWithQTY(id, UserId, name, newValue, expiryDate, description, price);
                    insert.InsertUsedStockWithQty(id, usedValue);
                    sqlTransaction.Commit();
                }
                else if (method == "weight")
                {
                    double newValue = Convert.ToDouble(value);
                    double usedValue = Convert.ToDouble(valueFromTextBox);
                    update.UpdateStockWithWeight(id, UserId, name, newValue, expiryDate, description, price);
                    insert.InsertUsedStockWithWeight(id, usedValue);
                    sqlTransaction.Commit();
                }
                connection.conn.Close();
                MessageBox.Show("Used Stock Is Entered");
            }
            catch (Exception ex)
            {
                sqlTransaction.Rollback();
                connection.conn.Close();
                MessageBox.Show(ex.Message);
                MessageBox.Show("Failed");
            }
        }

        public static void transactionBeginForUpdateStock(string value, string method, int id, int UserId, string name, string expiryDate, string description, int price, string valueFromTextBox,int newPrice)
        {
            connection.conn.Open();
            Update update = new Update();
            Insert insert = new Insert();
            SqlTransaction sqlTransaction = connection.conn.BeginTransaction();
            try
            {
                if (method == "qty")
                {
                    int newValue = Convert.ToInt32(value);
                    int usedValue = Convert.ToInt32(valueFromTextBox);
                    update.UpdateStockWithQTY(id, UserId, name, newValue, expiryDate, description, price);
                    insert.InsertUpdateStockWithQty(id, usedValue, newPrice);
                    
                }
                else if (method == "weight")
                {
                    double newValue = Convert.ToDouble(value);
                    double usedValue = Convert.ToDouble(valueFromTextBox);
                    update.UpdateStockWithWeight(id, UserId, name, newValue, expiryDate, description, price);
                    insert.InsertUpdateStockWithWeight(id, usedValue,newPrice);
                   
                }
                sqlTransaction.Commit();
                connection.conn.Close();
                MessageBox.Show(" Stock Is Update");
            }
            catch (Exception ex)
            {
                sqlTransaction.Rollback();
                connection.conn.Close();
                MessageBox.Show(ex.Message);
                MessageBox.Show("Failed");
            }
        }
    }
}
