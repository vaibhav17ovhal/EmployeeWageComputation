using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class MultipleCompanies
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        public int ComputeEmpWage(string Company_Name, int WAGE_PER_HR, int WORKING_DAYS, int TOTAL_HRS)
        {
            int total_Working_Hrs = 0;
            int total_Working_Days = 0;

            while (total_Working_Hrs < TOTAL_HRS && total_Working_Days < WORKING_DAYS)
            {
                int emp_Hr = 0;
                total_Working_Days++;
                Random random = new Random();
                int check = random.Next(3);

                switch (check)
                {
                    case IS_FULL_TIME:
                        emp_Hr = 8;
                        //Console.WriteLine("Employee is present and working as full time.");
                        break;
                    case IS_PART_TIME:
                        emp_Hr = 4;
                        //Console.WriteLine("Employee is present but working as part time.");
                        break;
                    default:
                        emp_Hr = 0;
                        //Console.WriteLine("Employee is Absent.");
                        break;
                }
                total_Working_Hrs += emp_Hr;
            }
            int MONTHLY_WAGE = total_Working_Hrs * WAGE_PER_HR;

            Console.WriteLine($"Employee Monthly Wage: {MONTHLY_WAGE}");
            Console.WriteLine($"Total Employee Wage of {Company_Name} is {MONTHLY_WAGE}");
            return MONTHLY_WAGE;
        }
    }
}
