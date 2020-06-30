using System;

namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int input = 0, attempts = 0;
            int minNumber = 0, maxNumber = 100;
            bool win = false;
            int guessedNumber = random.Next(minNumber, maxNumber);
            do
            {
                Console.Write($"Guess the integer number between {minNumber} and {maxNumber}:");
                if(int.TryParse(Console.ReadLine(), out input))
                {
                    attempts++;
                    if(input > guessedNumber)
                    {
                        Console.WriteLine("To high! Guess lower...");
                    }
                    else if(input < guessedNumber)
                    {
                        Console.WriteLine("To low! Guess higher...");
                    }
                    else
                    {
                        win = true;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect enter. Enter the integer number.");
                    Console.ReadKey();
                    Console.ResetColor();
                }

            } while (win == false);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Congratulations! You win. Attemps: {attempts}.");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
