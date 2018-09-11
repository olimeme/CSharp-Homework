using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace IndexatorAndProperPW
{
    class Program
    {
        static void PrintArray(RangeOfArray array)
        {
            for(int i=0;i<array.UpperIndex - array.LowerIndex;i++)
            {
                WriteLine(array.array[i]+" ");
            }
        }

        static void Main(string[] args)
        {
            int lowerIndex;

            int upperIndex;

            int element;

            int elementIndex;

            WriteLine("Введите индексный диапозон массива");

            WriteLine("Введите верхний индекс ");
            string str = ReadLine();
            bool isParsed = int.TryParse(str, out upperIndex);
                if (isParsed)
                    upperIndex = int.Parse(str);

            WriteLine("Введите нижний индекс ");
            str = ReadLine();
            isParsed = int.TryParse(str, out lowerIndex);
                if (isParsed)
                    lowerIndex = int.Parse(str);

            RangeOfArray array = new RangeOfArray(lowerIndex, upperIndex);

            WriteLine("Введите входной элемент");
            str = ReadLine();
            isParsed = int.TryParse(str, out element);
            if (isParsed)
                element = int.Parse(str);

            WriteLine("Введите индекс элемента(от " + lowerIndex + " до " + upperIndex + ")");
            str = ReadLine();
            isParsed = int.TryParse(str, out elementIndex);
            if (isParsed)
                elementIndex = int.Parse(str);

            array.Insert(element, elementIndex);
            PrintArray(array);
            ReadLine();
        }
    }
}
