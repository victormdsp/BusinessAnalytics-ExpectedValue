using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    public static void Main()
    {
        Program program = new Program();

        Console.WriteLine("Press 1 to insert values with probability or 2 to only insert values (the probaility will be calculated equally): ");
        string option = Console.ReadLine();

        while (option != "1" || option != "2")
        {
            Console.WriteLine("Invalid option");
            Console.WriteLine("Press 1 to insert values with probability or 2 to only insert values: ");
        }

        decimal result = option == "1" ? program.expectedValueDiffProbability() : program.expectedValueEqualProbability();
    }

    public List<decimal> formatListToDecimal(string values)
    {
        List<string> result = values.Split(',').ToList();
        List<decimal> resultDecimal = new List<decimal>();
        foreach (string value in result)
        {
            resultDecimal.Add(decimal.Parse(value));
        }

        return resultDecimal;
    }

    public decimal expectedValueEqualProbability()
    {
        string values = this.showMessageGetValues("Insert the list of values separated by commas: ", "Example - value, value, ...");
        List<decimal> valuesFormated = this.formatListToDecimal(values);
        return 1.2M;
    }

    public decimal expectedValueDiffProbability()
    {
        string values = this.showMessageGetValues("Insert the list of values and probability separated by semi-colons and commas: ", "Example - value;probability, value;probability, ...");
        List<decimal> valuesFormatedDecimal = this.formatListToDecimal(values);
        return 1.2M;
    }

    public string showMessageGetValues(string message, string example)
    {
        Console.WriteLine(message);
        Console.WriteLine(example);
        string readValues = Console.ReadLine();
        Console.WriteLine($@"Given Value: {readValues}");
        return readValues;
    }
}
