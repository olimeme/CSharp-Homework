using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ClassLibrary1
{
    public class Class
    {
        public static void Print(Person person)
        {
            WriteLine(person.Name);
            WriteLine(person.Age);
        }
    }
}
