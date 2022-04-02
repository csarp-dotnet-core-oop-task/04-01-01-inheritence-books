using System;
using Konyvek.model;

namespace Konyvek
{
    class Program
    {
        static void Main(string[] args)
        {
            PaperBook k1 = new PaperBook("Andrew Troelsen", "Pro C# 7", 155, 100);
            PaperBook k2 = new PaperBook("Matthew MacDonald", "Pro WPF in C# 2008", 110, 25);
            EBook ek = new EBook("Reiter István", "C# programozás lépésről lépésre", 340);
            Console.WriteLine(k1);
            k1.Sell(50);
            try
            {
                k1.Buy(-10);
            }
            catch (QuantityIsZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                k1.Sell(-20);
            }
            catch (QuantityIsZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                k1.Sell(100);
            }
            catch (QuantitySoldLargerExistingQuantityException e)
            {
                Console.WriteLine(e.Message);
            }
            ek.Download();
            ek.Download();
            ek.Download();
            Console.WriteLine(k1);
            Console.WriteLine(k2);
            Console.WriteLine(ek);
            Console.ReadKey();
        }
    }
}
