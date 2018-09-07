using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using ClassLibrary1;

namespace namespaceHM
{
    class Program
    {
        static void Main(string[] args)
        {
            string personName = "Ганджа";
            int personAge = 23;
            Person person = new Person(personName, personAge);
            Class.Print(person);
            ConstClass.Print();
            ReadLine();
        }
    }
}
