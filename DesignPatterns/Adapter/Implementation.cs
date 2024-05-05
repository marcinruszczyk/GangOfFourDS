using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    interface ITarget
    {
        void Request();
    }

    class Adaptee
    {
        public void SpecificRequst()
        {
            Console.WriteLine("Adaptee 's specific request");
        }
    }

    class Adapter : ITarget
    {
        public readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee) 
        {
            _adaptee = adaptee;
        }

        public void Request()
        {
            _adaptee.SpecificRequst();
        }
    }

    class Client
    {
        public void ExecuteRequest(ITarget target)
        {
            target.Request();
        }
    }

}
