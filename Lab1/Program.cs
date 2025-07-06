// step 1: Comments
// Comments are used to explain and document the code 
/*
Name: Medha Bhattacharyya
Title: IT-1050 - Lab 1
*/

using System.Diagnostics;
using System.Globalization;

namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        // Step 2: Basic Output
        //Console.WriteLine prints the text inside the parenthesis
        Console.WriteLine("Medha Bhattacharyya");
        Console.WriteLine("IT-1050");

        //Step 3: Declare and Use Variables: Declaring different data types and printing the values with labels       
        int favoriteNumber = 7;
        Console.WriteLine("My favorite number is: " + favoriteNumber);

        string language = "python";
        Console.WriteLine("My favorite programming language: " + language);

        double programs = 163;
        Console.WriteLine("The number of programs I have written is: " + programs);

        bool programmingExp = true;
        Console.WriteLine("Do you have programming experience? " + (programmingExp ? "Yes" : "No"));

        //Step 4:  Use Constants: Declaring a constant string schoolName and printing it       
        const string schoolName = "Solon High School";
        Console.WriteLine($"My school name: {schoolName}");

        //Step 5: Type Casting: Here we are checking different type casting for different data types
        double myDouble = 9.78;
        int doubleToInt = (int)myDouble; // Explicit casting from double to int
        Console.WriteLine($"Double type value {myDouble} Type Casting to integer {doubleToInt}");

        //Convert an int to a string using Convert class
        int myInt2 = 65;
        String intToString = Convert.ToString(myInt2);
        Console.WriteLine($"Integer type value {myInt2} converted to string {intToString}");

        //Convert a bool to a string using Convert class
        bool myBool = true;
        String boolToString = Convert.ToString(myBool);
        Console.WriteLine($"Integer type value {myBool} converted to string {boolToString}");

        //Print each value with a label again
        Console.WriteLine("doubleToInt: " + doubleToInt);
        Console.WriteLine("intToString: " + intToString);
        Console.WriteLine("boolToString: " + boolToString);

        //Step 6: User Input and Type Conversion
        // This step prompts the user to eneter their name. It then prompts the user to enter their age 
        // converting the string to an integer. Lastly, it displays a greeting that includes their name and age.

        //Prompts user to enter their name and store it in a string
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();


        //Prompts user to eneter their age and converts thet text string from the user to an integer
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        //Display the greeting that includes their name and age
        Console.WriteLine($"Hello {name}, you are {age} years old!");

        //Step 7: Arithmetic Operators: This shows various arithmetic operations and printing the output

        //Create two int variables called num1 and num2 and assign them values
        int num1 = 5;
        int num2 = 7;

        //Addition- add 10 for num1
        Console.WriteLine("Add 10 to num1 is " + (num1 + 10));

        //Subtraction - subtract 2 for num1
        Console.WriteLine("Subtract 2 from num1 is " + (num1 - 2));

        //Multiplication - times 3 for num1
        Console.WriteLine("Multiply 3 to num1 is " + (num1 * 3));

        //Division - divide by 2 for num1
        Console.WriteLine("Divide 2 from num1 is " + (num1 / 2));

        //Modulus - modulus 2 for num1
        Console.WriteLine("Modulus for num1 is" + (num1 % 2));

        //Addition- add 10 for num2
        Console.WriteLine("Add 10 to num2 is " + (num2 + 10));

        //Subtraction - subtract 2 for num2
        Console.WriteLine("Subtract 2 from num2 is " + (num2 - 2));

        //Multiplication - times 3 for num2
        Console.WriteLine("Multiply 3 to num2 is " + (num2 * 3));

        //Division - divide by 2 for num2
        Console.WriteLine("Divide 2 from num2 is " + (num2 / 2));

        //Modulus - modulus 2 for num2
        Console.WriteLine("Modulus for num2 is " + (num2 % 2));

        //Step 8: Floating Point Precision

        //Create and assign same value to both float and double variable
        double DoubleNum = 1.123456789D;
        float FloatNum2 = 1.123456789F;

        //Print both variables to the console
        Console.WriteLine($"Double number printed for 1.123456789D is : {DoubleNum}");
        Console.WriteLine($"Float number printed for 1.123456789F is : {FloatNum2}");

        //Here getting the decimal digits length for each value
        int decimalPlacesDouble = DoubleNum.ToString().Split('.')[1].Length;
        int decimalPlacesFloat = FloatNum2.ToString().Split('.')[1].Length;
        Console.WriteLine($"Double decimal digit length is: {decimalPlacesDouble}");
        Console.WriteLine($"Float decimal digit length is: {decimalPlacesFloat}");

        Console.WriteLine("Double has a higher precision for the same big decimal number than float, so it gets more precision");
        Console.WriteLine("Here float print up to 7 decimal digits and rounds off after 7th decimal digit whereas double prints all decimal digits.");


        //Step 9: Increment and Decrement

        //Declare an int variable and assign it a value of 10
        int x = 10;

        //Increment operator to increase value by 1
        ++x;
        Console.WriteLine($"After Incremnt: {x} ");

        //Decrement operator to decrease value by 1
        --x;
         Console.WriteLine($"After decrement: {x} ");
    } 
}
