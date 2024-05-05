using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    interface ISubject
    {
        void Request();
    }

    class RealSubject : ISubject
    {
        public void Request() 
        {
            Console.WriteLine("RealSubject: Handling request");
        }
    }

    class Proxy : ISubject
    {
        private RealSubject realSubject;

        public Proxy()
        {
            realSubject = new RealSubject();    
        }

        public void Request() 
        {
            Console.WriteLine("Proxy: handling request");
            realSubject.Request();
        }



    }











}
