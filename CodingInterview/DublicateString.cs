using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterview
{
     class DublicateString
    {
        public void FindDubString()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine().ToLower();

            char[] chars = input.ToCharArray();

            Console.WriteLine("Duplicate characters:");

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '0') // already counted
                { continue; }

                int count = 1;

                for (int j = i + 1; j < chars.Length; j++)
                {
                    if (chars[i] == chars[j])
                    {
                        count++;
                        chars[j] = '0'; // mark as counted
                    }
                }

                if (count > 1 && chars[i] != ' ')
                {
                    Console.WriteLine($"{chars[i]} → {count} times");
                }
            }

        }
    }
}
