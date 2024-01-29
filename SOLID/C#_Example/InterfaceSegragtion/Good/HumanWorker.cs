namespace Test.Week1.InterfaceSegregation.Good
{
    public class HumanWorker : IWorkable, IEatable, ISleepable
    {
        public void Work() { /*...*/ }
        public void Eat() { /*...*/ }
        public void Sleep() { /*...*/ }
    }
}
