.using System;

namespace DESIGNPATTERNS.CSharp_Example.DecoratorPattern
{
    /// <summary>
    /// The 'ConcreteDecoratorB' class
    /// </summary>
    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("ConcreteDecoratorB.Operation()");
        }
        void AddedBehavior()
        {
        }
    }
}