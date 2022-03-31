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
            const int EMP_RATE_PER_HOUR = 20;
            const int NUMBER_OF_WORKING_DAYS = 20;

            //Variables
            int empHrs = 0;
            int empWage = 0;
            int empTotalWage = 0;

            //Computations
            for (int day = 0; day < NUMBER_OF_WORKING_DAYS; day++)
            {
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
                empWage = empHrs * EMP_RATE_PER_HOUR;
                empTotalWage += empWage;
                Console.WriteLine("Employee wage : {0} ", empWage);
            }
            Console.WriteLine("Total Employee Wage : {0}", empTotalWage);
            Console.ReadLine();

        }

    }
}