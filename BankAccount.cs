using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Constructors_Methods_Overload
{
    internal class BankAccount
    {
        string _accountNumber;
        string _customerName;
        double _balance; // Real world we'd use decimal, but not needed here

        // Constructor for all
        public BankAccount(string accountNumber, string customerName, double balance)
        {
            _accountNumber = accountNumber;
            _customerName = customerName;
            _balance = balance;
        }

        public string AccountNumber { get => _accountNumber; } // read only
        public string CustomerName { get => _customerName; set => _customerName = value; }
        public double Balance { get => _balance; } // read only

        //        Deposit(double amount) - When the user passes in a value, add that money to the account.
        //Validation: Make sure the number isn't negative before adding.
        public void Deposit(double amount)
        {
            if (amount >= 0)
            {
                _balance += amount;
            }
            else
            {
                Console.WriteLine("Please enter a valid amount.");
            }
        }

//Withdraw(double amount) - When the user passes in a value, withdraw that month from the account.
//Validation: Make sure the amount isn't negative, AND ( && ) make sure the amount is less than the balance ( so the account doesn't overdraw )
        public void Withdraw(double amount)
        {
            if (amount >= 0 && amount >= _balance)
            {
                _balance -= amount;
            }
            else
            {
                Console.WriteLine("Please enter a valid amount. The amount cannot be greater than the amount in the account.");
            }
        }

        //override ToString()
        //Account Number - Customer Name - Current Balance: balance.ToString("c");
        //Ex. 123456689 - Will Cram - Current Balance $20.00
        public override string ToString()
        {
            return $"{AccountNumber} - {CustomerName} - Current balance: {Balance.ToString("c")}";
        }
    }
}
