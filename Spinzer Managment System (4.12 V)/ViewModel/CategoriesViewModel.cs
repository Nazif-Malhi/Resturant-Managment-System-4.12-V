using Spinzer_Managment_System__4._12_V_.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinzer_Managment_System__4._12_V_.ViewModel
{
   public class CategoriesViewModel
    {
        public DatatoCatModel catModel = new DatatoCatModel
        {
            dataCat = new List<CategoriesModel>()
        };
        public int fillingData()
        {
            DataTable dt = DataTableToListClass.getDataFromSqlMyCategories();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                catModel.dataCat.Add(new CategoriesModel
                {
                    CategoriesID = Convert.ToInt32(dr["id"]),
                    CategoriesName = dr["Name"].ToString(),
                    Availibilty=dr["Availibility"].ToString(),
                });
            }
            return dt.Rows.Count;
        }
    }
}
