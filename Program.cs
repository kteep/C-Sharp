using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();   //declaring and assigning the winning number to the random number
            int randomNumbere = random.Next(1, 11); //giving the random number (min, max) for the easy level 
            int randomNumberm = random.Next(1, 21); //giving the random number (min, max) for the medium level 
            int randomNumberh = random.Next(1, 51); //giving the random number (min, max) for the hard level 
            int guess;
            int numberofGuessese = 6; //declaring the number of guessess for easy level
            int numberofGuessesm = 4; //declaring the number of guessess for medium level
            int numberofGuessesh = 3; //declaring the number of guessess for hard level
            bool gameOver = false;
            string userChoice;


            Console.WriteLine ("Welcome To BLitz Guessing Game!");
            Console.WriteLine("There are three levels (easy, medium & hard) you must choose from");
            Console.Write("Please enter your preferred game level: ");
            Console.WriteLine();
            userChoice = Console.ReadLine();
            Console.Clear();

            while (gameOver == false && userChoice == "easy") //Starting a while loop so the program will keep going until the user guesses the correct number.
            
            {
                Console.Write("Please guess a number from 1 - 10: ");
                guess = int.Parse(Console.ReadLine());
                numberofGuessese--;
                
                if (userChoice == "easy")


                if (guess != randomNumbere && numberofGuessese == 0)
                {
                    Console.WriteLine ("Wow, six guesses and you can't figure it out?! YOU LOSE!");
                    Console.WriteLine ("GAME OVER!");
                    gameOver = true;
                }
                else if (guess == randomNumbere)
                {
                    Console.WriteLine ("That's it?! YOU WON!");
                    Console.WriteLine ("GAME OVER!");
                    gameOver = true;
                }
                else if (guess != randomNumbere && numberofGuessese == 5)
                {
                    Console.WriteLine ("Nope! You guessed wrong! You have five more guesses left");
                }
                else if (guess != randomNumbere && numberofGuessese == 4)
                {
                    Console.WriteLine ("Nope! You guessed wrong! You have four more guesses left");
                }
                else if (guess != randomNumbere && numberofGuessese == 3)
                {
                    Console.WriteLine ("Nope! You guessed wrong! You have three more guesses left");
                }
                else if (guess != randomNumbere && numberofGuessese == 2)
                {
                    Console.WriteLine ("Nope! You guessed wrong! You have two more guesses left");
                }
                else if (guess != randomNumbere && numberofGuessese == 1)
                {
                    Console.WriteLine ("Nope! You guessed wrong! You have one more guesses left");
                }
               
    
            }


            while (gameOver == false && userChoice == "medium")
            
            {
                Console.Write("Please guess a number from 1 - 20: ");
                guess = int.Parse(Console.ReadLine());
                numberofGuessesm--;
                
                if (userChoice == "medium")


                if (guess != randomNumberm && numberofGuessesm == 0)
                {
                    Console.WriteLine ("Wow, four guesses and you can't figure it out?! YOU LOSE!");
                    Console.WriteLine ("GAME OVER!");
                    gameOver = true;
                }
                else if (guess == randomNumberm)
                {
                    Console.WriteLine ("That's it?! YOU WON!");
                    Console.WriteLine ("GAME OVER!");
                    gameOver = true;
                }
                else if (guess != randomNumberm && numberofGuessesm == 3)
                {
                    Console.WriteLine ("Nope! You guessed wrong! You have three more guesses left");
                }
                else if (guess != randomNumberm && numberofGuessesm == 2)
                {
                    Console.WriteLine ("Nope! You guessed wrong! You have two more guesses left");
                }
                else if (guess != randomNumberm && numberofGuessesm == 1)
                {
                    Console.WriteLine ("Nope! You guessed wrong! You have one more guesses left");
                }
               
    
            }

            while (gameOver == false && userChoice == "hard")
            
            {
                Console.Write("Please guess a number from 1 - 50: ");
                guess = int.Parse(Console.ReadLine());
                numberofGuessesh--;
                
                if (userChoice == "hard")


                if (guess != randomNumberh && numberofGuessesh == 0)
                {
                    Console.WriteLine ("Wow, three guesses and you can't figure it out?! YOU LOSE!");
                    Console.WriteLine ("GAME OVER!");
                    gameOver = true;
                }
                else if (guess == randomNumberh)
                {
                    Console.WriteLine ("That's it?! YOU WON!");
                    Console.WriteLine ("GAME OVER!");
                    gameOver = true;
                }
                else if (guess != randomNumberh && numberofGuessesh == 2)
                {
                    Console.WriteLine ("Nope! You guessed wrong! You have two more guesses left");
                }
                else if (guess != randomNumberh && numberofGuessesh == 1)
                {
                    Console.WriteLine ("Nope! You guessed wrong! You have one more guesses left");
                }
               
    
            }

            Console.WriteLine("Would you like to start again? yes/no: ");
            string UserChoice;
            UserChoice = Console.ReadLine();

            if (UserChoice == "no")
                Environment.Exit(0);
            else if (UserChoice == "yes")
                Main(args);
            

            Console.ReadLine();
        }
    }
}
