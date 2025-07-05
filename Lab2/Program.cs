
namespace Lab2;

class Program
{
    static void Main(string[] args)
    {

        //Part 1:
        int a = 10, b = 5, c = 15;

        bool comparison1 = (a > b);
        bool comparison2 = (a < c);
        bool comparison3 = a > b && a > c;
        bool comparison4 = a > b || a > c;

        Console.WriteLine(comparison1);
        Console.WriteLine(comparison2);
        Console.WriteLine(comparison3);
        Console.WriteLine(comparison4);


        //Part 2:
        bool isRaining = true;
        bool haveUmbrella = false;

        if (isRaining && !haveUmbrella)
        {
            Console.WriteLine("Take an umbrella!");
        }
        else if (isRaining == haveUmbrella)
        {
            Console.WriteLine("You are good to go!");
         }
    }
}
