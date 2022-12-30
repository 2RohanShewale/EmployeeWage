using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        //Constants
        int IS_FULL_TIME = 1;
        Random random = new Random();
        //Computation
        int empCheck = random.Next(0,2);
        if (empCheck == IS_FULL_TIME)
        {
            WriteLine("Employee is present");
        }
        else
        {
            WriteLine("Empployee is absent");
        }
    }
}