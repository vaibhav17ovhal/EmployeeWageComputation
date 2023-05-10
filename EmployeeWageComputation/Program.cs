using EmployeeWageComputation;
using System;

namespace EmployeeWageComputataion
{
    public class Program
    {
        static void Main(string[] args)
        {
            SaveTotalWage google = new SaveTotalWage("Google", 20, 5, 160);
            SaveTotalWage tata = new SaveTotalWage("Tata", 10, 5, 160);

            google.computeEmpWage();
            Console.WriteLine(google.toString());

            tata.computeEmpWage();
            Console.WriteLine(tata.toString());
        }
    }
}
