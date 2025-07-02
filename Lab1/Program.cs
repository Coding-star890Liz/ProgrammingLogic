using System.Diagnostics;
using System.Globalization;

namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        // step 1: Comments
        /*Name: Medha Bhattacharyya
        Title: IT-1050 - Lab 1
        */

        // Step 2: Basic Output
        Console.WriteLine("MedhaBhattacharyya");
        Console.WriteLine("IT-1050");

        //Step 3: Declare and Use Variables
        int favoriteNumber = 7;
        Console.WriteLine("My favorite number is: " + favoriteNumber);

        string language = "python";
        Console.WriteLine("My favorite programming language: " + language);

        double programs = 163;
        Console.WriteLine("The number of programs I have written is: " + programs);

        bool programmingExp = true;
        Console.WriteLine("Do you have programming experience? " + (programmingExp ? "Yes" : "No"));

        //Step 4:  Use Constants    
        const string schoolName = "Solon High School";
        Console.WriteLine($"My school name: {schoolName}");

        //Step 5: Type Casting
        double myDouble = 9.78;
        int myInt = (int)myDouble; // Explicit casting from double to int
        Console.WriteLine($"Double type value {myDouble} Type Casting to integer {myInt}");

        //Convert an int to a string
        int myInt2 = 65;
        Console.WriteLine($"Integer type value {myInt2} converted to string {Convert.ToString(myInt2)}");

        //Convert a bool to a string
        bool myBool = true;
        Console.WriteLine($"Integer type value {myBool} converted to string {Convert.ToString(myBool)}");

        //Print each value with a label
        Console.WriteLine("myDouble: " + myDouble);
        Console.WriteLine("myInt2: " + myInt2);
        Console.WriteLine("myBool: " + myBool);

        //Step 6: User Input and Type Conversion

        //Prompts user to enter their name and store it in a string
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        //Prompts user to eneter their age and converts Console.ReadLine into Convery.ToInt2
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        //Display the greeting that includes their name and age
        Console.WriteLine($"Hello {name}, you are {age} years old!");

        //Step 7: Arithmetic Operators

        //Assign int values
        int num1 = 5;
        int num2 = 7;

        //Addition- add 10 for num1
        Console.WriteLine("Addition for num1 is " + (num1 + 10));

        //Subtraction - subtract 2 for num1
        Console.WriteLine("Subtraction for num1 is " + (num1 - 2));

        //Multiplication - times 3 for num1
        Console.WriteLine("Multiplication for num1 is " + (num1 * 3));

        //Division - divide by 2 for num1
        Console.WriteLine("Division for num2 is " + (num1 / 2));

        //Modulus - modulus 2 for num1
        Console.WriteLine("Modulus for num1 is" + (num1 % 2));

        //Addition- add 10 for num2
        Console.WriteLine("Addition for num2 is " + (num2 + 10));

        //Subtraction - subtract 2 for num2
        Console.WriteLine("Subtraction for num2 is " + (num2 - 2));

        //Multiplication - times 3 for num2
        Console.WriteLine("Multiplication for num2 is " + (num2 * 3));

        //Division - divide by 2 for num2
        Console.WriteLine("Division for num2 is " + (num2 / 2));

        //Modulus - modulus 2 for num2
        Console.WriteLine("Modulus for num2 is " + (num2 % 2));

        //Step 8: Floating Point Precision

        //Create and assign both float and double variable
        double DoubleNum = 1.123456789D;
        float DoubleNum2 = 1.123456789F;

        //Print both variables to the console
        Console.WriteLine(DoubleNum);
        Console.WriteLine(DoubleNum2);
        Console.WriteLine("Double has a higher accuracy for the same number than float, so it recalls more decimal digits");
        //Step 9: Increment and Decrement
        int x = 10;

        //Increment operator to increase value by 1
        x++;
        Console.WriteLine($"After Incremnt: {x} ");

        //Decrement operator to decrease value by 1
        x--;
         Console.WriteLine($"After decrement: {x} ");
    } 
}
