.using System;

namespace DESIGNPATTERNS.CSharp_Example.DecoratorPattern
{
    /// <summary>
    /// The 'ConcreteDecoratorA' class
    /// </summary>
    public class ConcreteDecoratorA : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorA.Operation()");
        }
    }
}