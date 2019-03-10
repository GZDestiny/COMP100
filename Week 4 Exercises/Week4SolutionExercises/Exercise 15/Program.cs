﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 15.	You can create a random number that is at least min but less than max using the following statements:
 * Random ranNumberGenerator = new Random();
 * int randomNumber;
 * randomNumber = ranNumberGenerator.Next(min, max);
 * Write a console-based program that generates a random number between 1 and 10. (In other words, min is 1 and max is 11.) Ask a user to guess the random number, 
 * then display the random number and a message indicating whether the user’s guess was too high, too low, or correct.
 */
namespace Exercise_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int nGuess;
            //Output
            int rng;
            Random randomGenerator = new Random();
            rng = randomGenerator.Next(1, 11);

            //Algorithm
            Console.Write("What number are you guessing?");
            nGuess = Convert.ToInt32(Console.ReadLine());
            if (nGuess>rng)
            {
                Console.WriteLine($"The number is {rng}, you guessed {nGuess}, your guess was too high.");
            }
            else if (nGuess < rng)
            {
                Console.WriteLine($"The number is {rng}, you guessed {nGuess}, your guess was too low.");
            }
            else
            {
                Console.WriteLine($"The number is {rng}, you guessed {nGuess}. Amazing! Your guess is right on the mark");
            }


        }
    }
}
