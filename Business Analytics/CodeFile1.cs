using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hi, this software calculate the expect value of given number.");
        int runProgram = 1;
        while(runProgram == 1)
        {
            Program program = new Program();

            Console.WriteLine("Press 1 to insert values with probability or 2 to only insert values (the probaility will be calculated equally): ");
            int.TryParse(Console.ReadLine(), out int option);
            Console.WriteLine("Option: {0}", option);

            while (option != 1 && option != 2)
            {
                Console.WriteLine("Invalid option");
                Console.WriteLine("Press 1 to insert values with probability or 2 to only insert values: ");
                option = Console.Read();
                Console.WriteLine("Option: {0}", option);

            }

            decimal result = option == 1 ? program.expectedValueDiffProbability() : program.expectedValueEqualProbability();
            Console.WriteLine("Expected Value = {0}", result);

            Console.WriteLine("If you want to calculate another expect value press 1, otherwise press any key to leave.");
            runProgram = Console.Read();
        }
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
        decimal probabilityPerValue = 1M / valuesFormated.Count();
        decimal result = 0M;

        foreach(decimal value in valuesFormated)
        {
            result += value * probabilityPerValue;
        }


        return result;
    }

    public decimal expectedValueDiffProbability()
    {
        string values = this.showMessageGetValues("Insert the list of values and probability separated by semi-colons and commas: ", "Example - value;probability, value;probability, ...");
        List<decimal> valuesFormated = this.formatListToDecimal(values);
        Console.WriteLine($@"Given Value Decimal: {valuesFormated}");
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
