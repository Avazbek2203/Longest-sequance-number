using System;

class Program
{
    static void Main(string[] args)
    {
        double number;
        double currentNumber = 0;
        double currentCount = 0;
        double maxNumber = 0;
        double maxCount = 0;

        while (true)
        {
            Console.Write("Enter an integer (enter 0 to exit): ");
            if (double.TryParse(Console.ReadLine(), out number))
            {
                if (number == 0)
                {
                    break;
                }
                else if (number == currentNumber)
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        maxNumber = currentNumber;
                    }
                    currentNumber = number;
                    currentCount = 1;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        if (currentCount > maxCount)
        {
            maxCount = currentCount;
            maxNumber = currentNumber;
        }

        Console.WriteLine($"Longest sequence: {maxCount} times number {maxNumber}.");
    }
}
