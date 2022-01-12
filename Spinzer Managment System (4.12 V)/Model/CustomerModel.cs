using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinzer_Managment_System__4._12_V_.Model
{
    public class DataToCustomerModel
    {
        public List<CustomerModel> dataCustomer { get; set; }
    }
    public class CustomerModel
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

        private string qrCode;

        public string QRCode
        {
            get { return qrCode; }
            set { qrCode = value; }
        }
    }
}
