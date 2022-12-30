using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        //Constants
        const int IS_FULL_TIME = 2;
        const int IS_PART_TIME = 1;        const int EMP_RATE_PER_HOUR = 20;

        //variables
        Random random = new Random();
        int empHrs = 0;
        int empWage = 0;
        //Computation
        int empCheck = random.Next(3);
        switch (empCheck)
        {
            case IS_FULL_TIME: empHrs = 8; break;
            case IS_PART_TIME: empHrs|= 4; break;
            default:empHrs = 0; break;
        }
        empWage = empHrs * EMP_RATE_PER_HOUR;
        WriteLine("Emp Wage: " + empWage);
    }
}