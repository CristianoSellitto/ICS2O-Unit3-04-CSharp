// Cristiano
// ICS2O-Unit3-04-CSharp
// April 6 2022

using System;

class Program
{
    public static void Main(string[] args)
    {
        string selection;
        double answer;

        Console.WriteLine("Do you want to convert celsius or fahrenheit?");
        selection = Console.ReadLine();
        if (selection == "celsius")
        {
            double celsius;

            Console.WriteLine("Enter temperature in celsius:");
            celsius = Convert.ToSingle(Console.ReadLine());
            answer = (celsius * 9/5) + 32;
            Console.WriteLine("This temperature is equal to " + answer + "°F");
        }
        else if (selection == "fahrenheit")
        {
            double fahrenheit;

            Console.WriteLine("Enter temperature in fahrenheit:");
            fahrenheit = Convert.ToSingle(Console.ReadLine());
            answer = (fahrenheit - 32) * (5/9);
            Console.WriteLine("This temperature is equal to " + answer + "°C");
        }
        else
        {
            Console.WriteLine("Please specify if you want to convert celsius or fahrenheit. You may have made a typo.");
        }
        Console.WriteLine("\nFinished.");
    }
}
