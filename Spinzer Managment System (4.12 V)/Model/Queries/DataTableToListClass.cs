using Spinzer_Managment_System__4._12_V_.Accesible;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Spinzer_Managment_System__4._12_V_.Model
{
    class DataTableToListClass
    {
        static Connection connection = new Connection();

        public static DataTable getDataFromUsers()
        {
            DataTable dt = new DataTable();

            connection.conn.Open();
            using (SqlCommand cmd = new SqlCommand("Select * From dbo.Users", connection.conn))
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            connection.conn.Close();
            return dt;
        }
        public static DataTable getDataFromUserByID(int id)
        {
            DataTable dt = new DataTable();

            connection.conn.Open();
            using (SqlCommand cmd = new SqlCommand("Select * From dbo.Users where id=" + id, connection.conn))
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            connection.conn.Close();
            return dt;
        }
        public static DataTable getDataFromEmployees()
        {
            DataTable dt = new DataTable();

            connection.conn.Open();
            using (SqlCommand cmd = new SqlCommand("Select * From dbo.Employee", connection.conn))
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            connection.conn.Close();
            return dt;
        }

        public static DataTable getDataFromCustomers()
        {
            DataTable dt = new DataTable();

            connection.conn.Open();
            using (SqlCommand cmd = new SqlCommand("Select * From dbo.Customer", connection.conn))
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            connection.conn.Close();
            return dt;
        }

        public static DataTable getDataFromCustomersOrder()
        {
            DataTable dt = new DataTable();

            connection.conn.Open();
            using (SqlCommand cmd = new SqlCommand("Select * From dbo.CustomerOrder", connection.conn))
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            connection.conn.Close();
            return dt;
        }

        #region Others Not included
        public static DataTable getDataFromSqlMyTable()
        {
            DataTable dt = new DataTable();

            connection.conn.Open();
            using (SqlCommand cmd = new SqlCommand("Select * from myTable", connection.conn))
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            connection.conn.Close();
            return dt;
        }
        public static DataTable getDataFromSqlMyCategories()
        {
            DataTable dt = new DataTable();
            connection.conn.Open();
            using (SqlCommand cmd = new SqlCommand("Select * from Category", connection.conn))
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

            }
            connection.conn.Close();
            return dt;

        }
        public static DataTable getDataFromSqlMyItems(int id)
        {
            DataTable dt = new DataTable();
            connection.conn.Open();
            using (SqlCommand cmd = new SqlCommand("Select * from Items where Cat_id = " + id, connection.conn))
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

            }
            connection.conn.Close();
            return dt;

        }
        public static DataTable getDataFromSqlMyItems()
        {
            DataTable dt = new DataTable();
            connection.conn.Open();
            using (SqlCommand cmd = new SqlCommand("Select * from Items", connection.conn))
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            connection.conn.Close();
            return dt;

        }
        public static DataTable getSearchDataFromSqlMyCategories(string args)
        {
            DataTable dt = new DataTable();
            connection.conn.Open();
            using (SqlCommand cmd = new SqlCommand("Select * from Category where Name like '" + args + "%'", connection.conn))
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            connection.conn.Close();
            return dt;
        }
        #endregion 
        public static DataTable getDataFromSqlStock()
        {
            DataTable dt = new DataTable();
            connection.conn.Open();
            using (SqlCommand cmd = new SqlCommand("Select * from Stock", connection.conn))
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            connection.conn.Close();
            return dt;
        }

        #region Materials
        public static DataTable getDataFromMaterial()
        {
            DataTable dt = new DataTable();
            connection.conn.Open();
            using (SqlCommand cmd = new SqlCommand("Select * from Materials", connection.conn))
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            connection.conn.Close();
            return dt;
        }
        #endregion

        #region Orders

        public static string getDataLastOrders()
        {
            //DataTable dt = new DataTable();
            string qrCode = "";
            //string dealName = "";
            //List<string> uniqueList;
            //List<string> items = new List<string>();
            //List<string> deals = new List<string>();
            connection.conn.Open();

            using (SqlCommand command = new SqlCommand("SELECT TOP 1  QR_Code FROM Orders ORDER BY invoice desc", connection.conn))
            {
                //
                // Invoke ExecuteReader method.
                //
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    qrCode = reader.GetString(0);
                }
                connection.conn.Close();
            }
            #region MyRegion
            //if (qrCode == string.Empty)
            //{
            //    MessageBox.Show("Not lefted any order");
            //    //return dt;
            //}
            //else
            //{
            //    #region MyRegion
            //    //connection.conn.Open();
            //    //try
            //    //{


            //    //    string[] split = qrCode.Split('-');

            //    //    using (SqlCommand cmd = new SqlCommand("select QR_Code from Orders where QR_Code like '" + split[0] + "%'", connection.conn))
            //    //    {
            //    //        SqlDataReader reader = cmd.ExecuteReader();


            //    //        while (reader.Read())
            //    //        {
            //    //            items.Add(reader.GetString(0));
            //    //        }
            //    //        uniqueList = items.Distinct().ToList();


            //    //    }
            //    //    connection.conn.Close();
            //    //    foreach (string item in uniqueList)
            //    //    {
            //    //        string[] split1 = item.Split('-');
            //    //        MessageBox.Show(item.ToString());
            //    //        if (split1.Length > 1)
            //    //        {
            //    //            using (SqlCommand cmd = new SqlCommand("select qty from Orders where QR_Code = '" + item , connection.conn))
            //    //            {
            //    //                SqlDataReader reader = cmd.ExecuteReader();


            //    //                while (reader.Read())
            //    //                {
            //    //                    deals.Add(split1[1] + "-" + reader.GetString(0));
            //    //                }
            //    //            }
            //    //        }
            //    //        else
            //    //        {
            //    //            MessageBox.Show("Not-Contains");
            //    //        }
            //    //    }

            //    //}
            //    //catch (Exception ex)
            //    //{
            //    //    connection.conn.Close();
            //    //    MessageBox.Show(ex.Message);

            //    //}
            //    #endregion

            //}
            #endregion

            string[] split = qrCode.Split('-');
            return split[0];
        }
       
        public static DataTable getOrders()
        {

            DataTable dt = new DataTable();
            connection.conn.Open();
            using (SqlCommand cmd = new SqlCommand("Select * from Orders ", connection.conn))
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            connection.conn.Close();
            return dt;
        }
        public static DataTable getDailyOrderReport()
        {

            DataTable dt = new DataTable();
            var today = DateTime.Now.Date.AddDays(-1).AddHours(13).ToString("yyyy-MM-dd HH:mm:ss.fff");

            var yesterday = DateTime.Now.Date.AddHours(13).ToString("yyyy-MM-dd HH:mm:ss.fff");
            MessageBox.Show(today + "   " + yesterday.ToString());
            connection.conn.Open();
            string hj = "SELECT Sum(qty)  as [Count All Items] ,Item_id FROM Orders where Date Between '" + yesterday.ToString() + "' and '" + yesterday.ToString() + "' Group by Item_id order by [Count All Items] desc ";
            // MessageBox.Show(hj.ToString());
            using (SqlCommand cmd = new SqlCommand("SELECT Sum(qty)  as [Count All Items] ,Item_id FROM Orders where Date Between '" + today.ToString() + "' and '" + yesterday.ToString() + "' Group by Item_id order by[Count All Items] desc", connection.conn))
            {
                //
               SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            connection.conn.Close();
            return dt;
        }
        #endregion
        public static DataTable getDataFromDeals()
        {
            DataTable dt = new DataTable();

            connection.conn.Open();
            using (SqlCommand cmd = new SqlCommand("Select * From Deals", connection.conn))
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            connection.conn.Close();
            return dt;
        }

        public static DataTable getDataFromDealsItem() {
            DataTable dt = new DataTable();

            connection.conn.Open();
            using (SqlCommand cmd = new SqlCommand("Select * From DealsItem", connection.conn))
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            connection.conn.Close();
            return dt;
        }

        public static int getDataFromInvoiceTable()
        {
            int id = -1;
            connection.conn.Open();
            using (SqlCommand command = new SqlCommand("Select invoice from invoiceTable where id = 0", connection.conn))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                connection.conn.Close();
            }
            return id;
        }
    }
}
