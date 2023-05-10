using EmployeeWageComputation;
using System;

namespace EmployeeWageComputataion
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray emp = new EmpWageBuilderArray();
            emp.addCompanyEmpWage("Audi", 20, 5, 160);
            emp.addCompanyEmpWage("Mercedes", 50, 5, 160);
            emp.computeEmpWage();
        }
    }
}
