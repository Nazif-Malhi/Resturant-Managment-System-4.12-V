using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinzer_Managment_System__4._12_V_.Model
{
    public class DataToDealsItemModel
    {
        public List<DealsItemModel> dataDealsItemModel { get; set; }
    }
    public class DealsItemModel
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private int cat_Id;

        public int Cat_id
        {
            get { return cat_Id; }
            set { cat_Id = value; }
        }

        private int item_id;

        public int Item_id
        {
            get { return item_id; }
            set { item_id = value; }
        }

        private int deals_id;

        public int Deals_id
        {
            get { return deals_id; }
            set { deals_id = value; }
        }
        private int qty;

        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }

    }
}
