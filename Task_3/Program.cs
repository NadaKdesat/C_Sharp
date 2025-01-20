using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {

        class Room
        {
            public string RoomNumber;
            public string RoomType;
            public double PricePerNight;
            public bool IsBooked;
            public const string HotelName = "Grand Stay Hotel";  
            
            public void InputRoomDetails()
            {
                Console.Write("Enter Room Number: ");
                RoomNumber = Console.ReadLine();

                Console.Write("Enter Room Type (Single, Double, Suite): ");
                RoomType = Console.ReadLine();

                Console.Write("Enter Price Per Night: ");
                PricePerNight = double.Parse(Console.ReadLine());

                Console.Write("Is the Room Booked? (true/false): ");
                IsBooked = bool.Parse(Console.ReadLine());
            }

            public void PrintRoomDetails()
            {
                Console.WriteLine($"Hotel Name: {HotelName}");
                Console.WriteLine($"Room Number: {RoomNumber}");
                Console.WriteLine($"Room Type: {RoomType}");
                Console.WriteLine($"Price Per Night: {PricePerNight}");
                Console.WriteLine($"Is Booked: {IsBooked}");
            }
        }
        public static string EvenOrOdd(string input)
        {
            int number = Convert.ToInt32(input);
            if (number % 2 == 0)
            {
                return $"Output: The number {number} is even.";
            }
            else
            {
                return $"Output: The number {number} is odd.";
            }
        }

        public static double SecondSmallest(double n1, double n2, double n3, double n4, double n5)
        {
            double[] number = { n1, n2, n3, n4, n5 };
            Array.Sort(number);
            return number[1];
        }

        public static int Factorial(int num)
        {
            if (num == 0) return 1;
            if (num < 0) return 0;

            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        public static void PrintPrimeNumbers(int num1, int num2)
        {

            for (int i = num1 + 1; i < num2; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime && i > 1)
                {
                    Console.Write(i + " ");
                }
            }
            Console.Write("\n\n");
        }


        public static int MaxNumber(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = array[0];
            for (int i = 1; i < size; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public static void PrintNumberPattern(int number)
        {
            int cont = 0;
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(++cont + " ");
                    Console.Write(++cont + " ");
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            //1 - Write a C# program that accepts an integer and determines if the number is even or odd. Display the result.
            //Example Input: 7
            //Output: The number 7 is odd.
            Console.Write("Input any number: ");
            string input = Console.ReadLine();
            Console.WriteLine(EvenOrOdd(input) + "\n\n");

            //2 - Write a C# program that accepts five numbers and displays the 2nd smallest of the five.
            //Example Input: 4, -3, 7, 2, 0
            //Output: 0
            Console.WriteLine("Input five numbers: ");
            Console.Write("Enter first number: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter therd number: ");
            double n3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter fourth number: ");
            double n4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter fifth number: ");
            double n5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Output: The 2nd smallest of numbers is: {SecondSmallest(n1, n2, n3, n4, n5)}\n\n");


            //3 - Write a program that calculates the factorial of a given number using a for loop.
            //Example Input: 5
            //Output: 120(5 × 4 × 3 × 2 × 1 = 120)
            Console.Write("Input any numbers: ");
            int input3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Output: the factorial of {input3} is: {Factorial(input3)}\n\n");


            //4 - Write a program that takes two integers as input and prints all the prime numbers between them using nested loops.
            //Example Input:
            //Start: 10
            //End: 30
            //Output: 11, 13, 17, 19, 23, 29
            Console.WriteLine("Input two numbers: ");
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Output: prime numbers between {num1} and {num2}: ");
            PrintPrimeNumbers(num1, num2);

            //5 - Create a program that initializes an integer array and finds the largest number in it using a foreach loop.
            //Example Array: { 3, 1, 4, 1, 5, 9}
            //Output: 9
            Console.Write("Input size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Output: the largest number in array is: {MaxNumber(size)}\n\n");

            //6 - Write a program that prints the following number pattern using nested loops:
            //For n = 5, the output should be:
            //1
            //2 3
            //4 5 6
            //7 8 9 10
            //11 12 13 14 15
            Console.Write("Input any number: ");
            int input6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Output: ");
            PrintNumberPattern(input6);


            //Create a Hotel Reservation System where the program manages room bookings for a hotel. Each room has the following properties:
            //Room Number
            //Room Type(e.g., Single, Double, Suite)
            //Price Per Night
            //IsBooked(whether the room is already booked or not)
            //HotelName = "Grand Stay Hotel";   as constant
            //You need to:
            //1.Create a class Room with appropriate properties.
            //2.Allow the user to input details for at least 2 rooms.
            //3.Then assign data to all field , then print the data .

            Room room1 = new Room();
            Room room2 = new Room();
            Console.WriteLine($"\nEnter details for Room 1:");
            room1.InputRoomDetails();
            Console.WriteLine($"\nEnter details for Room 2:");
            room2.InputRoomDetails();

            Console.WriteLine("\n\nRoom 1 Details:");
            room1.PrintRoomDetails();
            Console.WriteLine("\n\nRoom 2 Details:");
            room2.PrintRoomDetails();
        }
}
}
