using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinzer_Managment_System__4._12_V_.Model
{
    public class DatatoOrdersModel
    {
        public List<OrdersModel> dataOrders { get; set; }
    }

    public class OrdersModel
    {
        private int invoice;

        public int Invoice
        {
            get { return invoice; }
            set { invoice = value; }
        }
        private string date;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        private int itemPrice;

        public int ItemPrice
        {
            get { return itemPrice; }
            set { itemPrice = value; }
        }
        private int discOnEach;

        public int DiscOnEach
        {
            get { return discOnEach; }
            set { discOnEach = value; }
        }

        private int discOnFull;

        public int DiscOnFull
        {
            get { return discOnFull; }
            set { discOnFull = value; }
        }

        private int deliveryCharges;

        public int DelevieryCharges
        {
            get { return deliveryCharges; }
            set { deliveryCharges = value; }
        }

        private int itemId;

        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

        private int catId;

        public int CatId
        {
            get { return catId; }
            set { catId = value; }
        }

        private string qrCode;

        public string QRCode
        {
            get { return qrCode; }
            set { qrCode = value; }
        }
        private int qty;

        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }



    }
}
