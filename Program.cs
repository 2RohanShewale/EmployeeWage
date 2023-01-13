using EmployeeWageProblem;
using static System.Console;
class Program
{

    static void Main(string[] args)
    {
        Employee emp = new Employee();
        //Computation
        while(emp.totalEmpHrs <= Employee.MAX_HRS_IN_MONTH || emp.totalDays <= Employee.NUM_OF_WORKING_DAYS)
        {
            emp.totalDays++;
            Random random = new Random();
            int empCheck = random.Next(3);
            switch (empCheck)
            {
                case Employee.IS_FULL_TIME: emp.empHrs = 8; break;
                case Employee.IS_PART_TIME: emp.empHrs = 4; break;
                default: emp.empHrs = 0; break;
            }
            emp.totalEmpHrs += emp.empHrs;
            WriteLine("Day#: " + emp.totalDays +" EMP HRS : " + emp.empHrs);
        }
        emp.totalEmpWage = emp.totalEmpHrs * Employee.EMP_RATE_PER_HOUR;
        WriteLine("Total Emp Wage : " + emp.totalEmpWage);
    }
}