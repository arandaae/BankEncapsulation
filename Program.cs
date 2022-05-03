﻿using System;
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
            
            //Deposit
            Console.WriteLine("Enter your deposit amount");
            var amount = double.Parse(Console.ReadLine());

            userAccount.Deposit(amount);
            Console.WriteLine();

            //Balance after deposit
            Console.WriteLine($"Your Balance is now:");           
            userAccount.GetBalance();

            Console.WriteLine();

            //Withdraw
            Console.WriteLine("Would you like to make a withdrawal?");
            var amount2 = double.Parse(Console.ReadLine());
            userAccount.Withdraw(amount2);

            Console.WriteLine();

            //Balance after withdrawal
            Console.WriteLine($"Your Balance is now:");
            userAccount.GetBalance();


        }
    }
}
