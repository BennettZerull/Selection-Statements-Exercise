﻿namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var favNum = random.Next(1, 101);
            int userGuess = 0;

            while (userGuess != favNum)
            {
                Console.WriteLine("Can You My Number? Hint, It's Between 1 and 100?");
                userGuess = int.Parse(Console.ReadLine());

                if (userGuess < favNum)
                {
                    Console.WriteLine("To Low!");
                }
                else if (userGuess > favNum)
                {
                    Console.WriteLine("Too High!");
                }
                else
                {
                    Console.WriteLine("Got It!");
                    break;
                }
            }
        }
    }
}