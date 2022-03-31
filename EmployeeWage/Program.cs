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
            int PART_TIME = 1;
            int FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;

            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            //Computations
            int isCheck = random.Next(0, 3);
            if (isCheck == FULL_TIME)
            {
                Console.WriteLine("Employee is present.");
                empHrs = 8;
            }
            else if (isCheck == PART_TIME)
            {
                Console.WriteLine("Employee is present for part time.");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent.");
                empHrs = 0;
            }

            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wage : {0} ", empWage);
            Console.ReadLine();

        }

    }
}