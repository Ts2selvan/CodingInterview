using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterview
{
     class Fibonacci
    {
        public void CalculateFibonacci()
        {
            Console.WriteLine("Enter the number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int first = 0, second = 1, next;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(first + " ");
                next = first + second;
                first = second;
                second = next;

            }
            Console.ReadLine();
        }
       
}
}
