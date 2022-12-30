using static System.Console;
class Program
{
    public const int IS_FULL_TIME = 2;
    public const int IS_PART_TIME = 1; 
    public const int EMP_RATE_PER_HOUR = 20;
    public const int NUM_OF_WORKING_DAYS = 20;
    public const int MAX_HRS_IN_MONTH = 100;
    static void Main(string[] args)
    {
        int empHrs = 0; int totalDays = 0;
        int totalEmpWage = 0 , totalEmpHrs = 0;
        //Computation
        while(totalEmpHrs <= MAX_HRS_IN_MONTH && totalDays <= NUM_OF_WORKING_DAYS)
        {
            totalDays++;
            Random random = new Random();
            int empCheck = random.Next(3);
            switch (empCheck)
            {
                case IS_FULL_TIME: empHrs = 8; break;
                case IS_PART_TIME: empHrs = 4; break;
                default: empHrs = 0; break;
            }
            totalEmpHrs += empHrs;
            WriteLine("Day#: " + totalDays +" EMP HRS : " + empHrs);
        }
        totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
        WriteLine("Total Emp Wage : " + totalEmpWage);
    }
}