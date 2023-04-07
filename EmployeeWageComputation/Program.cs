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

            int empHrs = 0;
            int empWage = 0;
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;

            //welcome message
            Console.WriteLine("Welcome to Employee Wage Computation Problem statement");
            //UC3- Switch Case Statement
            Random random = new Random();
            int employeeAttendence = random.Next(0, 3); //0 , 1 or 2
            switch (employeeAttendence)
            {
                case IS_FULL_TIME:
                    // code block
                    empHrs = 8;
                    break;
                case IS_PART_TIME:
                    //code block
                    empHrs = 4;
                    break;
                default:
                    //code block
                    empHrs = 0;
                    break;
            }
               empWage = EMP_RATE_PER_HR * empHrs;
               Console.WriteLine("Employee wage is:" + empWage);
               Console.ReadLine();
        }
    }
}
