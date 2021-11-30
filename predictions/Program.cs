using System;

namespace predictions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] future = new string[6] { "make a deposit", "loose yourself", "check your bank accaunt", "buy a new car", "sell your phone", "quit university" };
            Random rnd = new Random();
            int un = rnd.Next(0, future.Length);
            Console.WriteLine($"Tommorow you will have to {future[un]}.");
        }
    }
}
