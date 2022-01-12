using Spinzer_Managment_System__4._12_V_.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinzer_Managment_System__4._12_V_.ViewModel
{
    public class UserViewModel
    {
        public DatatoUserModel userModel = new DatatoUserModel
        {
            dataUser = new List<UserModel>()
        };

        public int fillingData()
        {
           
            DataTable dt = DataTableToListClass.getDataFromUsers();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                userModel.dataUser.Add(new UserModel
                {
                    Id = Convert.ToInt32(dr["id"]),
                    Name = dr["Name"].ToString(),
                    Email = dr["Email"].ToString(),
                    Phone = dr["Phone"].ToString(),
                    Password = dr["Password"].ToString(),
                    Address = dr["Address"].ToString(),
                    Authentication = dr["Authenticated"].ToString(),
                    Description = dr["Discription"].ToString(),
                    Remember = Convert.ToInt32(dr["remember"])
                });
            }
            return dt.Rows.Count;
        }
        public int fillingDataById(int id)
        {
            DataTable dt = DataTableToListClass.getDataFromUserByID(id);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                userModel.dataUser.Add(new UserModel
                {
                    Id = Convert.ToInt32(dr["id"]),
                    Name = dr["Name"].ToString(),
                    Email = dr["Email"].ToString(),
                    Phone = dr["Phone"].ToString(),
                    Password = dr["Password"].ToString(),
                    Address = dr["Address"].ToString(),
                    Authentication = dr["Authenticated"].ToString(),
                    Description = dr["Discription"].ToString(),
                    Remember = Convert.ToInt32(dr["remember"])
                });
            }
            return dt.Rows.Count;
        }
    }
}
