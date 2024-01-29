namespace Test.Week1.OpenClosedPrinciple.Bad
{
    public class Substraction : ICalculator
    {
        public double left;
        public double right;
        public double result = 0.0;

        public Substraction(double left, double right)
        {
            this.left = left;
            this.right = right;
        }

    }
}
