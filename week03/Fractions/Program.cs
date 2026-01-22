using System;
namespace Franctions;

class Program
{
    static void Main(string[] args)
    {
        Fractions noArg = new Fractions();
        Fractions wholeNumber = new Fractions(5);
        Fractions fac = new Fractions(3,10);

        noArg.SetTop(40);
        noArg.SetBottom(10);
        Console.WriteLine(noArg.GetTop());
        Console.WriteLine(noArg.GetBottom());
        Console.WriteLine(noArg.GetFractionString());
        Console.WriteLine(noArg.GetDecimalValue());


        Console.WriteLine(fac.GetFractionString());
        Console.WriteLine(fac.GetDecimalValue());


    }
}