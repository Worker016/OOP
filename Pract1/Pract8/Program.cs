using System;
class N_Digit
{
    static void Main()
    {
        int number, nDigit, n, d;
        Console.WriteLine("Введите number");
        number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите n");
        n = Convert.ToInt32(Console.ReadLine());
        d = 10 ^ (n - 1);
        nDigit = (number / d) % 10;
        Console.WriteLine(nDigit);
    }
}
