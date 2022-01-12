using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinzer_Managment_System__4._12_V_.Model
{
    public class DataToDealsModel {
    public List<DealsModel> dataDealsModel { get; set; }
    }
    public class DealsModel
    {
        private int id;

        public int ID
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

        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

       

    }
}
