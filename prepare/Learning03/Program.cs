using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction number1 = new Fraction();
        Fraction number2 = new Fraction(6);
        Fraction number3 = new Fraction(6,7);
        Console.WriteLine(number1.GetFractionString());
        Console.WriteLine(number2.GetFractionString());
        Console.WriteLine(number3.GetFractionString());

        Fraction number4 = new Fraction();
        number4.SetTop(7);
        Console.WriteLine(number4.GetTop());
        Console.WriteLine(number4.GetFractionString());

        Console.WriteLine(number3.GetDecimalValue());
    }
}