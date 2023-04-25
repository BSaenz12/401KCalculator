using System;

namespace _401KCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is the 401K Calculator app.\n");
            Console.WriteLine("----------------------------------------------\n");

            Double yearlyPercentage = 0.077;
            Double currentBalance = 19500;
            
            for (int x = 0; x <30; x++)
            {
                Double currentYearsGain = 0.00;

                if (x == 0)
                {
                    currentBalance += 4700;
                }
                else
                {
                    currentBalance += 7200;
                }

                currentYearsGain = currentBalance * yearlyPercentage;
                currentBalance += currentYearsGain;
                Console.WriteLine("End of Year " + (x + 1) + " Balance: " + currentBalance);
            }
            
            Console.WriteLine("\n----------------------------------------------\n\n");

            Console.WriteLine("That's all she wrote! Keep grinding, programming and having fun!\n Bruno says hi from the past! Today is 4/24/2023. Dad's 59th birthday!");
            Console.WriteLine("\n----------------------------------------------\n\n");
        }
    }
}
