/*
Name: Medha Bhattacharyya
Title: IT-1050 - Lab 3
*/

using System.ComponentModel.DataAnnotations;

namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        //Problem 1: Simple For Loop
        Console.WriteLine("\r\n***Problem 1 ***");

        //This is a for loop that checks the condition and prints the numbers until the condition is false
        for (int i = 1; i <= 10; ++i)
        {
            Console.WriteLine(i);
        }

        //Problem 2: Even Numbers from 1 to 20 (Using Modulus Operator)
        Console.WriteLine("\r\n***Problem 2 ***");
        Console.WriteLine("The even numbers are between 1 to 20: ");

        //This is a for loop that checks the condition along with the if condition to print even numbers
        for (int i = 0; i <= 20; ++i)
        {
            if (i % 2 == 0)
                Console.WriteLine(i);
        }

        //Problem 3: While Loop Countdown        
        //This first shows which number the loop should start with and checks the while loop condition to print the number countdown
        Console.WriteLine("\r\n***Problem 3 ***");
        int counter = 5;

        Console.WriteLine("The countdown numbers starting from 5: ");
        while (counter > 0)
        {
            Console.WriteLine(counter);
            counter--;
        }

        //Problem 4: While Loop – Multiples of 10 from 10 to 1000
        //This shows which number should show in the beginning and adds 10 each time until the while condition becomes false

        Console.WriteLine("\r\n***Problem 4 ***");
        int number = 10;

        Console.WriteLine("The Multiples of 10 are: ");
        while (number <= 1000)
        {
            Console.WriteLine(number);
            number += 10;
        }

        //Problem 5: Seasons of the Year  
        Console.WriteLine("\r\n***Problem 5 ***");

        //This is an array that uses a foreach loop to print each season
        string[] seasons = {"Spring", "Summer", "Fall", "Winter" };        
        
        Console.WriteLine("The seasons are: ");
        foreach (string season in seasons)
        {
            Console.WriteLine(season);
        }

        //Problem 6: Days of the Week (1–7)
        //This is a program that prompts the user to enter a number between 1-7 and prints it; it also handles incorrect input
        Console.WriteLine("\r\n***Problem 6 ***");

        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        Console.Write("Enter a number between 1-7 for Days of the week: ");
        string input = Console.ReadLine();
        
        //Checking if valid input enetered
        if (uint.TryParse(input, out uint Number))
        {
            if (Number >= 1 && Number <= 7)
            {
                Console.WriteLine("Day " + Number + " is " + days[Number - 1]);
            }
            else
            {
                Console.WriteLine("Entered number outside of 1 to 7");
            }
        }
        else
        {
            Console.WriteLine("Incorrect input entered!");
        }

        //Problem 7: Favorite Books and Authors
        //Using two string arrays and a for loop to print the books along with the author
        Console.WriteLine("\r\n***Problem 7 ***");
        string[] books = { "Harry potter and The sorceror's Stone", "Keeper of the Lost Cities", "The Long Way Around" };
        string[] authors = { "J.K. Rowling", "Sharon Messenger", "Anne Nesbet" };
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine(books[i] + " by " + authors[i]);
        }

        //Problem 8: Temperature Tracker
        //This is an array of 5 temperatures which sorts the numbers in ascending order; it also prints the highest and lowest temperatures
        Console.WriteLine("\r\n***Problem 8 ***");
        int[] temperatures = { 65, 41, 56, 34, 89 };
        Array.Sort(temperatures);
        foreach (int temp in temperatures)
        {
            Console.WriteLine(temp);
        }
        Console.WriteLine("The Highest Temperature is: " + temperatures[0]);
        Console.WriteLine("The Highest Temperature is: " + temperatures[4]);

        //problem 9: Reverse Countdown
        //This is an array and using Array.Reverse() to reverse the countdown and prints the numbers using a for loop
        Console.WriteLine("\r\n***Problem 9 ***");
        int[] num = { 5, 4, 3, 2, 1 };
        Array.Reverse(num);
        Console.WriteLine("The Reverse array is:");  
        for (int i = 0; i < num.Length; i++)
        {
            Console.WriteLine(num[i]);
        }        
    }
}
