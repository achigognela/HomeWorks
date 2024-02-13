using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Collections.Generic;





#region Task1
{


    static void Main(string[] args)
    {
        // Check if the required argument is provided
        if (args.Length != 1)
        {
            Console.WriteLine("Please provide the number of lines to write to the file.");
            return;
        }

        // Parse the argument as an integer
        if (!int.TryParse(args[0], out int numLines) || numLines <= 0)
        {
            Console.WriteLine("Please provide a valid positive integer.");
            return;
        }

        // File path
        string filePath = "output.txt";

        try
        {
            // Write lines to the file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < numLines; i++)
                {
                    Console.Write($"Enter line {i + 1}: ");
                    string line = Console.ReadLine();
                    writer.WriteLine(line);
                }
            }

            // Read the last line from the file
            using (StreamReader reader = new StreamReader(filePath))
            {
                string lastLine = null;
                while (!reader.EndOfStream)
                {
                    lastLine = reader.ReadLine();
                }
                Console.WriteLine($"Last line from the file: {lastLine}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
#endregion


#region Task2




    
        // Check if the required argument is provided
        if (args.Length != 1)
        {
            Console.WriteLine("Please provide a single integer as input.");
            return;
        }

        // Parse the argument as an integer
        if (!int.TryParse(args[0], out int N) || N <= 0)
        {
            Console.WriteLine("Please provide a valid positive integer.");
            return;
        }

        // File path
        string filePath = "multiplication_table.txt";

        try
        {
            // Write the multiplication table to the file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 1; i <= N; i++)
                {
                    for (int j = 1; j <= 9; j++)
                    {
                        writer.Write($"{i} * {j} = {i * j}\t|\t");
                    }
                    writer.WriteLine();
                }
            }

            Console.WriteLine($"Multiplication table from 1 to {N} has been written to {filePath}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    


#endregion

#region Task3


{
    
    
        // Check if the required arguments are provided
        if (args.Length != 2)
        {
            Console.WriteLine("Please provide a string and a positive integer as input.");
            return;
        }

        // Parse the second argument as an integer
        if (!int.TryParse(args[1], out int N) || N <= 0)
        {
            Console.WriteLine("Please provide a valid positive integer as the second argument.");
            return;
        }

        string inputString = args[0];
        int substringLength = inputString.Length / N;

        // File path
        string filePath = "output.xml";

        try
        {
            // Write XML nodes to the file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
                writer.WriteLine("<root>");

                for (int i = 0; i < inputString.Length; i += substringLength)
                {
                    string substring = inputString.Substring(i, Math.Min(substringLength, inputString.Length - i));
                    writer.WriteLine($"    <node>{substring}</node>");
                }

                writer.WriteLine("</root>");
            }

            Console.WriteLine($"XML file with substrings from the input string has been created: {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

#endregion