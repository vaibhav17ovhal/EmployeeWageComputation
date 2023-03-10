using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWage
    {
        const int IS_PRESENT = 1, WAGE_PER_HR = 20, FULL_DAY_HR = 8, PART_TIME_HR = 4, IS_FULL_TIME = 0, IS_PART_TIME = 1;
        public void Attendance()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == IS_PRESENT)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
        public void DailyEmpWage()
        {
            int empHrs = 0;
            Random random = new Random();
            int check = random.Next(0, 3);
            if (check == IS_FULL_TIME)
                empHrs = FULL_DAY_HR;
            if (check == IS_PART_TIME)
                empHrs = PART_TIME_HR;
            else
                empHrs = 0;
            int wage = WAGE_PER_HR * FULL_DAY_HR;
            Console.WriteLine(wage);
        }
    }
}
