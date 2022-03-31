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
            int PRESENT = 1;
            int EMP_RATE_PER_HOUR = 20;

            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            int isCheck = random.Next(0, 2);
            if (isCheck == PRESENT)
            {
                Console.WriteLine("Employee is present.");
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