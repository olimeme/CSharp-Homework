using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace TryCatchHM
{
    class Program
    {
        static void Main(string[] args)
        {
            firstTask();
            secondTask();
        }

        public static void secondTask()
        {
            int[] mas = { 1, 2, 3, 4, 5, 6, 7 };
            try
            {
                for (int i = 0; i < mas.Length + 1; i++)
                {
                    Write(mas[i] + " ");
                    if (i > mas.Length)
                        throw new IndexOutOfRangeException();
                }
            }
            catch (IndexOutOfRangeException exception)
            {
                WriteLine(exception.Message);
            }
            ReadLine();
        }

        public static void firstTask()
        {

            int firstNumber;
            int secondNumber;
            WriteLine("Деление двух чисел");
            WriteLine("Введите первое число ");
            string str = ReadLine();

            bool isParsed = int.TryParse(str, out firstNumber);

            try
            {
                if (isParsed)
                    firstNumber = int.Parse(str);
                else
                    throw new ArgumentNullException();
            }
            catch (ArgumentNullException exception)
            {
                WriteLine(exception.Message);
                ReadLine();
                return;
            }

            WriteLine("Введите второе число ");
            str = ReadLine();

            isParsed = int.TryParse(str, out secondNumber);
            try
            {
                if (isParsed)
                    secondNumber = int.Parse(str);
                else
                    throw new ArgumentNullException();

                if (secondNumber == 0)
                    throw new ArgumentException();
            }
            catch (ArgumentNullException exception)
            {
                WriteLine(exception.Message);
                ReadLine();
                return;
            }
            catch (ArgumentException exception)
            {
                WriteLine(exception.Message);
                ReadLine();
                return;
            }
            WriteLine("Ответ - " + firstNumber / secondNumber);
            ReadLine();
        }
    }
}

