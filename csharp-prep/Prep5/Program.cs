using System;
class Program
{
    static void Main(string[] args)
    {
        //function #1
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNum = NumberSquared(userNumber);
        DisplayResult(userName, squaredNum);
    }

    //Welcome Messsage Line 1
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    //Line 2 Users Name
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
         
        return name;
    }

    //Line 3 Users fave number. 
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }


    //calculates the square of fave number. 
    static int NumberSquared(int number)
    {
        int square = number * number;
        return square;  

    }

    //Line 4 displays name and square results. 
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }

}