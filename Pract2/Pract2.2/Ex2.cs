using System;
namespace Pract2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            String[] spearator = { " " };
            Int32 count = str.Length;
            String[] array1= str.Split(spearator, count, StringSplitOptions.None); 
            int rotations = Convert.ToInt32(Console.ReadLine());
            int[] sumArray = new int[array1.Length];
            int[] sumArray2 = new int[array1.Length];
            int[] answer = new int[array1.Length];
            if (rotations == 1)
            {
                for (int i = 0; i < rotations; i++)
                {       
                    for (int j = 0; j < 1; j++)
                    {
                        sumArray[i] = Convert.ToInt32(array1[array1.Length - 1]);

                    }
                    for (int k = 1; k < array1.Length; k++)
                    {
                        sumArray[k] = Convert.ToInt32(array1[k - 1]);
                        if (k == array1.Length - 1)
                        {
                            break;
                        }
                    }
                    for (int l = 0; l < array1.Length; l++)
                    {
                        answer[l] = sumArray2[l] + sumArray[l];
                        array1[l] = Convert.ToString(sumArray[l]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < rotations; i++)
                {     
                    for (int j = 0; j < 1; j++)
                    {
                        sumArray[j] = Convert.ToInt32(array1[array1.Length - 1]);

                    }
                    for (int k = 1; k < array1.Length; k++)
                    {
                        sumArray[k] = Convert.ToInt32(array1[k - 1]);
                        if (k == array1.Length - 1)
                        {
                            break;
                        }

                    }
                    for (int l = 0; l < array1.Length; l++)
                    {
                        answer[l] = sumArray2[l] + sumArray[l];
                        array1[l] = Convert.ToString(sumArray[l]);
                        sumArray2[l] = answer[l];

                    }
                }
            }
            Console.Write(string.Join(" ", answer));
            Console.ReadKey();
        }
    }
}