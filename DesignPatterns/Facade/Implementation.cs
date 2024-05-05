using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Subsystem1
    {
        public void Operation1()
        {
            Console.WriteLine("Subsystem 1: Operation 1");
        }
    }

    class Subsystem2
    {
        public void Operation2()
        {
            Console.WriteLine("Subsystem2: Operation 2");
        }
    }

    class Facade
    {
        private Subsystem1 subsystem1;
        private Subsystem2 subsystem2;

        public Facade() 
        {
            subsystem1 = new Subsystem1();
            subsystem2 = new Subsystem2();

        }

        public void Operation()
        {
            Console.WriteLine("Facade operation");
            subsystem1.Operation1();
            subsystem2.Operation2();
        }

    }

}
