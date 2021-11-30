using System;

namespace FruitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruit = new string[5] {"an apple", "a lemon", "a banana", "an orange", "some grapes"};
            Random rnd = new Random();
            int un = rnd.Next(0, fruit.Length);
            Console.WriteLine($"Today you will have {fruit[un]}.");
        }
    }
}
