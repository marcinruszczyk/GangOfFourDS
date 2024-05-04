using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compositer
{
    interface IComponent
    {
        void Operation();
    }

    class Leaf : IComponent
    {
        private string _name;

        public Leaf(string name)
        {
            _name = name;
        }
        public void Operation()
        {
            Console.WriteLine($"Leaf {_name} operation");
        }

    }


    class Composite : IComponent 
    {
        private List<IComponent> _children = new List<IComponent>();

        public void Add(IComponent component)
        {
            _children.Add(component);
        }

        public void Remove(IComponent component)
        {
            _children.Remove(component);
        }

        public void Operation()
        {
            foreach (var child in _children)
            {
                child.Operation();
            }
        }
    }


}
