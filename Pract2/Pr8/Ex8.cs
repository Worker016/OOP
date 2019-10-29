using System;

namespace Pract2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string[] s2 = s1.Split(" ");
            int[] a = new int[s2.Length];
            int n = s2.Length;
            for (int i = 0; i < n; i++)
            {
                a[i] = Int32.Parse(s2[i]);
            }
            int[] u = new int[n];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                bool exists = false;
                for (int j = 0; j < k; j++)
                    if (a[i] == u[j])
                        exists = true;
                if (!exists)
                {
                    u[k] = a[i];
                    k++;
                }
            }
            int[] count = new int[k];
            for (int i = 0; i < k; i++)
                count[i] = 0;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (u[i] == a[j])
                    {
                        count[i]++;
                    }
                }
            }
            int max = count[0];
            int best = u[0];
            for (int i = k - 1; i >= 0; i--)
            {
                if (max <= count[i])
                {
                    max = count[i];
                    best = u[i];
                }
            }
            Console.WriteLine($"Best: {best} Frequency: {max} ");
            Console.ReadKey();

        }
    }
}