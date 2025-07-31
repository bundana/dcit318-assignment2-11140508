# DCIT 318: Programming II Assignment 2

## Overview
This C# console application demonstrates three fundamental aspects of Object-Oriented Programming (OOP):

1. **Inheritance and Method Overriding**
2. **Abstract Classes and Methods**
3. **Interfaces**

## Project Structure
```
AnimalInheritanceDemo/
├── Program.cs          # Main application file containing all demonstrations
├── AnimalInheritanceDemo.csproj  # Project file
└── README.md           # This documentation file
```

## Features

### 1. Inheritance and Method Overriding
- **Base Class**: `Animal` with a virtual `MakeSound()` method
- **Derived Classes**: 
  - `Dog` - overrides `MakeSound()` to print "Bark"
  - `Cat` - overrides `MakeSound()` to print "Meow"

### 2. Abstract Classes and Methods
- **Abstract Class**: `Shape` with abstract `GetArea()` method
- **Concrete Classes**:
  - `Circle` - calculates area using π × radius²
  - `Rectangle` - calculates area using length × width

### 3. Interfaces
- **Interface**: `IMovable` with `Move()` method
- **Implementing Classes**:
  - `Car` - prints "Car is moving"
  - `Bicycle` - prints "Bicycle is moving"

## How to Run

1. **Prerequisites**: Make sure you have .NET SDK installed on your machine 

2. **Run the application**:
   ```bash
   dotnet run
   ```

## Expected Output
The application will display:
- Animal sounds (generic, bark, meow)
- Calculated areas for circle and rectangle
- Movement messages for car and bicycle

## Technologies Used
- C# (.NET)
- Object-Oriented Programming concepts

## Author
Student ID: 11140508 