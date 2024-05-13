using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter1
{
    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Adaptee 's specific request");
        }

    }
}
