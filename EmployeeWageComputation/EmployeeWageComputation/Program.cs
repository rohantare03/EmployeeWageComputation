﻿// See https://aka.ms/new-console-template for more information
namespace EmployeeWageComputation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for a particular problem:");
            Console.WriteLine("1 for checking Employee present or absent");
            Console.WriteLine("2 for Daily Employee Wage");
            Console.WriteLine("3 for Part time Employee Wage");
            Console.WriteLine("4 for Employee Wage Switch Case");
            Console.WriteLine("5 for Monthly Wages");
            Console.WriteLine("6 for Employee Wages for hours and days in a month");
            Console.WriteLine("7 for Employee Wage Method");
            Console.WriteLine("8 for Company wage using dictionary");
            Console.WriteLine("9 for Total company wage");
            Console.WriteLine("10 for Employee for multiple companies");

            int Check = Convert.ToInt32(Console.ReadLine());
            switch (Check)
            {
                case 1:
                    EmpPresentAbsent empPresentAbsent = new EmpPresentAbsent();
                    empPresentAbsent.CheckEmpPresentAbsent();
                    break;
                case 2:
                    DailyEmpWage dailyEmpWage = new DailyEmpWage();
                    dailyEmpWage.DailyWage();
                    break;
                case 3:
                    PartTimeEmpWage partTimeEmpWage = new PartTimeEmpWage();
                    partTimeEmpWage.PartTimeWage();
                    break;
                case 4:
                    EmpWageSwitch empWageSwitch = new EmpWageSwitch();
                    empWageSwitch.EmpWage();
                    break;
                case 5:
                    MonthlyWages monthlyWages = new MonthlyWages();
                    monthlyWages.MonthWage();
                    break;
                case 6:
                    EmpWageHrsDays empWageHrsDays = new EmpWageHrsDays();   
                    empWageHrsDays.CalcWage();
                    break;
                case 7:
                    EmpWageMethod empWageMethod = new EmpWageMethod();
                    empWageMethod.CalculateWage();
                    break;
                case 8:
                    EmpWageComputation empWageComputation = new EmpWageComputation();
                    empWageComputation.AddCompany("TATA", 20, 8, 4, 100, 20);
                    empWageComputation.CalcEmpWage("tata");
                    empWageComputation.AddCompany("MAHINDRA", 30, 8, 4, 100, 20);
                    empWageComputation.CalcEmpWage("mahindra");
                    break;
                case 9:
                    CompanyWage_Computation companyWageComputation = new CompanyWage_Computation();
                    companyWageComputation.Add_Company("TATA", 20, 8, 4, 100, 20);
                    companyWageComputation.Calc_CompanyWage("tata");
                    companyWageComputation.Add_Company("MAHINDRA", 30, 8, 4, 100, 20);
                    companyWageComputation.Calc_CompanyWage("mahindra");
                    break;
                case 10:
                    WageComputation computation = new WageComputation(3);
                    computation.AddCompany("TATA", 20, 8, 4, 100, 20);
                    computation.WageCalculation("tata");
                    computation.AddCompany("MAHINDRA", 30, 8, 4, 100, 20);
                    computation.WageCalculation("mahindra");
                    computation.AddCompany("DMART", 40, 9, 5, 100, 20);
                    computation.WageCalculation("dmart");
                    computation.ViewWage();
                    break;



            }
        }
    }
}
