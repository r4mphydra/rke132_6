using System;

namespace FirstorLast
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi:");
            string fn = Console.ReadLine();
            Console.WriteLine($"Sinu eesnimes on {fn.Length} sümbolit");
            Console.WriteLine("Sisesta perekonnanimi:");
            string ln = Console.ReadLine();
            Console.WriteLine($"Sinu eesnimes on {ln.Length} sümbolit");
            if (ln.Length > fn.Length)
            {
                Console.WriteLine($"Sinu perekonnanimi on {ln.Length - fn.Length} sümbolit pikem");
            }
            if (fn.Length > ln.Length)
            {
                Console.WriteLine($"Sinu eesnimi on {fn.Length - ln.Length} sümbolit pikem");
            }
            else
            {
                Console.WriteLine($"Sinu perekonnanimi ja eesnimi on sama pikad");
            }
        }
    }
}
