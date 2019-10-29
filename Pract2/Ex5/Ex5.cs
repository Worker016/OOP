using System;

namespace Pract2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1, s2;
            s1 = Console.ReadLine();
            s2 = Console.ReadLine();
            string[] s11 = s1.Split(" ");
            string[] s22 = s2.Split(" ");
            string s111 = "", s222 = "";
            for (int i = 0; i < s11.Length; i++)
                s111 += s11[i];
            for (int i = 0; i < s22.Length; i++)
                s222 += s22[i];
            string a = s111;
            string b = s222;
            int min = a.Length;
            if (b.Length < min)
                min = b.Length;
            for (int i = 0; i < min; i++)
            {
                if (a[i] > b[i])
                {
                    string t = a;
                    a = b;
                    b = t;
                    break;
                }
                else if (a[i] < b[i])
                {
                    break;
                }
                else
                {
                    if (i != min - 1)
                        continue;
                    if (i == min - 1)
                    {
                        if (a.Length < b.Length)
                        {
                            break;
                        }
                        if (a.Length > b.Length)
                        {
                            string t = a;
                            a = b;
                            b = t;
                            break;
                        }
                        if (a.Length == b.Length)
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
