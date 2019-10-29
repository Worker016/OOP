using System;

namespace Pract2
{
    class Program
    {
        static void Main(string[] args)
        {

            String str = "hi php java xml csharp sql html css js";
            String[] spearator = { " " };
            String str2 = "nakov java sql html css js";
            Int32 count = str.Length;
            int i = 0, k = 0, j =0 ;
            String[] strlist = str.Split(spearator, count,
                   StringSplitOptions.None);
            String[] strlist2 = str2.Split(spearator, count,
                   StringSplitOptions.None);
            int a = strlist2.Length,b= strlist.Length;
            while (strlist[i] == strlist2[i])
            {
                k++;
                i++;
            }
            if (k == 0)
            {
                i = a-1;
                j = b-1;
                 while (strlist2[i] == strlist[j])
                  {
                      k++;
                      i--;
                      j--;
                  }
              }
            Console.WriteLine(k);
            Console.ReadKey();
            }
        }
    }
