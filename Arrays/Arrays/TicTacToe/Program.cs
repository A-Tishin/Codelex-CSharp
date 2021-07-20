using System;
using System.Data;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main(string[] args)
        {
            string player = "O";
            InitBoard();
            do
            {
                Console.Clear();
                DisplayBoard();
                player = player == "X" ? "O" : "X";
                int row, column;
                Console.Write($"{player}, choose your row (0 - 2): ");
                row = int.Parse(Console.ReadLine());
                Console.Write("And column (0 - 2): ");
                column = int.Parse(Console.ReadLine());
                if (row < 0 || row > 2 || column < 0 || column > 2)
                {
                    player = player == "O" ? "X" : "O";
                    continue;
                }
                board[row, column] = Convert.ToChar(player);
            } while (CheckWinCondition() == false && IsTie() == false);

            Console.Clear();
            DisplayBoard();
            Console.WriteLine(IsTie() ? "It's a tie!" : $"{player} has won!");
            Console.ReadKey();
        }

        private static void InitBoard()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
        }

        static bool CheckWinCondition()
        {
            bool win = false;
            char[,] conditions =
            {
                {board[0, 0], board[0, 1], board[0, 2]},
                {board[1, 0], board[1, 1], board[1, 2]},
                {board[2, 0], board[2, 1], board[2, 2]},
                {board[0, 0], board[1, 0], board[2, 0]},
                {board[0, 1], board[1, 1], board[2, 1]},
                {board[0, 2], board[1, 2], board[2, 2]},
                {board[0, 0], board[1, 1], board[2, 2]},
                {board[2, 2], board[1, 1], board[0, 0]},
            };

            for (var i = 0; i < 8; i++)
            {
                var a = conditions[i, 0];
                var b = conditions[i, 1];
                var c = conditions[i, 2];

                if (a != Convert.ToChar(" ") && a == b && b == c)
                    win = true;
            }
            return win;
        }

        static bool IsTie()
        {
            bool tie = true;

            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    if (board[i, j] == Convert.ToChar(" "))
                        tie = false;
                }
            }

            return tie;
        }
    }
}
