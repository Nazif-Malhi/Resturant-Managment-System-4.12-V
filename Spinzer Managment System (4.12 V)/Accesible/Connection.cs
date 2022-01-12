using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinzer_Managment_System__4._12_V_.Accesible
{
    public class Connection
    {
        public  SqlConnection conn;

        public Connection() {
            getConnection();
        }
         private static string connectionString = @"Data Source=;Initial Catalog=ResturantManagmentSystem_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
       // private static string connectionString = @"Data Source=DESKTOP-MCSII1E\SQLEXPRESS;Initial Catalog=ResturantManagmentSystem_DB;Integrated Security=true;MultipleActiveResultSets= true;";
        private SqlConnection getConnection() {
             conn = new SqlConnection(connectionString);
            return conn;
        }
    }
}
