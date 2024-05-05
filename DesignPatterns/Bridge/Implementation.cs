using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    interface IImplementator
    {
        void OperationImpl();
    }


    class ConcreteImplementatorA : IImplementator
    {
        public void OperationImpl() 
        {
            Console.WriteLine("Concrete Implementator A operation");
        } 
    }

    class ConcreteImplementatorB : IImplementator
    {
        public void OperationImpl()
        {
            Console.WriteLine("Concrete Implementor B operation");
        }
    }

    abstract class Abstraction
    {
        protected IImplementator implementor;

        public Abstraction(IImplementator implementor)
        {
            this.implementor = implementor;
        }

        public abstract void Operation();
    }

    class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(IImplementator implementator) : base(implementator) 
        {

        }

        public override void Operation()
        {
           implementor.OperationImpl();
        }

    }



}
