using System;

namespace whileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMeanu = true;
            while (displayMeanu)
            {
                MainMenu();
            }
        }

        public static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Print Number Game");
            Console.WriteLine("2) Guessing Game");
            Console.WriteLine("3) Exit");
            String result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumberGame();
                return true;
            }else if (result == "2")
            {
                GuessTheNumberGame();
                return true;
            }
            else
            {
                return false;
            } 
        }

        public static void PrintNumberGame()
        {
            Console.Clear();
            Console.Write("Print Number!");
            Console.Write("Type Number!");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < result+1)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            Console.ReadLine();
        }

        public static void GuessTheNumberGame()
        {
            Console.Clear();
            Console.WriteLine("Guess the Number!!!");
            Random randomNumber = new Random();
            int randomNumberValue = randomNumber.Next(1,11);

            int guessCount = 0;
            bool inCorrectAns = true;
            do
            {
                Console.WriteLine("Guess the Value");
                string readGuessedValue = Console.ReadLine();
                guessCount++;
                if (randomNumberValue.ToString() == readGuessedValue)
                    inCorrectAns = false;
                else
                    Console.Write("Wrong guess!!!");
            } while (inCorrectAns);
            Console.Write("Correct guess!!!.It took you {0} to GUESS Correct Number.", guessCount);
            Console.ReadLine();
        }
    }
}
