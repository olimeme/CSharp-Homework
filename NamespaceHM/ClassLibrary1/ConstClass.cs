using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 

namespace ClassLibrary1
{
    public class ConstClass
    {
        public const string Frase = "How to become a pigon and escape life";
        public const int Number = 75;

        public static void Print()
        {
            WriteLine(Frase);
            WriteLine(Number);
        }
    }
}
