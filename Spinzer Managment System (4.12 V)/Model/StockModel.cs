using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinzer_Managment_System__4._12_V_.Model
{
    public class DataToStockModel {
    public List<StockModel> dataStock { get; set; }
    }
    public class StockModel
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int userId;

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
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

       
        private string expiryDate;

        public string ExpiryDate
        {
            get { return expiryDate; }
            set { expiryDate = value; }
        }

        private string description;

        public string Description 
        {
            get { return description; }
            set { description = value; }
        }

        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

    }
}
