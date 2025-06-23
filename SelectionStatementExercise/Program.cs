namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int favNum = 9;

            Console.WriteLine("Can You Guess My Favorate Number?");
            int userGuess = int.Parse(Console.ReadLine());

            while (userGuess != favNum)
            {
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
                }
            }
        }
    }
}
