namespace Test.Week1.OpenClosedPrinciple.Good
{
    public class Addition : ICalculator
    {
        public double left { get; set; }
        public double right { get; set; }

        public double result = 0.0;

        public void perform()
        {
            result = left + right;
        }

    }
}
