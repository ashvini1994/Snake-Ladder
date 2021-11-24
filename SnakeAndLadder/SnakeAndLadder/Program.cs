using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Problem");
            Random random1 = new Random();
            random1.Play();
            Console.ReadKey();
        }
    }
}
