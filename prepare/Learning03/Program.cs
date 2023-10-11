using System;
using System.Diagnostics.Contracts;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Fraction num1 = new Fraction();
        Console.WriteLine(num1.GetFractionString());
        Console.WriteLine(num1.GetDecimalValue());

        Fraction num2 = new Fraction(5);
        Console.WriteLine(num2.GetFractionString());
        Console.WriteLine(num2.GetDecimalValue());

        Fraction num3 = new Fraction(3, 4);
        Console.WriteLine(num3.GetFractionString());
        Console.WriteLine(num3.GetDecimalValue());

        Fraction num4 = new Fraction(1, 3);
        Console.WriteLine(num4.GetFractionString());
        Console.WriteLine(num4.GetDecimalValue());
    }
}