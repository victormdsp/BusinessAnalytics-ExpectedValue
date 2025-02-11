using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    public static void Main()
    {
        Console.WriteLine("Press 1 to insert values with probability or 2 to only insert values (the probaility will be calculated equally): ");
        string option = Console.ReadLine();

        while (option != "1" || option != "2")
        {
            Console.WriteLine("Invalid option");
            Console.WriteLine("Press 1 to insert values with probability or 2 to only insert values: ");
        }

        if (option == "1")
        {
            Console.WriteLine("Insert the list of values and probability separated by semi-colons and commas: ");
            Console.WriteLine("Example - value;probability, value;probability, ...");
            string values = Console.ReadLine();
            Console.WriteLine($@"Given Value: {values}");
        }
        else
        {
            Console.WriteLine("Insert the list of values separated by commas: ");
            Console.WriteLine("Example - value, value, ...");
            string values = Console.ReadLine();

        }


    }

    public List<decimal> formatGivenList(string values)
    {
        List<string> result = values.Split(',').ToList();
        List<decimal> resultDecimal = new List<decimal>();
        foreach (string value in result)
        {
            resultDecimal.Add(decimal.Parse(value));
        }

        return resultDecimal;
    }

    public decimal expectedValueEqualProbability(List<decimal> values)
    {

    }
}
