

namespace Memento
{

    //Memento class

    class Memento
    {
        public string State { get; }

        public Memento(string state)
        {
            State = state;
        }

    }




    //Originator class
     class Originator
    {
        private string _state;

        public string State
        {
            get { return _state; }
            set
            {
                Console.WriteLine($"Setting state to {value}");
                _state = value;
            }
        }


        public Memento SaveStateToMemento()
        {
            return new Memento(_state);
        }

        public void GetStateFromMemento( Memento memento ) 
        {
            _state = memento.State;
            Console.WriteLine($"State restored to: {_state}");
        }


    }



    class Caretaker
    {
        public Memento Memento { get; set; }

    } 




}





