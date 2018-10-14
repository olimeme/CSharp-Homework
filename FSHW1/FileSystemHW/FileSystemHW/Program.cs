using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSystemHW
{
    class Program
    {
        static bool IsFib(List<int> numbers)
        {
            bool res = false; 
            for (int i = 0; i < numbers.Count - 2; i++)
            {
                if (numbers[i] + numbers[i + 1] == numbers[i + 2])
                    res = true;
                else
                    return false;
            }
            return res;
        }

        static List<int> MakeFib(List<int> numbers)
        {
            int size = numbers.Count;
            for (int i = size - 1; i < (size * 2) - 1; i++)
            {
                numbers.Add(numbers[i - 1] + numbers[i]);
            }
            return numbers;
        }

        static void Main(string[] args)
        {
            string path = "";

            string fileName = "";

            Console.WriteLine("Введите путь к файлу:");
            path = Console.ReadLine();

            Console.WriteLine("Введите название файла:");
            fileName = Console.ReadLine();


            try
            {
                string[] words;
                List<int> numbers = new List<int>();

                using (StreamReader stream = new StreamReader(path + fileName))
                {
                    string text = stream.ReadLine();

                    words = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                }


                foreach (string item in words)
                {
                    int number;
                    bool isParsed = int.TryParse(item, out number);

                    if (isParsed)
                        numbers.Add(number);
                }

                if (IsFib(numbers))
                {
                    numbers = MakeFib(numbers);

                    foreach (int item in numbers)
                        Console.Write(item + "  ");


                    using (FileStream stream = new FileStream(path + fileName, FileMode.Create))
                    {
                        string data = String.Join<int>(" ", numbers);

                        byte[] bytes = System.Text.Encoding.Unicode.GetBytes(data);

                        stream.Write(bytes, 0, bytes.Length);
                    }
                }
                else
                {
                    Console.WriteLine("Последовательность не является рядом Фибоначчи");
                }
            }
            catch (IOException exception)
            {
                Console.WriteLine(exception.Message);
            }
            Console.ReadLine();
        }
    }
}