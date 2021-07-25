using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much money is in the account: ");
            decimal deposit = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter the annual interest rate: ");
            decimal rate = Convert.ToDecimal(Console.ReadLine());
            Console.Write("How long has the account been opened: ");
            int months = Convert.ToInt32(Console.ReadLine());
            SavingsAccount myAccount = new SavingsAccount(deposit);

            for (var i = 1; i <= months; i++)
            {
                Console.Write($"Enter amount deposited for month: {i}: ");
                myAccount.DepositToBalance(Convert.ToDecimal(Console.ReadLine()));
                Console.Write($"Enter amount withdrawn for {i}: ");
                myAccount.WithdrawBalance(Convert.ToDecimal(Console.ReadLine()));
                myAccount.MonthlyInterest(rate);
            }

            Console.WriteLine($"Total deposited: ${myAccount.TotalDeposited()}");
            Console.WriteLine($"Total withdrawn: ${myAccount.TotalWithdrawn()}");
            Console.WriteLine($"Interest earned: ${myAccount.TotalInterest()}");
            Console.WriteLine($"Ending balance: ${myAccount.EndingBalance()}");
            Console.ReadKey();
        }
    }
}
