namespace Lab4;

class Car
{
    public string model;
    public string color;
    public int year;

    // Example method to display car details.
    public void Display()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Year: " + year);
    }

    //Problem 1: Add a Method with No Parameters
    public void Start()
    {
        Console.WriteLine("The Car is starting");
    }

    //Problem 2: Add a Method with Parameters
    public void Drive(int miles)
    {
        Console.WriteLine($"The car drove {miles} miles");
    }

   //Problem 3: Add a Method with a Return Value
    public string GetDescription()
    {
        string CardDescription = model + " " + year + " " + color;
        return CardDescription;
    }

    // Problem 4: Add a Method that Updates a Field
    public void Repaint(string newColor)
    {
        color = newColor;
        Console.WriteLine($"\r\nMy car has been repainted to {color}");
    }
}

class Program
{
    static void Main()
    {
        // Creating a Car object and assigning values to its properties
        Car myCar = new Car();
        myCar.model = "Civic";
        myCar.color = "Black";
        myCar.year = 2020;

        myCar.Display(); // Calling the Display method

        //Step 1 call method
        myCar.Start();

        //Step 2 call method
        myCar.Drive(50);

        //Step 3 call method
        string CarDescr = myCar.GetDescription();
        Console.Write(CarDescr);

        //Step 4 Call method 
        myCar.Repaint("red");
        Console.WriteLine("New updated Car data after repaint: ");
        myCar.Display();

    }
}

