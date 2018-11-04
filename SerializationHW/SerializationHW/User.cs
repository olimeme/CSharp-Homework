using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationHW
{
    [RoleInfo("customer")]
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        private int Payment(int priceOfProduct, int amountOfProduct)
        {
            return priceOfProduct * amountOfProduct;
        }
    }
}
