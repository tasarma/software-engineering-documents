namespace Test.Week1.OpenClosedPrinciple.Good
{
    public class Calculator
    {
        public void calculate(ICalculator calculator)
        {
            if (calculator == null)
            {
                throw new Exception("Cannot perform operation");
            }
            calculator.perform();
        }
    }
}
