using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsHW
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>{ 1, 4, 6, 3, 7, 8, 3, 7, 5, 10 };

            int secondMaxNumber = numbers[0];
            int maxNumber = numbers[0];

            int sumOfEvenElements = 0;

            Console.WriteLine("Вывести на экран позицию и значение элемента, являющегося вторым максимальным значением в коллекции. ");
            Console.WriteLine("Вывести на экран сумму элементов на четных позичиях. ");

            Console.WriteLine("Коллекция:");

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            for (int i=0;i<numbers.Count;i++)
            {
                if (numbers[i] >= maxNumber)
                {
                    secondMaxNumber = maxNumber;
                    maxNumber = numbers[i];
                }
                else if (numbers[i] > secondMaxNumber && numbers[i] != maxNumber)
                    secondMaxNumber = numbers[i];
            }

            Console.WriteLine("Второе максимальное значение коллекции: " + secondMaxNumber);

            for (int i = 0; i < numbers.Count; i++)
                if (i % 2 == 0)
                    sumOfEvenElements += numbers[i];

            Console.WriteLine("Сумма всех четных элементов: " + sumOfEvenElements);
            Console.ReadLine();
        }
    }
}
