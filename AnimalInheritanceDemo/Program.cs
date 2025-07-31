using System;

namespace AnimalInheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DCIT 318: Programming II Assignment 2");
            Console.WriteLine("Object-Oriented Programming Demonstrations\n");

            // Task 1: Inheritance and Method Overriding
            Console.WriteLine("=== Task 1: Inheritance and Method Overriding ===");
            Animal animal = new();
            Dog dog = new();
            Cat cat = new();

            Console.WriteLine("Animal sound:");
            animal.MakeSound();

            Console.WriteLine("Dog sound:");
            dog.MakeSound();

            Console.WriteLine("Cat sound:");
            cat.MakeSound();
            Console.WriteLine();

            // Task 2: Abstract Classes and Methods
            Console.WriteLine("=== Task 2: Abstract Classes and Methods ===");
            Circle circle = new(5.0);
            Rectangle rectangle = new(4.0, 6.0);

            Console.WriteLine($"Circle area (radius = 5): {circle.GetArea():F2}");
            Console.WriteLine($"Rectangle area (length = 4, width = 6): {rectangle.GetArea():F2}");
            Console.WriteLine();

            // Task 3: Interfaces
            Console.WriteLine("=== Task 3: Interfaces ===");
            Car car = new();
            Bicycle bicycle = new();

            Console.WriteLine("Car movement:");
            car.Move();

            Console.WriteLine("Bicycle movement:");
            bicycle.Move();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
