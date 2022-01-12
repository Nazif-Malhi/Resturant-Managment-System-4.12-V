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
   public class Delete
    {
        static Connection connection = new Connection();
        public void DeleteEntites(int id) {
            try
            {
                connection.conn.Open();
                SqlCommand sqlCommand = new SqlCommand("DeleteUsers", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.ExecuteNonQuery();
                connection.conn.Close();
                MessageBox.Show("Delete Successfully");
            }
            catch (Exception ex)
            {

                connection.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteEmployee(int id)
        {
            try
            {
                connection.conn.Open();
                SqlCommand sqlCommand = new SqlCommand("DeleteEmployee", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.ExecuteNonQuery();
                connection.conn.Close();
                MessageBox.Show("Delete Successfully");
            }
            catch (Exception ex)
            {

                connection.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteCategory(int id)
        {
            try
            {
                connection.conn.Open();
                SqlCommand sqlCommand = new SqlCommand("DeleteCategory", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.ExecuteNonQuery();
                connection.conn.Close();
                MessageBox.Show("Delete Successfully");
            }
            catch (Exception ex)
            {

                connection.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteCustomers(string id)
        {
            try
            {
                connection.conn.Open();
                SqlCommand sqlCommand = new SqlCommand("DeleteCustomer", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.ExecuteNonQuery();
                connection.conn.Close();
                MessageBox.Show("Deleted Succesfully");
            }
            catch (Exception ex)
            {

                connection.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteStock(int id)
        {
            try
            {
                connection.conn.Open();
                SqlCommand sqlCommand = new SqlCommand("DeleteStock", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.ExecuteNonQuery();
                connection.conn.Close();
                MessageBox.Show("Delete Successfully");
            }
            catch (Exception ex)
            {

                connection.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteOrder(string id)
        {
            try
            {
                connection.conn.Open();
                SqlCommand sqlCommand = new SqlCommand("DeleteOrder", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", id + "%");
                sqlCommand.ExecuteNonQuery();
                connection.conn.Close();
                MessageBox.Show("Delete Successfully");
            }
            catch (Exception ex)
            {

                connection.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteDeals(string id)
        {
            try
            {
                connection.conn.Open();
                SqlCommand sqlCommand = new SqlCommand("DeleteDeals", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.ExecuteNonQuery();
                connection.conn.Close();
                MessageBox.Show("Delete Successfully");
            }
            catch (Exception ex)
            {

                connection.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteDealsItems(string id)
        {
            try
            {
                connection.conn.Open();
                SqlCommand sqlCommand = new SqlCommand("DeleteDealsItems", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Deals_id", id);
                sqlCommand.ExecuteNonQuery();
                connection.conn.Close();
                MessageBox.Show("Delete Successfully");
            }
            catch (Exception ex)
            {

                connection.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteItems(string id)
        {
            try
            {
                connection.conn.Open();
                SqlCommand sqlCommand = new SqlCommand("DeleteItems", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.ExecuteNonQuery();
                connection.conn.Close();
                MessageBox.Show("Deleted Succesfully");
            }
            catch (Exception ex)
            {

                connection.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteMaterials(string id)
        {
            try
            {
                connection.conn.Open();
                SqlCommand sqlCommand = new SqlCommand("DeleteMaterials", connection.conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@item_id", id);
                sqlCommand.ExecuteNonQuery();
                connection.conn.Close();
                //not used to inform delete because again it will insert
            }
            catch (Exception ex)
            {

                connection.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        



    }

}
