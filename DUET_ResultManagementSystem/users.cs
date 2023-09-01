using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUET_ResultManagementSystem
{
    class Users
    {
        private string userName;
        private string password;
        private string userType;
        private string fullName;
        private string phone;
        private string department;
        private string address;
        private string email;


        
        public string UserType { get => userType; set => userType = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Department { get => department; set => department = value; }
        public string Address { get => address; set => address = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
    }
}
