namespace Test.Week1.LiskovSubstitution.Good
{
    public abstract class WithdrawableAccount : Account
    {
        public abstract void withdraw(decimal amount);

    }
}
