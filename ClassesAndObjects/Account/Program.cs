using System;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            Account A = new Account("A", 100.00);
            Account B = new Account("B", 0);
            Account C = new Account("C", 0);
            Console.WriteLine("Initial state");
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
            Transfer(A, B, 50.0);
            Transfer(B, C, 25.0);
            
            Console.WriteLine("Final state");
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);

            Console.ReadKey();
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            to.deposit(from.withdrawal(howMuch));
        }
    }
}
