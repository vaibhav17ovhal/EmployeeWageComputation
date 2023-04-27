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
        public const int IS_PART_TIME = 2;
        public const int WORKING_DAYS = 20;
        public const int TOTAL_HRS = 100;
        public static void Attendance()
        {
            int IS_PRESENT = 1;
            Random random = new Random();
            int check = random.Next(2);

            if (check == IS_PRESENT)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
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
        public static void CalculatingPartTimeWage()
        {
            int emp_Hr = 0;
            int emp_Wage = 0;

            Random random = new Random();
            int check = random.Next(3);

            if (check == IS_FULL_TIME)
            {
                emp_Hr = 8;
                Console.WriteLine("Employee is present and woking as full time.");
            }
            else if (check == IS_PART_TIME)
            {
                emp_Hr = 4;
                Console.WriteLine("Employee is present but working as part time.");
            }
            else
            {
                emp_Hr = 0;
                Console.WriteLine("Employee is Absent");
            }
            emp_Wage = emp_Hr * WAGE_PER_HR;
            
            Console.WriteLine($"Employee Wage: {emp_Wage}");
        } 
        public static void CalculatingPartTimeWageWithSwitch()
        {
            int emp_Hr = 0;
            int emp_Wage = 0;

            Random random = new Random();
            int check = random.Next(3);

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
            emp_Wage = emp_Hr * WAGE_PER_HR;

            Console.WriteLine($"Employee Wage: {emp_Wage}");
        }
        public static void CalculateWagesForMonth()
        {
            int emp_Hr = 0;
            int emp_Wage = 0;
            int MONTHLY_WAGE = 0;

            for (int i = 1; i <= WORKING_DAYS; i++)
            {
                Random random = new Random();
                int check = random.Next(3);

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
                emp_Wage = emp_Hr * WAGE_PER_HR;

                Console.WriteLine($"Employee Wage: {emp_Wage}");

                MONTHLY_WAGE += emp_Wage;
            }
            Console.WriteLine($"Employee Monthly Wage: {MONTHLY_WAGE}");
        }
        public static void CalculateWageTillCondition()
        {
            int emp_Hr = 0;
            int emp_Wage = 0;
            int total_Working_Hrs = 0;
            int total_Working_Days = 0;

            while (total_Working_Hrs < TOTAL_HRS && total_Working_Days < WORKING_DAYS)
            {
                total_Working_Days++;
                Random random = new Random();
                int check = random.Next(3);

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
                emp_Wage = emp_Hr * WAGE_PER_HR;

                Console.WriteLine($"Employee Wage: {emp_Wage}");

                total_Working_Hrs += emp_Hr;

                Console.WriteLine($"Day:{total_Working_Days} \t Employee Hrs:{emp_Hr} \t Employee Wage:{emp_Wage}");
            }
            int total_Emp_Wage = total_Working_Hrs * WAGE_PER_HR;

            Console.WriteLine($"Total Employee Wage: {total_Emp_Wage}");
        }
    }
}
