using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        //User inputs magicNumber. 
       //Console.Write("What is the magic number? ");
       //int magicNumber = int.Parse(Console.ReadLine());
       
       //Random number generator
       Random randomGenerator = new Random ();
       int magicNumber = randomGenerator.Next(1,101);


        //allows user to choose 0-100
        int guess = -1;
        while (guess != magicNumber)
        {
            //Parts 1 & 2
            //Console.Write("What is your guess? ");
            //Use for Part 3 only
            Console.Write("Guess the magic number? ");
            guess = int.Parse(Console.ReadLine());
        
            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it right!");
            }
        }

    }
}