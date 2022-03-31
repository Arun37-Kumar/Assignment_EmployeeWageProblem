using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Problem : ");

            //Constants
            const int PART_TIME = 1;
            const int FULL_TIME = 2;
            const int EMP_RATE_PER_HOUR = 100;
            const int NUMBER_OF_WORKING_DAYS = 20;
            const int MAX_HOURS_IN_MONTH = 10;

            //Variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int empTotalWage = 0;
            int totalWorkingDays = 0;

            //Computations
            while (empTotalWage <= MAX_HOURS_IN_MONTH && totalWorkingDays < NUMBER_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int isCheck = random.Next(0, 3);
                switch (isCheck)
                {
                    case PART_TIME:
                        empHrs = 8;
                        break;
                    case FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hours : " + empHrs);
            }
            empTotalWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage : " + empTotalWage);
            Console.ReadLine();

        }

    }
}