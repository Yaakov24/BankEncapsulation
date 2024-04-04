using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class BankAccount
    {
        

        private double 
            _balance = 0;
        
        public void Deposit()
        {
            var userInput = 0;
            _balance = userInput + _balance;

            Console.WriteLine("How much would you like to deposite?");
            var x = double.Parse(Console.ReadLine());
            _balance = x;
            Console.WriteLine(_balance);
            
        }

        public void GetBalance()
        {
            Console.WriteLine("Would you like your balance?");
            var yesNo = Console.ReadLine();
            if (yesNo == "yes")
            {
                Console.WriteLine(_balance);
            }
            else if (yesNo == "no")
            {
                Console.WriteLine("ok");
            }
            
            
            
        }
        public void Withdraw()
        {
            var amount = 0;
            _balance = amount - _balance;

            Console.WriteLine("Would you like to withdraw how much?");
           var z = double.Parse(Console.ReadLine());
            _balance = _balance - z;
            Console.WriteLine(z);

        }
       

    }
   
}
      
    

