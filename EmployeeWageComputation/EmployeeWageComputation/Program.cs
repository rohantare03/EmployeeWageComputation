﻿// See https://aka.ms/new-console-template for more information
namespace EmployeeWageComputation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for a particular problem:");
            Console.WriteLine("1 for checking Employee present or absent");

            int Check = Convert.ToInt32(Console.ReadLine());
            switch (Check)
            {
                case 1:
                    EmpPresentAbsent empPresentAbsent = new EmpPresentAbsent();
                    empPresentAbsent.CheckEmpPresentAbsent();
                    break;
            }
        }
    }
}
