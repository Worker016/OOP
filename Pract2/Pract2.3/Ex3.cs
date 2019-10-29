using System;

namespace Pract2
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 k;
            k = Convert.ToInt32(Console.ReadLine());
            string str;
            str = Console.ReadLine();
            String[] spl = str.Split();
            int[] ar = new int[k * 4];
            for (int i = 0; i < k * 4; i++)
                ar[i] = Convert.ToInt32(spl[i]);
            int[] a = new int[k * 2];
            int[] b = new int[k * 2];
            for (int i = 0; i < k; i++)
            {
                a[i] = ar[i];
                b[i] = ar[i + k];
                Console.WriteLine(a[i]);
                Console.WriteLine(b[i]);
            }
            for (int i = k + 1; i < (k * 2) + 1; i++)
            {
                a[i] = ar[i];
                b[i] = ar[i + k];
                Console.WriteLine(a[i]);
                Console.WriteLine(b[i]);
            }
            int[] s = new int[k * 2];
            for (int i = 0; i < k * 2; i++)
            {
                s[i] = a[i] + b[i];
            }
            for (int i = 0; i < k * 2; i++)
            {
                Console.WriteLine(s[i]);
            }
            Console.ReadKey();
        }
    }
}