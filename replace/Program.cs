using System;

namespace replace
{
    class Program
    {
        static void Main(string[] args)
        {
            string hw = ("Hello World!");
            hw = hw.Replace('o', '*');
            hw = hw.Replace('!', '1');
            Console.WriteLine(hw);
        }
    }
}
