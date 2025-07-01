namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        //step 1: Comments
        //Name: Medha Bhattacharyya
        //Title: IT-1050 - Lab 1

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
        
    } 
}
