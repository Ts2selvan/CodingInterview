using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterview
{
     class DuplicateStringArray
    {
        public void FindDubStringArray()
        {
            Console.Write("How many words will you enter? ");
            int size = Convert.ToInt32(Console.ReadLine());

            string[] items = new string[size];

            // Get strings from user
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter word {i + 1}: ");
                items[i] = Console.ReadLine();
            }
            Console.WriteLine("Duplicate Strings :");

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == "0") // already counted
                { continue; }

                int count = 1;

                for (int j = i + 1; j < items.Length; j++)
                {
                    if (items[i] == items[j])
                    {
                        count++;
                        items[j] = "0"; // mark as counted
                    }
                }

                if (count > 1 )
                {
                    Console.WriteLine($"{items[i]} → {count} times");
                }
            }

        }
    }
}
