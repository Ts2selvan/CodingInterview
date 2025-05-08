using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodingInterview
{
    class Factorial
    {
        public void CalculateFactorial()
        {
            Console.WriteLine("enter the number ");
            int n = Convert.ToInt32(Console.ReadLine());
           
            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;

            }
            Console.WriteLine($"Factorial of {n} is {factorial}");
        }
    }
}
