using System;

namespace AnimalInheritanceDemo
{
    // Task 1: Inheritance and Method Overriding
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    // Task 2: Abstract Classes and Methods
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double GetArea()
        {
            return length * width;
        }
    }

    // Task 3: Interfaces
    public interface IMovable
    {
        void Move();
    }

    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DCIT 318: Programming II Assignment 2");
            Console.WriteLine("Object-Oriented Programming Demonstrations\n");

            // Task 1: Inheritance and Method Overriding
            Console.WriteLine("=== Task 1: Inheritance and Method Overriding ===");
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            Console.WriteLine("Animal sound:");
            animal.MakeSound();

            Console.WriteLine("Dog sound:");
            dog.MakeSound();

            Console.WriteLine("Cat sound:");
            cat.MakeSound();
            Console.WriteLine();

            // Task 2: Abstract Classes and Methods
            Console.WriteLine("=== Task 2: Abstract Classes and Methods ===");
            Circle circle = new Circle(5.0);
            Rectangle rectangle = new Rectangle(4.0, 6.0);

            Console.WriteLine($"Circle area (radius = 5): {circle.GetArea():F2}");
            Console.WriteLine($"Rectangle area (length = 4, width = 6): {rectangle.GetArea():F2}");
            Console.WriteLine();

            // Task 3: Interfaces
            Console.WriteLine("=== Task 3: Interfaces ===");
            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            Console.WriteLine("Car movement:");
            car.Move();

            Console.WriteLine("Bicycle movement:");
            bicycle.Move();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
