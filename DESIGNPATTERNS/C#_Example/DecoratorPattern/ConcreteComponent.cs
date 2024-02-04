.using System;
using System.ComponentModel;

namespace DESIGNPATTERNS.CSharp_Example.DecoratorPattern
{
    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }
}