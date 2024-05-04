using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    interface IHandler
    {
        void SetNext(IHandler handler);
        void HandleRequest(int request);
    }

    class ConcreteHandler : IHandler
    {
        private IHandler _nextHandler;

        public void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
            {
                Console.WriteLine($"{request} handled by ConcreteHandler");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);    
            }
            else
            {
                Console.WriteLine($"{request} cannot be handled");
            }
        }

        public void SetNext(IHandler handler)
        {
            _nextHandler = handler;
        }
    }



}
