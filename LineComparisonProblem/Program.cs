using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 1.5;
            double y = 2.5;

            // Define another point to create a line
            double x2 = 3.0;
            double y2 = 4.0;

            // Calculate length of line
            double length = Math.Sqrt(Math.Pow(x2 - x, 2) + Math.Pow(y2 - y, 2));

            // Output result
            Console.WriteLine("Length of line: " + length);
            Console.ReadLine();
        }
    }
}
