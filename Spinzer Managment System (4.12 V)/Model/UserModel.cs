using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinzer_Managment_System__4._12_V_.Model
{
    public class DatatoUserModel
    {
        public List<UserModel> dataUser { get; set; }
    }
    public class UserModel
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

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string authentication;

        public string Authentication
        {
            get { return authentication; }
            set { authentication = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private int remember;

        public int Remember
        {
            get { return remember; }
            set { remember = value; }
        }

    }
}
