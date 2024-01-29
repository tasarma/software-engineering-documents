namespace Test.Week1.LiskovSubstitution.Bad
{
    public class FixedTermDepositAccount : Account
    {
        public override void deposit(decimal amount)
        {
            //Deposit in this account
        }

        public override void withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
