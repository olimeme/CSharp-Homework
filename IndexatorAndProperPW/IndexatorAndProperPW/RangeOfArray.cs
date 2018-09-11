using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexatorAndProperPW
{
    class RangeOfArray
    {
        public int UpperIndex { get; set; }

        public int LowerIndex { get; set; }

        public int[] array { get; set; }

        public RangeOfArray(int lowerIndex,int upperIndex)
        {
            if (upperIndex > lowerIndex)
            {
                UpperIndex = upperIndex;
                LowerIndex = lowerIndex;
                array = new int[UpperIndex - LowerIndex];
            }
            else
            {
                UpperIndex = lowerIndex;
                LowerIndex = upperIndex;
                array = new int[UpperIndex - LowerIndex];
            }
        }

        public void Insert(int element,int index)
        {
            if (array.Length == 0||index<LowerIndex||index>UpperIndex)
            {
                Console.WriteLine("Введен индекс за пределами массива или длина массива равна 0");
                return;
            }
            array[index-1] = element;
        }

    }
}
