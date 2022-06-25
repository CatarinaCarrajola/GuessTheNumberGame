﻿using System;

namespace GruppeOppgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Think of a number between 1 and 1000. \nPress [ENTER] when ready.");
            Console.ReadKey();

            Console.WriteLine("\nI will now find your secret number with a maximum of ten guesses.");

            int min = 1;
            int max = 1000;
            int firstGuess = 500;

            bool keepPlaying = true;
            int counter = 0;

            while (keepPlaying)
            {
                Console.WriteLine($"\nIs your secret number {firstGuess}?");
                Console.WriteLine("Correct[K], Higher [H] or Lower [L]?");
                ConsoleKeyInfo input = Console.ReadKey();

                counter++;

                if (counter >= 10)
                {
                    Console.WriteLine("\nOut of guesses");
                    keepPlaying = false;
                }

                switch (input.Key)
                {
                    case ConsoleKey.K:
                        Console.WriteLine("\nI guessed your secret number!");
                        keepPlaying = false;
                        break;

                    case ConsoleKey.H:

                        int higherGuess = (max + firstGuess) / 2;

                        Console.WriteLine($"\nIs your secret number {higherGuess}?");
                        input = Console.ReadKey();     

                        if (input.Key == ConsoleKey.H)
                        {
                            min = higherGuess;
                            firstGuess = (min + max) / 2;
                           
                        }

                        else if (input.Key == ConsoleKey.L)
                        {
                            min = firstGuess;
                            max = higherGuess;
                            firstGuess = (min + max) / 2;
                           
                        }

                        break;

                    case ConsoleKey.L:

                        int lowerGuess = (min + firstGuess) / 2;

                        Console.WriteLine($"\nIs your secret number {lowerGuess}?");
                        input = Console.ReadKey();

                        if (input.Key == ConsoleKey.L)
                        {
                            max = lowerGuess;
                            firstGuess = (min + max) / 2;
                        }

                        else if (input.Key == ConsoleKey.H)
                        {
                            min = lowerGuess;
                            max = firstGuess;
                            firstGuess = (min + max) / 2;
                        }

                        break;

                    default:
                        Console.WriteLine("\nInvalid key.\n");
                        break;
                }
            }

        }
    }
}
