using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPW
{
    public class CountTheWords
    {
        private Dictionary<string, int> KeyValuePairs;

        public Dictionary<string,int> GetKeyValuePairs()
        {
            return KeyValuePairs;
        }

        public void SetKeyValuePairs(Dictionary<string,int> keyValues)
        {
            KeyValuePairs = keyValues;
        }

        public CountTheWords()
        {
            KeyValuePairs = new Dictionary<string, int>();
        }

        public void AddWord(string word)
        {
            if (KeyValuePairs.ContainsKey(word))
                KeyValuePairs[word] += 1;
            else
                KeyValuePairs.Add(word, 1);
        }

        public int AmountOfWords()
        {
            return KeyValuePairs.Count;
        }
    }
}
