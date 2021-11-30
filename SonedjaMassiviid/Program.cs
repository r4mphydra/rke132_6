using System;

namespace SonedjaMassiviid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi:");
            string fn = Console.ReadLine();
            Console.WriteLine($"Sinu eesnimes on {fn.Length} sümbolit");
        }
    }
}
