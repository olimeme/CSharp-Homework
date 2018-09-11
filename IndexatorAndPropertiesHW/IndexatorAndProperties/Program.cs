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
            int arrayElement = 5;
            Console.WriteLine("Программа возведение принимаемых значении массива в квадрат");
            Console.WriteLine("Принимаемое значение - " + arrayElement);
            Indexator indexators = new Indexator();
            indexators[0] = arrayElement;
            Console.WriteLine(indexators[0]);
            Console.ReadLine();
        }
    }
}
