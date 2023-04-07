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
            //UC3- Employee part time wage
            Random random = new Random();
            int employeeAttendence = random.Next(0, 3); //0 , 1 or 2
            if (employeeAttendence == IS_FULL_TIME)
            {
                Console.WriteLine("employee attendence is present");
                empHrs = 8;
            }
            else if (employeeAttendence == IS_PART_TIME)
            {
                Console.WriteLine("Parttime employee attendence is present");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("employee attendence is absent");
                empHrs = 0;
            }
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee wage is:" + empWage);
            Console.ReadLine();
        }
    }
}
