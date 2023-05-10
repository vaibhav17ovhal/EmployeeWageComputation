﻿using EmployeeWageComputation;
using System;

namespace EmployeeWageComputataion
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Welcome to Employee Wage Computation.");

            Console.WriteLine("=============X=============");

            EmployeeDetails.Attendance();

            Console.WriteLine("=============X=============");

            EmployeeDetails.CalculateWage();

            Console.WriteLine("=============X=============");

            EmployeeDetails.CalculatingPartTimeWage();

            Console.WriteLine("=============X=============");

            EmployeeDetails.CalculatingPartTimeWageWithSwitch();

            Console.WriteLine("=============X=============");

            EmployeeDetails.CalculateWagesForMonth();

            Console.WriteLine("=============X=============");

            EmployeeDetails.CalculateWageTillCondition();
            */

            //Refactor.ComputeEmployeeWage();

            //MultipleCompanies abc = new MultipleCompanies();
            //abc.ComputeEmpWage("Amazon", 20, 20, 8);
            //abc.ComputeEmpWage("Facebook", 15, 20, 10);

            SaveTotalWage google = new SaveTotalWage("Google", 20, 5, 160);
            SaveTotalWage tata = new SaveTotalWage("Tata", 10, 5, 160);

            google.computeEmpWage();
            Console.WriteLine(google.toString());

            tata.computeEmpWage();
            Console.WriteLine(tata.toString());
        }
    }
}
