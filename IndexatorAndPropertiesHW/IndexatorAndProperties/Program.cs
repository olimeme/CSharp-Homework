using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexatorAndProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Indexator indexators = new Indexator();
            indexators[0] = 5;
            Console.WriteLine(indexators[0]);
            Console.ReadLine();
        }
    }
}
