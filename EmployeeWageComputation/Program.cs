using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 1;
            //welcome message
            Console.WriteLine("Welcome to Employee Wage Computation Problem statement");
            //UC1- EmployeeAttendence
            Random random = new Random();
            int employeeAttendence = random.Next(0, 2); //0 or 1
            if(employeeAttendence==isPresent)
            {
                Console.WriteLine("employee attendence is present");
            }
            else
            {
                Console.WriteLine("employee attendence is absent");
            }
            Console.ReadLine();
        }
    }
}
