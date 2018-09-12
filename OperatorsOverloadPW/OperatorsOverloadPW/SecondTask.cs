using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverloadPW
{
    class SecondTask
    {
        public int[] ArrayNumbers { get; set; }

        public SecondTask(int[] array)
        {
            ArrayNumbers = array;
        }

        public static bool operator >(SecondTask firstArray,SecondTask secondArray)
        {
            int firstArraySum = 0;
            for (int i = 0; i < firstArray.ArrayNumbers.Length; i++)
                firstArraySum += firstArray.ArrayNumbers[i];
            int secondArraySum = 0;
            for (int i = 0; i < secondArray.ArrayNumbers.Length; i++)
                secondArraySum += secondArray.ArrayNumbers[i];
            return (firstArraySum > secondArraySum);
        }

        public static bool operator <(SecondTask firstArray, SecondTask secondArray)
        {
            int firstArraySum = 0;
            for (int i = 0; i < firstArray.ArrayNumbers.Length; i++)
                firstArraySum += firstArray.ArrayNumbers[i];
            int secondArraySum = 0;
            for (int i = 0; i < secondArray.ArrayNumbers.Length; i++)
                secondArraySum += secondArray.ArrayNumbers[i];
            return (firstArraySum < secondArraySum);
        }
    }
}
