using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class Refactor
    {
        public const int IS_FULL_TIME = 1;
        public const int WAGE_PER_HR = 20;
        public const int IS_PART_TIME = 2;
        public const int TOTAL_HRS = 100;
        public const int WORKING_DAYS = 20;

        public static int emp_Hr = 0;
        public static int emp_Wage = 0;
        public static int MONTHLY_WAGE = 0;
        public static int total_Working_Hrs = 0;
        public static int total_Working_Days = 0;
        public static int GetWorkingHour(int check)
        {
            int emp_Hr = 0;
            switch (check)
            {
                case IS_FULL_TIME:
                    emp_Hr = 8;
                    Console.WriteLine("Employee is present and working as full time.");
                    break;
                case IS_PART_TIME:
                    emp_Hr = 4;
                    Console.WriteLine("Employee is present but working as part time.");
                    break;
                default:
                    emp_Hr = 0;
                    Console.WriteLine("Employee is Absent.");
                    break;
            }
            return emp_Hr;
        }
        public static void ComputeEmployeeWage()
        {
            int MONTHLY_WAGE = 0;
            while (total_Working_Hrs < TOTAL_HRS && total_Working_Days < WORKING_DAYS)
            {
                total_Working_Days++;
                Random random = new Random();
                int check = random.Next(3);
                emp_Hr = GetWorkingHour(check);
                total_Working_Hrs += emp_Hr;
            }
            MONTHLY_WAGE = total_Working_Hrs * WAGE_PER_HR;
            
            Console.WriteLine($"Employee Monthly Wage: {MONTHLY_WAGE}");
        }
    }
}
