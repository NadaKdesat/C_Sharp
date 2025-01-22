using System;

namespace Topics_22_1_2025
{
    class Vehicle  // base class (parent)
    {
        public string brand = "Ford";  // Vehicle field
        protected string year = "2000";  // Protected field
        private string color = "red";

        public void Honk()  // Vehicle method
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Car : Vehicle  // derived class (child)
    {
        public string modelName = "Mustang";  // Car field
        public string carYear;  // New field in Car to store year

        // Constructor for Car
        public Car()
        {
            // Copy the value of 'year' from the base class to 'carYear'
            carYear = year;
        }
        public void ShowYear() // Method to demonstrate access to protected member
        {
            Console.WriteLine($"This car was made in {year}.");  // Accessing protected field
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a myCar object
            Car myCar = new Car();

            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.Honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName + " " + myCar.carYear);

            // Call the ShowYear() method to demonstrate access to the protected field
            myCar.ShowYear();
        }
    }
}