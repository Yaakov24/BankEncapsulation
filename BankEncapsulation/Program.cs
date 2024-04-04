namespace BankEncapsulation
{
    public class Program
    {

        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Deposit(3543.65);
            account.GetBalance();
        }
    }
}
