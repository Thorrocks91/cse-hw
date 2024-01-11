using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >=80)
        {
            letter = "B";
        }
        else if (percentage >=70)
        {
            letter = "C";
        }
        else if (percentage >=60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //Determines + and - on letter grade
        if (percentage % 10 >= 7 && percentage >= 60 && percentage < 100)
        {
            letter += "+";
        }
        else if (percentage % 10 < 3 && percentage >= 60)
        {
            letter += "-";
        }

        //prints grade letter and pass or fail statement. 
        Console.WriteLine($"Your grade is: {letter}");
        
        if (percentage >= 70)
        {
            Console.WriteLine($"Congratulations you have a {letter} you passed the class!");
        }
        else
        {
            Console.WriteLine($"You have a {letter}. Unfortunately, you did not pass but don't give up!");
        } 

    }
}