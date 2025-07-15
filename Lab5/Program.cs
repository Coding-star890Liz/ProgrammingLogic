namespace Lab5;

//Step 1 – Create a Base Class
public class Animal()
{
    public virtual void animalSound()
    {
        Console.WriteLine("\r\n***Problem 1***");
        Console.WriteLine("The animal makes a sound");
    }
}
//Step 2 – Create Derived Classes
public class Cat : Animal
{ 
    public override void animalSound()
    {
        Console.WriteLine("\r\n***Problem 2: Part 1***");
        Console.WriteLine("The cat says: meow");
    }
}
public class Dog : Animal
{
    public override void animalSound()
    {   Console.WriteLine("\r\n***Problem 2: Part 2***");
        Console.WriteLine("The dog says: bow wow");
    }
}
 
class Program
{  
    static void Main()
    {
        //Step 1 call method
        Animal sound = new Animal();
        sound.animalSound();

        //Step 2 call method
        Animal myPetCat = new Cat();
        myPetCat.animalSound();
        Animal myPetDog = new Dog();
        myPetDog.animalSound();

        //Step 3 call method
        Console.WriteLine("\r\n***Problem 3***");
        Animal myAnimal = new Animal();
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        myAnimal.animalSound();
        myDog.animalSound();
        myCat.animalSound();

    }
}