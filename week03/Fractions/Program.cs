using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Fraction f1= new Fraction();
        Fraction f2= new Fraction(6);
        Fraction f3= new Fraction(6,7);

        Fraction f4 =new Fraction(1);
        Fraction f5= new Fraction(5);
        Fraction f6 = new Fraction(3,4);
        Fraction f7 = new Fraction(1,3);

        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        Console.WriteLine(f5.GetFractionString());
        Console.WriteLine(f5.GetDecimalValue());

        Console.WriteLine(f6.GetFractionString());
        Console.WriteLine(f6.GetDecimalValue());

        Console.WriteLine(f7.GetFractionString());
        Console.WriteLine(f7.GetDecimalValue());

    }
}