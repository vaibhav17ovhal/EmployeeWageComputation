using EmployeeWageComputation;
using System;

namespace EmployeeWageComputataion
{
    public class Program
    {
        static void Main(string[] args)
        {
            MultipleCompanies abc = new MultipleCompanies();
            abc.ComputeEmpWage("Amazon", 20, 20, 8);
            abc.ComputeEmpWage("Facebook", 15, 20, 10);
        }
    }
}
