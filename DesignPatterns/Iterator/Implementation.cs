using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    interface IIterator
    {
        bool HasNext();
        object Next();
    }

    interface IAggregate
    {
        IIterator CreateIterator();
    }


    class ConcreteIterator: IIterator
    {
        private readonly ArrayList _collection;
        private int _position = 0;


        public ConcreteIterator(ArrayList collection)
        {
            _collection = collection;
        }

        public bool HasNext()
        {
            return _position < _collection.Count; 
        }

        public object Next()
        {
            if (HasNext()) 
            {
                object item = _collection[_position];
                _position++;
                return item;
            }
            else
            {
                throw new InvalidOperationException("No more elements");
            }
        }
    }


    class ConcreteAggregate : IAggregate 
    {
        private readonly ArrayList _collection = new ArrayList();

        public void Add(object item)
        {
            _collection.Add(item);
        }

        public IIterator CreateIterator() 
        {
            return new ConcreteIterator(_collection);
        }

    }


}
