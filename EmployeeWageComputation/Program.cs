﻿using EmployeeWageComputation;
using System;

namespace EmployeeWageComputataion
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation.");

            Console.WriteLine("=============X=============");

            EmployeeDetails.Attendance();

            Console.WriteLine("=============X=============");

            EmployeeDetails.CalculateWage();

            Console.WriteLine("=============X=============");

            EmployeeDetails.CalculatingPartTimeWage();
        }
    }
}
