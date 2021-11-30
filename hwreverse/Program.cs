using System;

namespace hwreverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string fn ="Hello World!";
            for (int i = fn.Length - 1; i >= 0; i--)
            {
                Console.Write(fn[i]);
            }
        }
    }
}
