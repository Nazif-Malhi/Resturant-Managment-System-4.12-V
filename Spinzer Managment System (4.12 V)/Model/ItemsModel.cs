using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinzer_Managment_System__4._12_V_.Model
{
    public class DatatoItemModel
    {
        public List<ItemsModel> dataItem { get; set; }
    }
    public class ItemsModel
    {

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int catId;

        public int Cat_ID
        {
            get { return catId; }
            set { catId = value; }
        }

        private string itemName;

        public string Item_Name
        {
            get { return itemName; }
            set { itemName = value; }
        }
        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        private string availabel;

        public string Availabel
        {
            get { return availabel; }
            set { availabel = value; }
        }





    }
}
