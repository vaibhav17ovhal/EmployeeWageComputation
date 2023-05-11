using EmployeeWageComputation;
using System;

namespace EmployeeWageComputataion
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder emp = new EmpWageBuilder();
            emp.addCompanyEmpWage("Audi", 20, 5, 160);
            emp.addCompanyEmpWage("Mercedes", 50, 5, 160);
            emp.computeEmpWage();
            Console.WriteLine($"Total wage for Audi company: {emp.getTotalWage("Audi")}");
        }
    }
}
