using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverloadPW
{
    class Program
    {
        public static void FirstTask()
        {
            FirstTask firstObject = new FirstTask(4);

            FirstTask secondObject = new FirstTask(10);

            bool firstCompareson = firstObject == secondObject;

            bool secondCompareson = firstObject != secondObject;

            Console.WriteLine("Проверка перегрузки операторов == и !=");

            Console.WriteLine("Первое число - " + firstObject.Number);

            Console.WriteLine("Второе число - " + secondObject.Number);

            Console.WriteLine("==");

            Console.WriteLine("Значение - " + firstCompareson);

            Console.WriteLine("!=");

            Console.WriteLine("Значение - " + secondCompareson);

            Console.ReadLine();
        }

        public static void SecondTask()
        {
            int[] firstArray = { 1, 2, 3, 4, 5, 6 };
            SecondTask firstObject = new SecondTask(firstArray);

            int[] secondArray = { 1, 2, 3, 4, 5, 7 };
            SecondTask secondObject = new SecondTask(secondArray);

            bool firstCompareson = firstObject > secondObject;

            bool secondCompareson = firstObject < secondObject;

            Console.WriteLine("Проверка перегрузки операторов > и <");

            Console.Write("Первой массив - ");
            for (int i = 0; i < firstObject.ArrayNumbers.Length; i++)
                Console.Write(firstObject.ArrayNumbers[i] + " ");
            Console.WriteLine();

            Console.Write("Второй массив - ");
            for (int i = 0; i < secondObject.ArrayNumbers.Length; i++)
                Console.Write(secondObject.ArrayNumbers[i] + " ");
            Console.WriteLine();


            Console.WriteLine(">");

            Console.WriteLine("Значение - " + firstCompareson);

            Console.WriteLine("<");

            Console.WriteLine("Значение - " + secondCompareson);

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
        }

    }
}
