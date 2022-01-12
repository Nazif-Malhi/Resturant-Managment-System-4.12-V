using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinzer_Managment_System__4._12_V_.Model
{
    public class DataToCustomerOrderModel
    {
        public List<CustomerOrderModel> dataCustomerOrder { get; set; }
    }
    public class CustomerOrderModel
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string invoice;

        public string Invoice
        {
            get { return invoice; }
            set { invoice = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}
