/*
Name: Medha Bhattacharyya
Title: IT-1050 - Lab 2
*/

using System.Collections;
using System.Diagnostics;

namespace Lab2;

class Program
{
    static void Main(string[] args)
    {

        //Part 1: Compare the use of different operators

        int a = 10, b = 5, c = 15;

         // This line checks whether a is greater than b and prints either true or false
        bool comparison1 = (a > b);
        Console.WriteLine(comparison1);

        // This line checks whether c is greater than a and prints either true or false
        bool comparison2 = (a < c);
        Console.WriteLine(comparison2);
        
        /* This checks if a is greater than both b and c and prints false if one or both of the conditions are
         false but if both of the conditions are true it will print true. */
        bool comparison3 = ((a > b) && (a > c));
        Console.WriteLine(comparison3);
        
       //This checks whether "a" is greater than "b" or "a" is greater than "c" and prints the output
        bool comparison4 = ((a > b) || (a > c));
        Console.WriteLine(comparison4);


        //Part 2: Boolean Logic checking

        //This sets the isRaining variable to true and sets the haveUmbrella variable to false
        bool isRaining = true;
        bool haveUmbrella = false;

        //Check if it is raining and don't have an umbrella, print to take an umbrella
        if (isRaining && !haveUmbrella)
        {
            Console.WriteLine("Take an umbrella!");
        }
        // Otherwise print good to go
        else
        {
            Console.WriteLine("You are good to go!");
        }

        //Part 3: Write a program that asks the user to enter their age. Based on their age,
        //display the ticket price category.

        //Prompts you to enter your age and shows the age in the output
        Console.WriteLine("Enter your age: ");
        String input1 = Console.ReadLine();

        if (uint.TryParse(input1, out uint age)) //Used for catching errors, I learned it first time and using it
        {
            Console.WriteLine("Your age: " + age);

            // Using the if else statement to display the ticket price based on the age you entered earlier
            if (age < 5)
            {
                Console.WriteLine("Ticket is free!");
            }
            else if (age >= 5 && age <= 12)
            {
                Console.WriteLine("Child ticket: $5");
            }
            else if (age >= 13 && age <= 64)
            {
                Console.WriteLine("Standard ticket: $10");
            }
            else if (age >= 65)
            {
                Console.WriteLine("Senior ticket: $6");
            }
            else // prints this if you entered invalid number
            {
                Console.WriteLine("Invalid age entered");
            }
        }
        else // prints this if you entered invalid data
        {
            Console.WriteLine("Invalid age entered");           
        }

        //Part 4: Write a program that asks the user to enter a day of the week (1–7). 
        //Use a switch statement to display the name of the corresponding day

        //Prompts the user to enter a number between 1-7 and converts the string into a integer
        Console.WriteLine("Enter a day of the week (1-7): "); 
        string input2 = Console.ReadLine();
        
        //It turns the string value the user entered into an integer if the conversion is successful it
        //stores it in the day variable.This line is useful for avoiding error in inavlid user input 
        if (int.TryParse(input2, out int day)) //Used for catching errors, I learned it for the first time and using it 
        {
            switch (day) // switch statment
            {
                // Depending on the user input, it runs the code in that block and breaks the case
                //preventing it going through the next one.
                case 1:
                    Console.WriteLine("Sunday");
                    break;

                case 2:
                    Console.WriteLine("Monday");
                    break;

                case 3:
                    Console.WriteLine("Tuesday");
                    break;

                case 4:
                    Console.WriteLine("Wednesday");
                    break;

                case 5:
                    Console.WriteLine("Thursday");
                    break;

                case 6:
                    Console.WriteLine("Friday");
                    break;

                case 7:
                    Console.WriteLine("Saturday");
                    break;

                default:
                    Console.WriteLine("Invalid day!");
                    break;
            }
        } 
        else // This message will show when the user put something beside the expected range 
        {
            Console.WriteLine("Invalid day!");
        }
    }
}
