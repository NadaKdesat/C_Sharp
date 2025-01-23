using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    //sealed 
     class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public void Start()
        {
            Console.WriteLine($"Vehicle is starting.");
        }
    }

    class Car: Vehicle
    {
        public int NumberOfDoors { get; set;}
        public void Print()
        {
            Console.WriteLine($"The Brand is: {Brand}\nThe Model is: {Model}\nThe NumberOfDoors is: {NumberOfDoors}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Vehicle vehicle = new Vehicle();
            car.Brand = "Ford";
            car.Model = "Mustang";
            car.NumberOfDoors = 2;
            car.Print();
        }
    }

}
// Constructor: A method that initializes an object when it's created.
// OOP Concepts: Encapsulation, Inheritance, Polymorphism, and Abstraction.
// Encapsulation: Protecting data by controlling access using methods or properties.
// Sealed Class: A class that cannot be inherited.
// Inheritance: A child class using the properties and methods of a parent class.
