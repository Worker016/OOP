using System;
class Trapezoid
{
    static void Main()
    {
        double a, b, h, area;
        Console.WriteLine("Введите а");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите h");
        h = Convert.ToDouble(Console.ReadLine());
        area = ((a + b) / 2) * h;
        Console.WriteLine(area);
    }
}
