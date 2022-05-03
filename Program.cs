using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userAccount = new BankAccount();

            userAccount.Deposit(100);
            userAccount.GetBalance();
            Console.WriteLine(userAccount);

        }
    }
}
