namespace BankEncapsulation
{
    public class Program
    {

        static void Main(string[] args)
        {
            

            BankAccount account = new BankAccount();
            account.Deposit();
            account.GetBalance();
            account.Withdraw();

            

           
        }
    }
}
