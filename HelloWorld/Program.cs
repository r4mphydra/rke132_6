using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string hw = $"Hello World!".ToLower();
            Console.WriteLine(hw);
            int hc = 0;
            int oc = 0;
            int lc = 0;
            for (int i = 0; i < hw.Length; i++)
            {
                if (hw[i] == 'h')
                {
                    hc++;
                }
            }

            if (hc != 1)
            {
                Console.WriteLine($"{hw} on {hc} 'h' tähte.");
            }
            else
            {
                Console.WriteLine($"{hw} on {hc} 'h' tähte.");
            }
            for (int i = 0; i < hw.Length; i++)
            {
                if (hw[i] == 'o')
                {
                    oc++;
                }
            }

            if (hc != 1)
            {
                Console.WriteLine($"{hw} on {oc} 'o' tähte.");
            }
            else
            {
                Console.WriteLine($"{hw} on {oc} 'o' tähte.");
            }
            for (int i = 0; i < hw.Length; i++)
            {
                if (hw[i] == 'l')
                {
                    lc++;
                }
            }

            if (hc != 1)
            {
                Console.WriteLine($"{hw} on {lc} 'l' tähte.");
            }
            else
            {
                Console.WriteLine($"{hw} on {lc} 'l' tähte.");
            }
        }
    }
}
