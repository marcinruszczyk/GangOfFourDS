using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }

    interface IObserver
    {
        void Update();
    }

    class ConcreteSubject : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private int _state;

        public int State
        {
            get { return _state; }
            set
            {
                _state = value;
                Notify();
            }
        }


        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }

    class ConcreteObserver : IObserver
    {
        private ConcreteSubject _subject;


        public ConcreteObserver(ConcreteSubject subject)
        {
            _subject = subject;
            _subject.Attach(this);
        }

        public void Update()
        {
            Console.WriteLine($"Observer received state update: {_subject.State}");
        }
    }

}
