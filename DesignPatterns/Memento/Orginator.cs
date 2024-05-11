using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Orginator
    {
        string state;

        public string State
        {
            get { return state; }
            set 
            {
                state = value;
                Console.WriteLine("state =" + state);
            }
        }


        public Memento CreateMemento()
        {
            return (new Memento(state));
        }


        public void SetMemento(Memento memento) {
            Console.WriteLine("Restoring state ...");
            State = memento.State;
        }

    }
}
