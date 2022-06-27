using System;

namespace GruppeOppgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Think of a number between 1 and 1000. \nPress [ENTER] when ready.");
            Console.ReadKey();

            Console.WriteLine("\nI will now find your secret number with a maximum of ten guesses.");

            int min = 0;
            int max = 1001;
            int guess = 500;

            bool keepPlaying = true;
            int counter = 0;

            while (keepPlaying)
            {
                Console.WriteLine($"\nIs your secret number {guess}?");
                counter++;

                Console.WriteLine("\nCorrect[K], Higher [H] or Lower [L]?");
                ConsoleKeyInfo input = Console.ReadKey();
               
                if (counter >  10)
                {
                    Console.WriteLine("\nOut of guesses");
                    keepPlaying = false;
                    break;
                }

                switch (input.Key)
                {
                    case ConsoleKey.K:
                        Console.WriteLine("\nI guessed your secret number!");
                        keepPlaying = false;
                        break;

                    case ConsoleKey.H:

                        min = guess;
                        guess = (min + max) / 2;
                        break;

                    case ConsoleKey.L:

                        max = guess;
                        guess = (min + max) / 2;
                        break;

                    default:
                        Console.WriteLine("\nInvalid key.\n");
                        break;
                }
            }

        }
    }
}

