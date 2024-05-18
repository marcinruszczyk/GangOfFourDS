using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Context
    {
        State state;

        public Context(State state)
        {
            this.state = state;
        }

        public State State
        {
            get { return state;}
            set
            {
                state = value;
                Console.WriteLine("state" + state.GetType().Name);
            }
        }

        public void Request()
        {
            state.Handle(this);
        }

    }
}
