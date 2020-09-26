using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    public class OddNumbers
    {
        /// <summary>
        /// First prompt for the start and the end number. Then, Write all odd integers between start and ending number inclusive (in ascending order) on separate lines.
        /// </summary>

        public static void Main()
        {
            Console.Error.WriteLine("Enter the starting number");
            // Codes to enter start
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);
            Console.Error.WriteLine("Enter the ending number");
            string num = Console.ReadLine();
            int j = Convert.ToInt32(num);
            //add a while loop
            while (n <= j)
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n);
                }
                n++;
            }

            // Codes to enter end.
        }
    }
}
