using System;

namespace Panicnot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do not Panic!");
            string hw = ("Do not Panic!");
            hw = hw.Replace('o', '0');
            hw = hw.Replace('a', '4');
            Console.WriteLine(hw);
        }
    }
}
