using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account benben = new Account("Benson", 17.20);
            Account fancy = new Account("Fancy", -123.05);
            benben.ShowUserNameAndBalance();
            fancy.ShowUserNameAndBalance();
            Console.ReadKey();
        }
    }
}
