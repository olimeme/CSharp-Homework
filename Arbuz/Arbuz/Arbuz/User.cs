using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbuz
{
    public class User
    {
        private string Login { get; set; }
        private string Password { get; set; }
        private string FullName { get; set; }
        private string Phonenumber { get; set; }

        public User(string login, string password,string phoneNumber, string fullName)
        {
            Login = login;
            Password = password;
            Phonenumber = phoneNumber;
            FullName = fullName;
        }
    }
}
