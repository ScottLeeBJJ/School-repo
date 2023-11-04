using System;

namespace ConvertAnyDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any single value of any data type:");
            string input = Console.ReadLine();

            Console.WriteLine("Enter the desired data type to convert to:");
            string dataType = Console.ReadLine();

            object output;
            switch (dataType.ToLower())
            {
                case "int":
                    output = Convert.ToInt32(input);
                    break;
                case "double":
                    output = Convert.ToDouble(input);
                    break;
                case "float":
                    output = Convert.ToSingle(input);
                    break;
                case "string":
                    output = Convert.ToString(input);
                    break;
                case "bool":
                    output = Convert.ToBoolean(input);
                    break;
                default:
                    Console.WriteLine("Unsupported data type. Only int, double, float, string, and bool are supported.");
                    return;
            }

            Console.WriteLine($"Converted value: {output}");
        }
    }
}