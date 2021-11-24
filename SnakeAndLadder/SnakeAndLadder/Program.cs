using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Problem");
            int playerLocation = 0;
            Random randam = new Random();
            int answer = randam.Next(1, 6);
            playerLocation = playerLocation + answer;
            Console.WriteLine("Player Location is " + playerLocation);
            Console.ReadKey();
        }
    }
}
