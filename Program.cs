using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_8_Random_Number_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> originalNumbers = new List<int>();
            Console.WriteLine("Enter 10 numbers:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Number {i + 1}: ");
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out int number))
                    {
                        originalNumbers.Add(number);
                        break; // Exit the loop if input is valid
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
            }
            List<int> filteredNumbers = originalNumbers.Where(n => n > 50).ToList();
            Console.WriteLine($"\nCount of original numbers: {originalNumbers.Count}");
            Console.WriteLine($"Count of filtered numbers (greater than 50): {filteredNumbers.Count}");
        }
    }
}






