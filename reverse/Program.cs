using System;

namespace reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi:");
            string fn = Console.ReadLine();
            for(int i = fn.Length - 1; i>=0; i--)
            {
                Console.Write(fn[i]);
            }
        }
    }
}
