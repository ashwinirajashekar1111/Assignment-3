using System;


namespace C_ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Details:");

            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Employee Gender (M/F): ");
            char gender = char.ToUpper(Console.ReadLine()[0]);

            Console.Write("Employee Salary: ");
            double salary = double.Parse(Console.ReadLine());

            Console.Write("Date of Joining (MM/DD/YYYY): ");
            DateTime doj = DateTime.Parse(Console.ReadLine());

            // Calculate tax based on salary
            double taxRate = (salary > 90000) ? 0.30 : 0.15;
            double taxAmount = salary * taxRate;

            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Employee Name: {name}");
            Console.WriteLine($"Employee Gender: {gender}");
            Console.WriteLine($"Employee Salary: {salary}");
            Console.WriteLine($"Date of Joining: {doj:MM/dd/yyyy}");
            Console.WriteLine("\nYou have to pay:");
            Console.WriteLine($"Tax Rate: {taxRate:P}");
            Console.WriteLine($"Tax Amount: {taxAmount:C}");

            Console.ReadKey();

        }
    }
}
