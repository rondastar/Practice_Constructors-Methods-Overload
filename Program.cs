using System.Security.Principal;

namespace Practice_Constructors_Methods_Overload
{
    // Ronda Rutherford
    // May 1, 2023
    // Practice - Constructors, Methods, and Overloading
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Create an instance of Bank account in main.
            BankAccount bankAccount = new BankAccount("198768790", "Ronda Rutherford", 9500.87);
            // 2. Display the current information.
            Console.WriteLine(bankAccount.ToString());
            // 3.Deposit 500 into the account
            bankAccount.Deposit(500);
            //4.Show the updated information
            Console.WriteLine(bankAccount.ToString());
            //5.Deposit -15000 into the account
            bankAccount.Deposit(-15000);
            //6.Show updated information // The number shouldn't have changed because a negative number was passed
            Console.WriteLine(bankAccount.ToString());
            //// Test withdraw
            //7.Withdraw 300 from the account.
            bankAccount.Withdraw(300);
            //8.Display the updated information.
            Console.WriteLine(bankAccount.ToString());
            //9.Withdraw - 500 from the account.
            bankAccount.Withdraw(-500);
            //10.Display the updated information. // No change since the amount was negative ( - )
            Console.WriteLine(bankAccount.ToString());
        } // Main
    } // class
} // namespace