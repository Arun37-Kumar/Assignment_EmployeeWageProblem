using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Problem : ");
            int PRESENT = 1;
            Random random = new Random();
            int isCheck = random.Next(0, 2);
            if (isCheck == PRESENT)
            {
                Console.WriteLine("Employee is present.");
            }
            else
            {
                Console.WriteLine("Employee is absent.");
            }
            Console.ReadLine();
        }
    }
}
