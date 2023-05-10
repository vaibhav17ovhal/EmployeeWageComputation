using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpWageBuilderArray
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }
        public void computeEmpWage()
        {
            for(int i = 0; i < numOfCompany; i++)
            {
                int val = this.computeEmpWage(this.companyEmpWageArray[i]);
                companyEmpWageArray[i].setTotalEmpWage(val);
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int emp_Hr = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(3);
                switch (empCheck)
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
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }

    }
}
