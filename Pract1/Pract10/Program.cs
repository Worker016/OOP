using System;
class Sign
{
    static void Main()
    {
        double a, b, c;
        short k = 0;
        Console.WriteLine("Введите a");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите c");
        c = Convert.ToDouble(Console.ReadLine());
        if (a < 0)
            k++;
        if (b < 0)
            k++;
        if (c < 0)
            k++;
        if (k == 1 || k == 3)
            Console.WriteLine("Negative");
        else
            Console.WriteLine("Positive");

    }
}
