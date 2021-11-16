using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Guessing Game, please select a difficulty of Easy, Medium, Hard, or Cheater");

            int secretNum = new Random().Next(0, 100);

            int index = 0;

            bool isAnswerFound = false;

            bool isDifficultyCorrect = false;

            bool isCheatMode = false;



            while (!isDifficultyCorrect)
            {

                string difficulty = Console.ReadLine();

                if (difficulty == "Easy")
                {
                    index = 8;
                    isDifficultyCorrect = true;
                }
                else if (difficulty == "Medium")
                {
                    index = 6;
                    isDifficultyCorrect = true;
                }
                else if (difficulty == "Hard")
                {
                    index = 4;
                    isDifficultyCorrect = true;
                }
                else if (difficulty == "Cheater")
                {
                    isDifficultyCorrect = true;
                    isCheatMode = true;
                }
                else
                {
                    Console.WriteLine("That is not a difficulty. Please try again.");
                }
            }

            if (!isCheatMode)
            {
                Console.WriteLine("Please guess the secret number");

                while (index > 0 && !isAnswerFound)
                {

                    Console.Write($"You have {index} guesses left:");
                    int guess = int.Parse(Console.ReadLine());
                    index = index - 1;

                    if (guess == secretNum)
                    {
                        Console.WriteLine("Congratulations!");
                        isAnswerFound = true;
                    }
                    else if (guess > secretNum)
                    {
                        Console.WriteLine("Your guess is too high");

                    }
                    else if (guess < secretNum)
                    {
                        Console.WriteLine("Your guess is too low");
                    }

                }
            }
            else
            {

                Console.WriteLine("Please guess the secret number");

                while (!isAnswerFound)
                {

                    int guess = int.Parse(Console.ReadLine());

                    if (guess == secretNum)
                    {
                        Console.WriteLine("Congratulations!");
                        isAnswerFound = true;
                    }
                    else if (guess > secretNum)
                    {
                        Console.WriteLine("Your guess is too high");

                    }
                    else if (guess < secretNum)
                    {
                        Console.WriteLine("Your guess is too low");
                    }
                }
            }
        }
    }
}
