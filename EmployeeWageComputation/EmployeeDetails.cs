using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeDetails
    {
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
    }
}
