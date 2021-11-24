using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
           Random snakeAndLadder1= new Random();
            int player1 = snakeAndLadder1.Play(0);
            int player2 = snakeAndLadder1.Play(0);
            if (player1.CompareTo(player2) == 0)
            {
                Console.WriteLine(" Player1 & Player2 at same position " + player1 + ",It is Tie ");
            }
            if (player1.CompareTo(player2) > 0)
            {
                Console.WriteLine("Player1 win " + player1);
            }
            if (player1.CompareTo(player2) < 0)
            {
                Console.WriteLine("Player2 win " + player2);
            }
            Console.ReadKey();
        }
    }
}
