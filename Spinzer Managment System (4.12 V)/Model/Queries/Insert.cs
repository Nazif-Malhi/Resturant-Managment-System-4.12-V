 using Spinzer_Managment_System__4._12_V_.Accesible;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spinzer_Managment_System__4._12_V_.Model.Queries
{
    public class Insert
    {
       
        
        static Connection connection = new Connection();

        #region User
        public void InsertUser(string Name, string Email, string phone, string password, string Address, string Authenticated, string Description, int remember)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("InsertUser", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Name", Name);
                sqlCommand.Parameters.AddWithValue("@Email", Email);
                sqlCommand.Parameters.AddWithValue("@phone", phone);
                sqlCommand.Parameters.AddWithValue("@Password", password);
                sqlCommand.Parameters.AddWithValue("@Address", Address);
                sqlCommand.Parameters.AddWithValue("@Authenticated", Authenticated);
                sqlCommand.Parameters.AddWithValue("@Discription", Description);
                sqlCommand.Parameters.AddWithValue("@remember", remember);
                connection.conn.Open();
                sqlCommand.ExecuteNonQuery();
                connection.conn.Close();

            }
            catch (Exception ex)
            {
                connection.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Employee
        public void InsertEmployee(string Name, string Email, string phone, string Address, string dateOFJoining, string Qr_Code, int userID, int salary)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("InsertEmployee", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Name", Name);
                sqlCommand.Parameters.AddWithValue("@Email", Email);
                sqlCommand.Parameters.AddWithValue("@phone", phone);
                sqlCommand.Parameters.AddWithValue("@Address", Address);
                sqlCommand.Parameters.AddWithValue("@DateofJoining", dateOFJoining);
                sqlCommand.Parameters.AddWithValue("@QR_Code", Qr_Code);
                sqlCommand.Parameters.AddWithValue("@User_id", userID);
                sqlCommand.Parameters.AddWithValue("@Salary", salary);
                connection.conn.Open();
                sqlCommand.ExecuteNonQuery();
                connection.conn.Close();

            }
            catch (Exception ex)
            {
                connection.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Items
        public void InsertItems(string Name, int cat_Id, string availibilty, int price)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("InsertItems", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Name", Name);
                sqlCommand.Parameters.AddWithValue("@cat_id", cat_Id);
                sqlCommand.Parameters.AddWithValue("@Availibility", availibilty);
                sqlCommand.Parameters.AddWithValue("@price", price);
                connection.conn.Open();
                sqlCommand.ExecuteNonQuery();
                connection.conn.Close();

            }
            catch (Exception ex)
            {
                connection.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void InsertMaterialWithQty(string name, int qty, int itemId)
        {

            try
            {
                SqlCommand sqlCommand = new SqlCommand("InsertMaterialsWithQty", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Name", name);
                sqlCommand.Parameters.AddWithValue("@Qty", qty);
                sqlCommand.Parameters.AddWithValue("@ItemsId", itemId);
                connection.conn.Open();
                sqlCommand.ExecuteNonQuery();
                connection.conn.Close();
            }
            catch (Exception ex)
            {
                connection.conn.Close();
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Saved");
        }
        public void InsertMaterialWithWeight(string name, double weight, int itemId)
        {
            try
            {

                SqlCommand sqlCommand = new SqlCommand("InsertMaterialsWithWeight", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Name", name);
                sqlCommand.Parameters.AddWithValue("@Weight", weight);
                sqlCommand.Parameters.AddWithValue("@ItemsId", itemId);
                connection.conn.Open();
                sqlCommand.ExecuteNonQuery();
                connection.conn.Close();

            }
            catch (Exception ex)
            {
                connection.conn.Close();
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Saved");
        }
        #endregion
        #region Category
        public void InsertCategory(string Name, string availibilty, int UserID)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("InsertCategory", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Name", Name);
                sqlCommand.Parameters.AddWithValue("@Availbilty", availibilty);
                sqlCommand.Parameters.AddWithValue("@User_id", UserID);
                connection.conn.Open();
                sqlCommand.ExecuteNonQuery();
                connection.conn.Close();
            }
            catch (Exception ex)
            {
                connection.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Customer
        public void InsertCustomer(string Name, string Email, string phone, string Address, int userID, string Qr_Code)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("InsertCustomer", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Name", Name);
                sqlCommand.Parameters.AddWithValue("@Email", Email);
                sqlCommand.Parameters.AddWithValue("@phone", phone);
                sqlCommand.Parameters.AddWithValue("@Address", Address);
                sqlCommand.Parameters.AddWithValue("@User_id", userID);
                sqlCommand.Parameters.AddWithValue("@QR_Code", Qr_Code);
                connection.conn.Open();
                sqlCommand.ExecuteNonQuery();
                connection.conn.Close();
                MessageBox.Show("Succesfully inserted Customer");
            }
            catch (Exception ex)
            {
                connection.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void InsertCustomerOrder(string invoice,string Name, string Email, string phone, string Address)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("InsertCustomerOrder", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Invoice_QRCode", invoice);
                sqlCommand.Parameters.AddWithValue("@Name", Name);
                sqlCommand.Parameters.AddWithValue("@Email", Email);
                sqlCommand.Parameters.AddWithValue("@phone", phone);
                sqlCommand.Parameters.AddWithValue("@Address", Address);
                connection.conn.Open();
                sqlCommand.ExecuteNonQuery();
                connection.conn.Close();
            }
            catch (Exception ex)
            {
                connection.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Stock
        public void InsertStockWithQTY(int UserId, string name, int qty, string expiryDate, string description, int price)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("InsertStockWithQty", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@UserId", UserId);
                sqlCommand.Parameters.AddWithValue("@Name", name);
                sqlCommand.Parameters.AddWithValue("@Qty", qty);
                sqlCommand.Parameters.AddWithValue("@Price", price);
                sqlCommand.Parameters.AddWithValue("@ExpiryDate", expiryDate);
                sqlCommand.Parameters.AddWithValue("@Description", description);
                connection.conn.Open();
                sqlCommand.ExecuteNonQuery();
                connection.conn.Close();
            }
            catch (Exception ex)
            {
                connection.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void InsertStockWithWeight(int UserId, string name, double weight, string expiryDate, string description, int price)
        {
            Decimal ert = Convert.ToDecimal(weight);
            try
            {
                SqlCommand sqlCommand = new SqlCommand("InsertStockWithWeight", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@UserId", UserId);
                sqlCommand.Parameters.AddWithValue("@Name", name);
                sqlCommand.Parameters.AddWithValue("@Weight", ert);
                sqlCommand.Parameters.AddWithValue("@ExpiryDate", expiryDate);
                sqlCommand.Parameters.AddWithValue("@Price", price);
                sqlCommand.Parameters.AddWithValue("@Description", description);
                connection.conn.Open();
                sqlCommand.ExecuteNonQuery();
                connection.conn.Close();
            }
            catch (Exception ex)
            {
                connection.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        #endregion


        public void InsertUsedStockWithQty(int stockId,int qty) {
            try
            {
                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                SqlCommand sqlCommand = new SqlCommand("InsertUsedStockWithQty", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@StockId", stockId);
                sqlCommand.Parameters.AddWithValue("@EntryDate", sqlFormattedDate);
                sqlCommand.Parameters.AddWithValue("@Qty", qty);
                connection.conn.Open();
                sqlCommand.ExecuteNonQuery();
                connection.conn.Close();
            }
            catch (Exception ex)
            {
                connection.conn.Close();
                throw ex;
            }
        }
        public void InsertUsedStockWithWeight(int stockId, double weight) {
            try
            {
                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                SqlCommand sqlCommand = new SqlCommand("InsertUsedStockWithWeight", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@StockId", stockId);
                sqlCommand.Parameters.AddWithValue("@EntryDate", sqlFormattedDate);
                sqlCommand.Parameters.AddWithValue("@Weight", weight);
                connection.conn.Open();
                sqlCommand.ExecuteNonQuery();
                connection.conn.Close();
            }
            catch (Exception ex)
            {
                connection.conn.Close();
                throw ex;
            }
        }
        public void InsertUpdateStockWithQty(int stockId, int qty,int price)
        {
            try
            {
                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                SqlCommand sqlCommand = new SqlCommand("InsertEnteredStockWithQty", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Stock_Id", stockId);
                sqlCommand.Parameters.AddWithValue("@EnteredDate", sqlFormattedDate);
                sqlCommand.Parameters.AddWithValue("@EnteredQty", qty);
                sqlCommand.Parameters.AddWithValue("@Price", price);
                connection.conn.Open();
                sqlCommand.ExecuteNonQuery();
                connection.conn.Close();
            }
            catch (Exception ex)
            {
                connection.conn.Close();
                throw ex;
            }
        }
        public void InsertUpdateStockWithWeight(int stockId, double weight,int price)
        {
            try
            {
                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                SqlCommand sqlCommand = new SqlCommand("InsertEnteredStockWithWeight", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Stock_Id", stockId);
                sqlCommand.Parameters.AddWithValue("@EnteredDate", sqlFormattedDate);
                sqlCommand.Parameters.AddWithValue("@EnteredWeight", weight);
                sqlCommand.Parameters.AddWithValue("@Price", price);
                connection.conn.Open();
                sqlCommand.ExecuteNonQuery();
                connection.conn.Close();
            }
            catch (Exception ex)
            {
                connection.conn.Close();
                throw ex;
            }
        }

       
        public void InsertOrders( int itemPrice,int userid,int itemId,int catId,string qrCode,int qty,int dilivery,int discOneach,int discOnFull)
        {
            try
            {
                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                SqlCommand sqlCommand = new SqlCommand("InsertOrders", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Date", sqlFormattedDate);
                sqlCommand.Parameters.AddWithValue("@itemPrice", itemPrice);
                sqlCommand.Parameters.AddWithValue("@diliveryCharges", dilivery);
                sqlCommand.Parameters.AddWithValue("@discOnEach", discOneach);
                sqlCommand.Parameters.AddWithValue("@discOnFull", discOnFull);
                sqlCommand.Parameters.AddWithValue("@UserId", userid);
                sqlCommand.Parameters.AddWithValue("@ItemId", itemId);
                sqlCommand.Parameters.AddWithValue("@Catid", catId);
                sqlCommand.Parameters.AddWithValue("@QrCode", qrCode);
                sqlCommand.Parameters.AddWithValue("@qty", qty);
                connection.conn.Open();
                sqlCommand.ExecuteNonQuery();
                connection.conn.Close();

            }
            catch (Exception ex)
            {
                connection.conn.Close();
                MessageBox.Show(ex.Message);
            }

        }
        public void InsertDeals(string Name, int price)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("InsertDeals", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Name", Name);
                sqlCommand.Parameters.AddWithValue("@Price", price);
                connection.conn.Open();
                sqlCommand.ExecuteNonQuery();
                connection.conn.Close();

            }
            catch (Exception ex)
            {
                connection.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void InsertDealsItem(int item_id, int cat_id, int deals_id,int qty)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("InsertDealsItem", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Cat_id", cat_id);
                sqlCommand.Parameters.AddWithValue("@Item_id", item_id);
                sqlCommand.Parameters.AddWithValue("@Deals_id", deals_id);
                sqlCommand.Parameters.AddWithValue("@Qty", qty);
                connection.conn.Open();
                sqlCommand.ExecuteNonQuery();
                connection.conn.Close();

            }
            catch (Exception ex)
            {
                connection.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
