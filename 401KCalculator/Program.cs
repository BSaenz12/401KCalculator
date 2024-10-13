using System;

namespace _401KCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \nThis is the 401K Calculator app.\n");
            Console.WriteLine("----------------------------------------------\n");

            Double annualPercentage = 0.077;
            Double currentBalance = 19500;
            int startingYear = 2023;

            Console.WriteLine("The current balance as of April " +  startingYear + " is: " + currentBalance.ToString("C"));
            Console.WriteLine("Assuming the following annual percentage: " + annualPercentage + "\n\n");
            
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

                currentYearsGain = currentBalance * annualPercentage;
                currentBalance += currentYearsGain;
                Console.WriteLine("End of Year " + (x + 1) + " (" + (startingYear+x) + ") Balance: " + currentBalance.ToString("C"));
            }
            
            Console.WriteLine("\n----------------------------------------------\n\n");

            Console.WriteLine("That's all she wrote! Keep grinding, programming and having fun!\n Bruno says hi from the past! Today is 4/24/2023. Dad's 59th birthday!");
            Console.WriteLine("\n----------------------------------------------\n\n");
        }
    }
}
