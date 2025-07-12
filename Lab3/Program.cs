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
        for (int i = 1; i <= 10; ++i)
        {
            Console.WriteLine(i);
        }

        //Problem 2: Even Numbers from 1 to 20 (Using Modulus Operator)
        for (int i = 0; i <= 20; ++i)
        {
            if (i % 2 == 0)
                Console.WriteLine("The even number is: " + i);
        }

        //Problem 3: While Loop Countdown
        int counter = 5;
        while (counter > 0)
        {
            Console.WriteLine("The number is: " + counter);
            counter--;
        }

        //Problem 4:  While Loop – Multiples of 10 from 10 to 1000
        int number = 10;
        while (number <= 1000)
        {
            Console.WriteLine("The Multiples of 10 are: " + number);
            number += 10;
        }

        //Problem 5: Seasons of the Year
        string[] seasons = new string[] { "Spring", "Summer", "Fall", "Winter" };
        foreach (string season in seasons)
        {
            Console.WriteLine("The season is: " + seasons[0]);
            Console.WriteLine("The season is: " + seasons[1]);
            Console.WriteLine("The season is: " + seasons[2]);
            Console.WriteLine("The season is: " + seasons[3]);
            break;
        }

        //Problem 6:Days of the Week (1–7)
        string[] days = new string[] { "Saturday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Sunday" };
        Console.Write("Enter a number between 1-7 : ");
        int input = int.Parse(Console.ReadLine());
        for (int i = 0; i < days.Length; ++i)
        {
            if (input >= 1 && input <= 7)
            {
                Console.WriteLine("Day " + input + " is " + days[i]);
                break;
            }
            else
            {
                Console.WriteLine("Incorrect input");
                break;
            }
        }

        //Problem 7: Favorite Books and Authors
        string[] books = { "Harry potter and The sorceror's Stone", "Keeper of the Lost Cities", "The Long Way Around" };
        string[] authors = { "J.K. Rowling", "Sharon Messenger", "Anne Nesbet" };
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine(books[i] + " by " + authors[i]);
        }

        //Problem 8: Temperature Tracker
        int[] temperatures = new int[] { 65, 41, 56, 34, 89 };
        Array.Sort(temperatures);
        foreach (int temp in temperatures)
        {
            Console.WriteLine(temp);
        }
        Console.WriteLine("The Highest Temperature is:" + temperatures[0]);
        Console.WriteLine("The Highest Temperature is:" + temperatures[4]);

        //problem 9: Reverse Countdown
        int[] num = new int[] { 5, 4, 3, 2, 1 };
        Array.Reverse(num);
        Console.WriteLine("The Reverse array is:");
        for (int i = 0; i < num.Length; i++)
        {
            Console.WriteLine(num[i]);

        }
        
    }
}
