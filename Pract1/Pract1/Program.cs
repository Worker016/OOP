using System;
class Average
{
    static void Main()
    {
        int a, b, c;
        decimal average;
        Console.WriteLine("Введите а");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите b");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите c");
        c = Convert.ToInt32(Console.ReadLine());
        average = (a + b + c) / 3;
        Console.WriteLine(average);
    }
}