using System;

abstract class Animal
{
    
    public abstract string Name { get; set; }
    
    protected int Age { get; set; }
    protected string Species { get; set; }

    // Methods
    public abstract string Describe();
    public string WhatAmI()
    {
        return "I am an animal";
    }
}

class Dog : Animal
{
    // Property
    public override string Name { get; set; }

    // Constructor
    public Dog() : this("", 0)
    {
    }

    public Dog(string name, int age)
    {
        Name = name;
        Age = age;
        Species = "Dog";
    }

    // Override method
    public override string Describe()
    {
        return $"Name: {Name}, Age: {Age}, Species: {Species}";
    }
}

class Cat : Animal
{
    // Property
    public override string Name { get; set; }

    // Constructor
    public Cat() : this("", 0)
    {
    }

    public Cat(string name, int age)
    {
        Name = name;
        Age = age;
        Species = "Cat";
    }

    
    public override string Describe()
    {
        return $"Name: {Name}, Age: {Age}, Species: {Species}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Prompt user to input information for a dog
        Console.WriteLine("Enter Dog's Name:");
        string dogName = Console.ReadLine();

        Console.WriteLine("Enter Dog's Age:");
        int dogAge = Convert.ToInt32(Console.ReadLine());

        // Create a dog object with user-provided information
        Animal dog = new Dog(dogName, dogAge);

        // Prompt user to input information for a cat
        Console.WriteLine("\nEnter Cat's Name:");
        string catName = Console.ReadLine();

        Console.WriteLine("Enter Cat's Age:");
        int catAge = Convert.ToInt32(Console.ReadLine());

        // Create a cat object with user-provided information
        Animal cat = new Cat(catName, catAge);

        // Display information
        Console.WriteLine("\nDog:");
        Console.WriteLine(dog.Describe());
        Console.WriteLine(dog.WhatAmI());
        Console.WriteLine();

        Console.WriteLine("Cat:");
        Console.WriteLine(cat.Describe());
        Console.WriteLine(cat.WhatAmI());
    }
}
