namespace Test.Week1.LiskovSubstitution.Good
{
    public class BankingAppWithdrawalService
    {
        private Account account;

        public BankingAppWithdrawalService(Account account)
        {
            this.account = account;
        }

        public void WithDraw(decimal amount)
        {
            account.withdraw(amount);
        }
    }
}
