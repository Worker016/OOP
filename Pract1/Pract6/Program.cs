using System;
class Last_Digit
{
    static void Main()
    {
        double a, lastDigit;
        Console.WriteLine("Введите а");
        a = Convert.ToDouble(Console.ReadLine());
        lastDigit = a % 10;
        Console.WriteLine(lastDigit);
    }
}