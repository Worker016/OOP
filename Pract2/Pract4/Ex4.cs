using System;

namespace Pract2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); 
            bool[] primes = new bool[n];
            for (int i = 0; i < n; i++)
                primes[i] = true;
            primes[0] = false;
            primes[1] = false;
            for (int i = 0; i < n; i++) 
            {
                if (primes[i] == true)
                {
                    Console.Write($"{i} ");
                    for (int j = 2; j * i < n; j++)
                    {
                        primes[j * i] = false;
                    }
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
