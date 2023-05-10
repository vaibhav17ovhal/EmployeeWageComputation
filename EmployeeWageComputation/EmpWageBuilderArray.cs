using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpWageBuilder: IComputeEmpWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private LinkedList<CompanyEmpWage> employees;
        private Dictionary<string, CompanyEmpWage> employeesMap;

        public EmpWageBuilder()
        {
            this.employees = new LinkedList<CompanyEmpWage>();
            this.employeesMap = new Dictionary<string, CompanyEmpWage>();
        }
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            this.employees.AddLast(companyEmpWage);
            this.employeesMap.Add(company, companyEmpWage);
        }
        public void computeEmpWage()
        {
            foreach(CompanyEmpWage companyEmpWage in this.employees)
            {
                companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString);
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
        public int getTotalWage(string company)
        {
            return this.employeesMap[company].totalEmpWage;
        }

    }
}
