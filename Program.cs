using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Games
{
    class Program
    {
        static void Main(string[] args)
        {
            string Level = "";
            string Level1 = "Easy";
            string Level2 = "Intermidiate";
            string Level3 = "Hard";
            int Guess = 0;

            Console.WriteLine("Hi Player, welcome to the Number Guessing Game!");
            Console.WriteLine("Game Levels : Easy, Intermidiate, Hard.");
            Console.Write("What level would you like to play?: ");
            Level = Console.ReadLine();
        
            if (Level == Level1)
            {
                int correctGuess = 3;
                int GuessLimit = 6;
                int GuessCount = 0;
                bool outofguesses = false;
                
                Console.WriteLine("For this level, you have 6 trials. Goodluck!");
                Console.WriteLine("Guess a number from 1 - 10");

                while(Guess != correctGuess && !outofguesses)
                {
                    if (GuessCount < GuessLimit)
                    {
                        Console.Write("Guess the number: ");
                        Guess = int.Parse(Console.ReadLine());
                        GuessCount++;
                    } 
                    else
                    {
                        outofguesses = true; 
                    }
                    if (outofguesses)
                    {
                        Console.WriteLine("Opps, you lose!");
                    }
                    else if (Guess != correctGuess)
                    {
                        Console.WriteLine("Try again");
                    }

                    else
                    {
                        Console.WriteLine("Congratulations, you win!");   
                    }
                }
            }

            if (Level == Level2)
            {
                int correctGuess = 14;
                int GuessLimit = 4;
                int GuessCount = 0; 
                bool outofguesses = false;
               
                Console.WriteLine("For this level, you have 4 trials. Goodluck!");
                Console.WriteLine("Guess a number from 1 - 20");
                while(Guess != correctGuess && !outofguesses)
                {
                    if (GuessCount < GuessLimit)
                    {
                        Console.Write("Guess the number: ");
                        Guess = int.Parse(Console.ReadLine()); 
                        GuessCount++;
                    } 
                    else
                    {
                        outofguesses = true; 
                    }
                    if (outofguesses)
                    {
                        Console.WriteLine("Opps, you lose!");
                    }
                    else if (Guess != correctGuess)
                    {
                        Console.WriteLine("Try again");
                    }
                    else
                    {
                        Console.WriteLine("Congratulations, you win!");   
                    }
                }
            }

            if (Level == Level3)
            {
                int correctGuess = 39;
                int GuessLimit = 6;
                int GuessCount = 0;
                bool outofguesses = false;
                
                Console.WriteLine("For this level, you have 6 trials.Goodluck!");
                Console.WriteLine("Guess a number from 1 - 50"); 
                while(Guess != correctGuess && !outofguesses)
                {
                    if (GuessCount < GuessLimit)
                    {
                        Console.Write("Guess the number: ");
                        Guess = int.Parse(Console.ReadLine());
                        GuessCount++;
                    } 
                    else
                    {
                        outofguesses = true; 
                    }
                    if (outofguesses)
                    {
                        Console.WriteLine("Opps, you lose!");
                    }
                    else if (Guess != correctGuess)
                    {
                        Console.WriteLine("Try again");
                    }
                    else
                    {
                        Console.WriteLine("Congratulations, you win!");   
                    }
                }
            }
        }
    }   
}