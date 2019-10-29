using System;

namespace Pract2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            str = Console.ReadLine();
            int sk = str.Length;
            int[] k = new int[sk];
            string[] starto = str.Split(" ");
            for (int i = 0; i < sk; i++)
            {
                k[i] = Convert.ToInt32(str.Split(" "));
            }
            int[] a = new int[sk];
            int[] b = new int[sk];
            for (int i = 0; i < sk; i++)
            {
                a[i] = 0;
                b[i] = 0;
            }
            for (int i = 0; i < sk - 1; i++)
            {
                a[i] = k[i];
                b[i]++;
                if (k[i + 1] == k[i])
                {
                    b[i]++;
                }
            }
            int max = b[0];
            int index = 0;
            for (int i = 0; i < sk; i++)
            {
                if (b[i] > max)
                {
                    max = b[i];
                    index = i;
                }
            }
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine(a[index]);
            }
        }
    }
}
