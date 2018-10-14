using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSystemHW1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "";


            Console.WriteLine("Введите путь к файлу:");
            path = Console.ReadLine();

            try
            {
            string[] words;
            List<int> numbers = new List<int>();

            
            using (StreamReader stream = new StreamReader(path + "INPUT.txt"))
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

            int sum = 0;

            foreach (int number in numbers)
                sum += number;

            using (StreamWriter stream = new StreamWriter(path + "OUTPUT.txt"))
            {
                stream.WriteLine(sum);
            }

            foreach (int number in numbers)
                Console.Write(number + "  ");

            Console.WriteLine();

            Console.WriteLine(sum);

            }
            catch (IOException exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.ReadLine();
        }
    }
}
