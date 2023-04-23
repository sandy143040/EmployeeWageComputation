using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeWage
    {
        
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        const int NUM_OF_WORKING_DAYS = 20;
        const int EMP_RATE_PER_HR = 20;
        const int MAX_HRS_IN_MONTH = 100;
        public static int ComputeEmpWage()
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int employeeAttendence = random.Next(0, 3);
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Total emp wage : " + totalEmpWage);
            return totalEmpWage;
        }
    }
}
