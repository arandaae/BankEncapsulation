using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    class BankAccount
    {
        private double _balance = 0;

        public BankAccount()
        {
            
        }
                     
        public void Deposit(double depositAmount)
        {
            _balance += depositAmount;
        }
               
        public double Withdraw(double withdrawal)
        {
            _balance -= withdrawal;
            return _balance;    
            
        }

        public void GetBalance()
        {
            Console.WriteLine(_balance);
            
        }










    }
}
