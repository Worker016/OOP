using System;
class BigAndOdd
{
    static void Main()
    {
        int n;
        bool result;
        Console.WriteLine("Введите n");
        n = Convert.ToInt32(Console.ReadLine());
        if (n > 20 && (n % 2 == 0))
            result = true;
        else
            result = false;
        Console.WriteLine(result);
    }
}