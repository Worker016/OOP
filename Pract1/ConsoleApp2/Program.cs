using System;
class MAX
{
    static void Main()
    {
        double a, b, c;
        Console.WriteLine("Введите a");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите c");
        c = Convert.ToDouble(Console.ReadLine());
        if ((a > b) && (a > c))
            Console.WriteLine($"Max: {a}");
        if ((c > a) && (c > b))
            Console.WriteLine($"Max: {c}");
        if ((b > a) && (b > c))
            Console.WriteLine($"Max: {b}");
    }
}
