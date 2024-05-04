using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    interface IElement
    {
        void Accept(IVisitor visitor);
    }

    class ConcreteElementA : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }

        public void OperationA()
        {
            Console.WriteLine("Operation A of ConcreteElementA");
        }

    }


    class ConcreteElementB : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }

        public void OperationB()
        {
            Console.WriteLine("Operation B of ConcreteElementB");
        }

    }


    interface IVisitor
    {
        void VisitConcreteElementA(ConcreteElementA element);
        void VisitConcreteElementB(ConcreteElementB element);
    }

    class ConcreteVisitor : IVisitor 
    {
        public void VisitConcreteElementA(ConcreteElementA element)
        {
            Console.WriteLine("Visitor visits ConcreteElementA");
            element.OperationA();
        }


        public void VisitConcreteElementB(ConcreteElementB element)
        {
            Console.WriteLine("Visitor visits ConcreteElementB");
            element.OperationB();
        }

    }


    class ObjectStructure
    {
        private List<IElement> _elements = new List<IElement>(); 

        public void Attach(IElement element)
        {
            _elements.Add(element);
        }

        public void Detach(IElement element) 
        {
            _elements.Remove(element);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var element in _elements)
            {
                element.Accept(visitor);    
            }
        }

    }




}
