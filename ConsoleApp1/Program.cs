using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double dolarBugun = 7.15;
            double dolarDun = 7.35;
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalıs  butuno ");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artıs  butuno ");
            }
            else
            {
                Console.WriteLine("Eşittir  butuno ");
            }
        }
    }
}
