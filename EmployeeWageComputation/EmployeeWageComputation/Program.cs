// See https://aka.ms/new-console-template for more information
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

            }
        }
    }
}
