using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();

        
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished.");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if( userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        }
        //sums up the list total. 
        int sum = 0;
        int max = numbers[0];

        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");


        //computes average of list. 
        float average = ((float)sum)/numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //finds max number
        int maxNumber = numbers.Max();
        Console.WriteLine($"The largest number is: {maxNumber}");
        
    }
}