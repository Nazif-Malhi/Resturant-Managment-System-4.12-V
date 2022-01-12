using Spinzer_Managment_System__4._12_V_.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinzer_Managment_System__4._12_V_.ViewModel
{
    public class MaterialViewModel
    {
        public DataToMaterialModel dataToMaterialModel = new DataToMaterialModel
        {
            dataMaterials = new List<MaterialsModel>()
        };
        public int fillingData()
        {

            DataTable dt = DataTableToListClass.getDataFromMaterial();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Nullable<int> qty = 0;
                Nullable<double> weight = 0;
                DataRow dr = dt.Rows[i];

                if (dr["Qty"].ToString() == string.Empty)
                {
                    qty = null;

                }
                else
                {
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
               
                dataToMaterialModel.dataMaterials.Add(new MaterialsModel
                {
                    Id = Convert.ToInt32(dr["id"]),
                    Name = dr["Name"].ToString(),
                    Qty=qty,
                    Weight=weight,
                    ItemId=Convert.ToInt32(dr["Items_Id"])
                });
            }
            return dt.Rows.Count;
        }
    }
}
