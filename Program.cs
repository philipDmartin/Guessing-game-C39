using System;

namespace Guessing_Game_C39
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a variable to contain the secret number
            Random rand = new Random();

            int secretNum = rand.Next(1, 11);

            //Give the user four chances to guess the number
            int guessAmount = 0;
            int guessLeft = 5;

            //Propmt user with difficulty level
            Console.WriteLine("Choose difficulty");
            Console.WriteLine("1.Easy");
            Console.WriteLine("2.Medium");
            Console.WriteLine("3.Hard");
            Console.WriteLine("4.Cheater");

            string userDifficulty = Console.ReadLine();
            int difNum = 0;

            if (userDifficulty == "1")
            {
                difNum = 8;
                guessAmount = 0;
                guessLeft = 9;

            }
            else if (userDifficulty == "2")
            {
                difNum = 6;
                guessAmount = 0;
                guessLeft = 7;
            }
            else if (userDifficulty == "3")
            {
                difNum = 4;
                guessAmount = 0;
                guessLeft = 5;
            }
            else if (userDifficulty == "4")
            {
                difNum = 1000000;
                guessAmount = 0;
                guessLeft = 10000001;
            }

            while (guessAmount < difNum)
            {
                //Display a message to the user asking them to guess the secret number
                //Display the number of the user's current guess
                Console.WriteLine($"Guess the secret number. Your guess ({guessAmount + 1}), You have ({guessLeft - 1}) guesses left.");

                //Display a prompt for the user's guess.
                string userGuess = Console.ReadLine();

                //Take the user's guess as input and save it as a variable
                int userGuessInt = Int32.Parse(userGuess);

                //Compare the user's guess with the secret number
                if (userGuessInt == secretNum)
                {
                    Console.WriteLine("Good job thats the secreet number!");
                    //End the loop early if the user guesses the correct number
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong!!!!!");
                }
                guessAmount++;
                guessLeft--;

                if (userGuessInt < secretNum)
                {
                    Console.WriteLine("Your answers to low!");
                }
                else if (userGuessInt > secretNum)
                {
                    Console.WriteLine("Your answers to high!");
                }
                else
                {
                    Console.WriteLine("Good job thats the secreet number!");
                }
            }
        }
    }
}
