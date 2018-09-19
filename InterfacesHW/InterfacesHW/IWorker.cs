using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesHW
{
    public interface IWorker
    {
        string Name { get; set; }

        string PhoneNumber { get; set; }

        int Age { get; set; }
    }
}
