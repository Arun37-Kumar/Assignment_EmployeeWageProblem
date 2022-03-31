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
            int EMP_RATE_PER_HOUR = 20;

            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            //Computations
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
            Console.WriteLine("Employee wage : {0} ", empWage);
            Console.ReadLine();

        }

    }
}