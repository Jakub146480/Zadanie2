// See https://aka.ms/new-console-template for more information

using System;

public class Zadanie2
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Wprować pole koła");
        double p;

        p = inputValue();
        double r;

        r = Math.Pow(p / Math.PI, (double)1 / 2);
        double o;

        o = 2 * Math.PI * r;
        Console.WriteLine(o);
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
