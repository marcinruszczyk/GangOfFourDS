using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Context
    {
        private State _state;

        public Context()
        {
            _state = new ConcreteStateA();
        }

        public void SetState(State state)
        {
            _state = state;
        }

        public void Request()
        {
            _state.Handle(this);
        }

    }


    //state inteface
    interface State
    {
        void Handle(Context context);
    }

    class ConcreteStateA : State
    {
        public void Handle(Context context) 
        {
            Console.WriteLine("Handling request in State A");

            context.SetState(new ConcreteStateB());
        }
    }


    class ConcreteStateB : State
    {
        public void Handle(Context context)
        {
            Console.WriteLine("Handling request in State B");

            context.SetState(new ConcreteStateA()); 
        }
    }

    
}
