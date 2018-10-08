using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPW
{
    class Program
    {
        public static void PrintStats(CountTheWords countTheWords)
        {
            foreach (var i in countTheWords.GetKeyValuePairs())
                Console.WriteLine("Слово " + i.Key + " встречается " + i.Value + " раз.");
            Console.WriteLine("Всего уникальных слов: " + countTheWords.AmountOfWords());
        }
        static void Main(string[] args)
        {
            string s = "Вот дом, Который построил Джек. А это пшеница, Кото­рая в темном  чулане хранится В доме, Который построил Джек. А это веселая птица­ синица, Которая часто вору­ет пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";
            char[] delimiters = { ' ', ',', '.','-'};
            string[] words = s.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            CountTheWords countTheWords = new CountTheWords();
            for(int i=0;i<words.Length;i++)
            {
                countTheWords.AddWord(words[i]);
            }
            PrintStats(countTheWords);
            Console.WriteLine("Всего слов:" + words.Length);
            Console.ReadLine();
        }
    }
}
