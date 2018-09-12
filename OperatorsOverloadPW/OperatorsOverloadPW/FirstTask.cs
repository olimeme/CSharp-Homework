using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverloadPW
{
    public class FirstTask
    {
        public int Number { get; set; }

        public FirstTask(int number)
        {
            Number = number;
        }

        public static bool operator ==(FirstTask firstObject, FirstTask secondObject)
        {
            return (firstObject.Number == secondObject.Number);
        }
        public static bool operator !=(FirstTask firstObject, FirstTask secondObject)
        {
            return (firstObject.Number != secondObject.Number);
        }
    }
}
