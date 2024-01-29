namespace Test.Week1.OpenClosedPrinciple.Bad
{
    public class Addition : ICalculator
    {
        public double left { get; set; }
        public double right { get; set; }

        public double result = 0.0;


        public Addition(double left, double right)
        {
            this.left = left;
            this.right = right;
        }


    }
}
