namespace Test.Week1.OpenClosedPrinciple.Bad
{
    public class Calculator
    {
        public void Calculate(ICalculator calculator)
        {
            if (calculator == null)
            {
                throw new Exception("Can not perform operation");
            }

            if (calculator is Addition)
            {
                Addition addition = (Addition)calculator;
                addition.result = addition.left + addition.right;
            }

            if (calculator is Substraction)
            {
                Substraction substraction = (Substraction)calculator;
                substraction.result = substraction.left - substraction.right;
            }
        }


    }
}
