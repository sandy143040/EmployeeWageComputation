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
            int totalEmpWage = 0;
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int NUM_OF_WORKING_DAYS = 20;
            const int EMP_RATE_PER_HR = 20;

            //welcome message
            Console.WriteLine("Welcome to Employee Wage Computation Problem statement");
            //Computation
            for(int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int employeeAttendence = random.Next(0, 3); //0 , 1 or 2
                switch (employeeAttendence)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = EMP_RATE_PER_HR * empHrs;
                totalEmpWage += empWage;
                Console.WriteLine("Employee wage is : " + empWage);
            }
                Console.WriteLine("total emp wage : " + totalEmpWage);
                Console.ReadLine();
        }
    }
}
