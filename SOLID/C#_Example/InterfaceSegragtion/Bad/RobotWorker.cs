namespace Test.Week1.InterfaceSegregation.Bad
{
    public class RobotWorker : IWorker
    {
        public void Work() { /*...*/ }
        public void Eat() { /*...*/ } // Not applicable to robots
        public void Sleep() { /*...*/ } // Not applicable to robots
    }
}
