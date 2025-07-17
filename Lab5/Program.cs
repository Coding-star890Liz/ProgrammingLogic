namespace Lab5;

//Step 1 – Create a Base Class
public class Animal()
{
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

//Step 2 – Create Derived Classes
public class Cat : Animal
{ 
    public override void animalSound()
    {
        Console.WriteLine("The cat says: meow");
    }
}
public class Dog : Animal
{
    public override void animalSound()
    {   
        Console.WriteLine("The dog says: bow wow");
    }
}
 
class Program
{    static void Main()
    {
        Console.WriteLine("\n***Created Animal, Cat and Dog object with reference type as individual class and called animalSound method***");
        //Animal object creation and output with animal sound
        Animal petAnimal = new Animal();
        petAnimal.animalSound();

        //Cat object creation and output with Cat sound     
        Cat petCat = new Cat();
        petCat.animalSound();

        //Dog object creation and output with Dog sound      
        Dog petDog = new Dog();
        petDog.animalSound();


        //Step 3: Polymorphism: Create one object each of Animal, Cat, and Dog, but use Animal as the reference type
        //Animal object creation        
        Animal myAnimal = new Animal();

        //Cat object creation        
        Animal myPetCat = new Cat();

        //Dog object creation        
        Animal myPetDog = new Dog();

        Console.WriteLine("\n***Polymorphism: Created Animal, Cat and Dog object with reference type as Animal and called animalSound method***");
        //Call the animalSound() method on each object
        myAnimal.animalSound();
        myPetCat.animalSound();
        myPetDog.animalSound();
    }
}