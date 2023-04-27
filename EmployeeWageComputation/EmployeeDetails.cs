using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeDetails
    {
        public const int IS_FULL_TIME = 1;
        public const int WAGE_PER_HR = 20;

        public static void CalculateWage()
        {
            int emp_Hr = 0;
            int emp_Wage = 0;

            Random random = new Random();
            int check = random.Next(2);

            if (check == IS_FULL_TIME)
            {
                emp_Hr = 8; 
                Console.WriteLine("Employee is Present");
            }
            else
            {
                emp_Hr = 0;
                Console.WriteLine("Employee is Absent");
            }
            emp_Wage = emp_Hr * WAGE_PER_HR;
            Console.WriteLine($"Employee Wage: {emp_Wage}");
        }
    }
}
