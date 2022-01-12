using Spinzer_Managment_System__4._12_V_.Accesible;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Spinzer_Managment_System__4._12_V_.Model.Queries
{
    public class Update
    {
        static Connection connection = new Connection();

        #region User
        public void UpdateUser(int id, string Name, string Email, string phone, string password, string Address, string Authenticated, string Description, int remember)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("UpdateUser", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", id);
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
                //MessageBox.Show(Name + " Has Been Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Employee
        public void UpdateEmployee(int id, string Name, string Email, string phone, string Address, string dateOFJoining, string Qr_Code, int userID, int salary)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("UpdateEmployee", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", id);
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
                MessageBox.Show(Name + " Has Been Updated");

            }
            catch (Exception ex)
            {
                connection.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Category
        public void UpdateCategory(int idToBeUpdated, string Name, string availibilty, int UserID)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("UpdateCategory", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", idToBeUpdated);
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
        #region Items
        public void UpdateItems(int id, string Name, int cat_Id, string availibilty, int price)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("UpdateItems", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", id);
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

        #endregion
        #region Customer
        public void UpdateCustomer(int id ,string Name, string Email, string phone, string Address, int userID, string Qr_Code)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("UpdateCustomer", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Parameters.AddWithValue("@Name", Name);
                sqlCommand.Parameters.AddWithValue("@Email", Email);
                sqlCommand.Parameters.AddWithValue("@phone", phone);
                sqlCommand.Parameters.AddWithValue("@Address", Address);
                sqlCommand.Parameters.AddWithValue("@User_id", userID);
                sqlCommand.Parameters.AddWithValue("@QR_Code", Qr_Code);
                connection.conn.Open();
                sqlCommand.ExecuteNonQuery();
                connection.conn.Close();
                MessageBox.Show("Updated Succesfully");
            }
            catch (Exception ex)
            {
                connection.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Stock
        public void UpdateStockWithQTY(int id,int UserId, string name, int qty, string expiryDate, string description, int price)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("UpdateStockWithQty", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Id", id);
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
        public void UpdateStockWithWeight(int id,int UserId, string name, double weight, string expiryDate, string description, int price)
        {
            Decimal ert = Convert.ToDecimal(weight);
            try
            {
                SqlCommand sqlCommand = new SqlCommand("UpdateStockWithWeight", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Id", id);
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

        #region Deals
        public void UpdateDeals(int id, string Name, int price)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("UpdateDeals", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", id);
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
        #endregion

        #region invoice
        public void UpdateInvoice(int id, int invoioce)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("updateInvoice", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Parameters.AddWithValue("@invoiceNumber", invoioce);
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

    }
}
