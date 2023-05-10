using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class SaveTotalWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public SaveTotalWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void computeEmpWage()
        {
            int emp_Hr = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while(totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(3);
                switch(empCheck)
                {
                    case IS_FULL_TIME:
                        emp_Hr = 8;
                        break;
                    case IS_PART_TIME:
                        emp_Hr = 4;
                        break;
                    default:
                        emp_Hr = 0;
                        break;
                }
                totalEmpHrs += emp_Hr;
                Console.WriteLine($"Day: {totalWorkingDays}    Emp Hours: {emp_Hr}");
                Console.WriteLine($"Total emp hrs: {totalEmpHrs}");
            }
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine($"Total Emp Wage for company: {company} is {totalEmpWage}");
        }
        public string toString()
        {
            return $"Total Emp Wage for company: {this.company} is {this.totalEmpWage}";
        }
    }
}
