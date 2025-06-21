using System;
using CodingInterview;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace FibonacciApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1 - Fibonacci Series");
                Console.WriteLine("2 - Factorial");
                Console.WriteLine("3 - Find Dublicate String");
                Console.WriteLine("4 - Find Dublicate String Array");
                Console.WriteLine("5 - LINQ - Filter all the employees whose salary is greater than 50000");
                Console.WriteLine("6 - LINQ - Get All Employees Names in Upper case");
                Console.WriteLine("55 - Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Fibonacci fib = new Fibonacci();
                        fib.CalculateFibonacci();
                        break;

                    case "2":
                        Factorial fact = new Factorial();
                        fact.CalculateFactorial();
                        break;
                    case "3":
                        DublicateString Ds = new DublicateString();
                        Ds.FindDubString();
                        break;
                    case "4":
                        DuplicateStringArray Dsa = new DuplicateStringArray();
                        Dsa.FindDubStringArray();
                        break;
                    case "5":
                        FilterSalary Fls = new FilterSalary();
                        Fls.FilterSalaryGreater();
                        break;
                    case "6":
                        AllEmpUpper UN = new AllEmpUpper();
                        UN.UpperEmpName();
                        break;


                    case "55":
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice! Please select 1, 2, or 3.");
                        break;
                }
            }
        }
    }
}