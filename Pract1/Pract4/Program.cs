using System;
class Divisor
{
    static void Main()
    {
        int n;
        bool result;
        Console.WriteLine("Введите n");
        n = Convert.ToInt32(Console.ReadLine());
        if ((n % 9 == 0) || (n % 11 == 0) || (n % 13 == 0))
            result = true;
        else
            result = false;
        Console.WriteLine(result);
    }
}