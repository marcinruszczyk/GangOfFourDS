using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    interface IMediator
    {
        void SendMessage(Colleague colleague, string message);
    }

    abstract class Colleague
    {
        protected IMediator _mediator;

        public Colleague(IMediator mediator)
        {
            _mediator = mediator;            
        }

        public abstract void ReceiveMessage(string message);

    }


    class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(IMediator mediator) : base(mediator) 
        {

        }

        public override void ReceiveMessage(string message)
        {
            Console.WriteLine("ConcreteColleague1 received" + message);
        }

        public void Send(string message)
        {
            _mediator.SendMessage(this, message);
        }


    }


    class ConcreteColleague2 : Colleague
    {

        public ConcreteColleague2(IMediator mediator) : base(mediator)
        {
            
        }

        public override void ReceiveMessage(string message)
        {
            Console.WriteLine("ConcreteColleague2 received: " + message);
        }

        public void Send(string message)
        {
            _mediator.SendMessage(this, message);
        }

    }


    //concrete mediator class

    class ConcreteMediator : IMediator
    {
        private List<Colleague> _colleagues = new List<Colleague>();

        public void AddColleague(Colleague colleague) 
        {
            _colleagues.Add(colleague);
        }

        public void SendMessage(Colleague colleague, string message)
        {
            foreach (var col in _colleagues)
            {
                if (col != colleague)
                {
                    col.ReceiveMessage(message);
                }
            }
        }
    }






}
