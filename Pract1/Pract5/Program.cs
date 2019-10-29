using System;
class Factorial
{
    static void Main()
    {
        double n, factorial = 1;
        Console.WriteLine("Введите n");
        n = Convert.ToDouble(Console.ReadLine());
        for (int i = 2; i <= n; i++)
        { factorial = factorial * i; }
        Console.WriteLine(factorial);
    }
}
