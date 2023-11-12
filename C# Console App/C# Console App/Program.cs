using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
                // Convert string to integer using TryParse
                Console.Write("Enter an integer: ");
                string intInput = Console.ReadLine();

                if (int.TryParse(intInput, out int intResult))
                {
                    Console.WriteLine($"Successfully converted to integer: {intResult}");
                }
                else
                {
                    Console.WriteLine("Error: Invalid input for integer conversion");
                }

                // Convert string to double using Convert
                Console.Write("Enter a double: ");
                string doubleInput = Console.ReadLine();

                try
                {
                    double doubleResult = Convert.ToDouble(doubleInput);
                    Console.WriteLine($"Successfully converted to double: {doubleResult}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid input for double conversion");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error: Input is too large or too small for a double");
                }

                // Convert string to decimal using Parse
                Console.Write("Enter a decimal: ");
                string decimalInput = Console.ReadLine();

                try
                {
                    decimal decimalResult = decimal.Parse(decimalInput);
                    Console.WriteLine($"Successfully converted to decimal: {decimalResult}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid input for decimal conversion");
                }
                     //Part-2//
            
                // Convert string to integer using TryParse and multiply by 5 if successful
                Console.Write("Enter an integer: ");
                string intInput = Console.ReadLine();

                if (int.TryParse(intInput, out int intResult))
                {
                    int multipliedValue = intResult * 5;
                    Console.WriteLine($"Successfully converted to integer and multiplied by 5: {multipliedValue}");
                }
                else
                {
                    Console.WriteLine("Error: Invalid input for integer conversion");
                }

                // Convert string to DateTime using Convert and subtract 1 month if successful
                Console.Write("Enter a date (MM/dd/yyyy): ");
                string dateInput = Console.ReadLine();

                try
                {
                    DateTime dateResult = Convert.ToDateTime(dateInput);
                    DateTime modifiedDate = dateResult.AddMonths(-1);
                    Console.WriteLine($"Successfully converted to DateTime and subtracted 1 month: {modifiedDate:MM/dd/yyyy}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid input for DateTime conversion");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error: Input represents a date outside the range of a DateTime");
                }

                // Convert string to TimeSpan using Parse and add 2 hours if successful
                Console.Write("Enter a time (hh:mm): ");
                string timeInput = Console.ReadLine();

                try
                {
                    TimeSpan timeResult = TimeSpan.Parse(timeInput);
                    TimeSpan modifiedTime = timeResult.Add(new TimeSpan(2, 0, 0));
                    Console.WriteLine($"Successfully converted to TimeSpan and added 2 hours: {modifiedTime:hh\\:mm}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid input for TimeSpan conversion");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error: Input represents a time outside the range of a TimeSpan");
                }
            }
        }
    }
}
    

