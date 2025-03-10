using System;

namespace guessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int min = 0;
            int tryCount = 0;
            int gamesCount = 0;
            Random random = new Random();
            ConsoleKeyInfo tmp;
            do {
                gamesCount++;
                int number = random.Next(1, 101);
                int attemptCount = 0;
                while (true)
                {
                    attemptCount++;
                    Console.WriteLine("enter you try in [1; 100] ");
                    int tries = 0;
                    while (!int.TryParse(Console.ReadLine(), out tries)
                        || tries < 1 || tries > 100)
                    {
                        Console.WriteLine("error. enter correct number in [1; 100]");
                    }
                    if (tries > number)
                        Console.WriteLine("youer try is more");
                    else if (tries < number)
                        Console.WriteLine("your try is less");
                    else
                    {
                        Console.WriteLine("you win");
                        break;
                    }
                }
                tryCount += attemptCount;
                if (max < attemptCount) max = attemptCount;
                min = min == 0 || min > attemptCount ? attemptCount : min;
                Console.WriteLine("enter Y if you want play again");
                tmp = Console.ReadKey();
            } while (tmp.Key == ConsoleKey.Y);
            Console.WriteLine($"max = {max}\n Min = {min}\n Avg = {(double)tryCount/gamesCount}");



        }
    }
}
