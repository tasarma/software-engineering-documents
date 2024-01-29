namespace Test.Week1.LiskovSubstitution.Bad
{
    public abstract class Account
    {
        public abstract void deposit(decimal amount);

        public abstract void withdraw(decimal amount);
    }
}
