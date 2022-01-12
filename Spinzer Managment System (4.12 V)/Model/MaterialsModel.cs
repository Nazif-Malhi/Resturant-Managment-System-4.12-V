using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinzer_Managment_System__4._12_V_.Model
{
    public class DataToMaterialModel {
      public List<MaterialsModel> dataMaterials { get; set; }
    }
    public class MaterialsModel
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Nullable<int> qty;

        public Nullable<int> Qty
        {
            get { return qty; }
            set { qty = value; }
        }

        private Nullable<double> weight;     

        public Nullable<double> Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        private int itemId;

        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }



    }
}
