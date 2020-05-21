using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {

            double valorDaCoca = 0.45;
            double total = 0;
            
            while (total <= valorDaCoca)
            {

                Console.WriteLine("insira moeda:");
                double entrada = double.Parse(Console.ReadLine());

                if (entrada == 0.25 || entrada == 0.10)
                    total += entrada;
                
                Console.WriteLine($"total: {total}");
            }

            Console.WriteLine("coca-cola");
            Console.ReadLine();
        }
    }
}
