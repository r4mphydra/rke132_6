using System;

namespace CharCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi:");
            string fn = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi:");
            string ln = Console.ReadLine();
            string fln = $"{fn} {ln}".ToLower();
            Console.WriteLine(fln);
            int ac = 0;
            for(int i =0; i<fln.Length; i++)
            {
                if (fln[i] == 'a')
                {
                    ac++;
                }
            }

            if (ac != 1)
            {
                Console.WriteLine($"Sinu nimis {fn} on {ac} 'a' tähte.");
            }
            else
            {
                Console.WriteLine($"Sinu nimis {fn} on {ac} 'a' tähte.");
            }
        }
    }
}
