using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        //6
        static double kilometersToMiles(double kilometers)
        {
            return kilometers * 0.621371;
        }

        //7
        static double TotalMinutes(double hours, int minutes)
        {
            return hours * 60 + minutes;
        }

        //8
        static String TotalHoursAndMinutes(int minutes)
        {
            return $"Output: {minutes / 60} Hours, {minutes % 60} minutes\n\n";
        }


        static void Main(string[] args)
        {
            //1 - Write a C# program that accepts a double input and converts it into an int. Display both values.
            //Example:
            //Input: 9.8
            //Output:
            //Double: 9.8
            //Converted Int: 9
            Console.Write("Input double number : ");
            double input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Output: ");
            Console.WriteLine($"Double: {input}");
            Console.WriteLine($"Converted Int: {(int)input}\n\n");


            //2 - Write a program that uses a Convert.ToString() method to convert a number into a string and concatenate it with a sentence.
            //Example:
            //Input: 25
            //Output: "Your number is: 25"
            Console.Write("Input any number: ");
            double input2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Output: ");
            Console.WriteLine($"Your number is: {Convert.ToString(input2)}\n\n");


            //3 - Create a string with a sentence. Use ToUpper() and ToLower() to display the uppercase and lowercase versions of the string.
            //Input: "C# is fun!"
            //Output:
            //Uppercase: C# IS FUN!
            //Lowercase: c# is fun!
            Console.Write("Input a string: ");
            string input3 = Console.ReadLine();
            Console.WriteLine("Output: ");
            Console.WriteLine($"Uppercase: {input3.ToUpper()}");
            Console.WriteLine($"Lowercase: {input3.ToLower()}\n\n");

            //4 - Write a program that takes a user's full name as input and prints:
            //The first name.
            //The last name.
            //The length of the full name.
            //Example:
            //Input: "John Doe"
            //Output:
            //First Name: John
            //Last Name: Doe
            //Total Characters: 8
            Console.Write("Input your full name: ");
            string input4 = Console.ReadLine();
            string[] inputArray = input4.Split(' ');
            Console.WriteLine("Output: ");
            Console.WriteLine($"First Name: {inputArray[0]}");
            Console.WriteLine($"Last Name: {inputArray[1]}");
            Console.WriteLine($"Total Characters: {input4.Length}\n\n");


            //5 - Write a program that accepts two integers and prints the smaller of the two.
            //Input: 5, 9
            //Output: "Smaller Number: 5"
            Console.WriteLine("Input: ");
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Output: ");
            if (num1 < num2)
            {
                Console.WriteLine($"Smaller Number: {num1}\n\n");
            }
            else
            {
                Console.WriteLine($"Smaller Number: {num2}\n\n");
            }


            //6 - Write a method that converts kilometers per hour to miles per hour.Use this method in a program to convert and display the result.
            //Input: 15 km / h
            //Output: "9.320568 mph"
            Console.Write("Input the speed in kilometers per hour: ");
            double input6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Output: the speed in miles per hour: {kilometersToMiles(input6)} mph\n\n");


            //7 - Write a method that takes hours and minutes as input and returns the total number of minutes.
            //Input: 5 hours, 37 minutes
            //Output: "Total: 337 minutes"
            Console.WriteLine("Input: ");
            Console.Write("Enter the number of hours: ");
            double hours = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the number of minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The total number of minutes: {TotalMinutes(hours, minutes)} minutes\n\n");

            //8 - Write a method that accepts minutes as input and calculates the total number of hours and minutes.
            //Input: 546 minutes
            //Output: "9 Hours, 6 Minutes"
            Console.Write("Input the number of minutes: ");
            int minutes2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(TotalHoursAndMinutes(minutes2));


            //9.1 - Compare Two Numbers
            //Write a program that prints:
            //"Equal" if two numbers are the same.
            //"Greater" if the first is greater.
            //"Smaller" if the second is greater.
            //Use only comparison and ternary operators.
            //Input: 10, 20
            //Output: "Smaller"
            Console.WriteLine("Input: ");
            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Output: ");
            if (number1 < number2)
            {
                Console.WriteLine("Smaller\n\n");
            }
            else if (number1 > number2)
            {
                Console.WriteLine("Greater\n\n");
            }
            else if (number1 == number2)
            {
                Console.WriteLine("Equal\n\n");
            }

            //9.2 Sum of Digits
            //Write a program that calculates the sum of the digits of a number using arithmetic operators and loops(no conditionals).
            //Input: 123
            //Output: "Sum of digits: 6"
            Console.WriteLine("Input a number: ");
            string Input9 = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < Input9.Length; i++)
            {
                sum += Convert.ToInt32(Input9[i].ToString());
            }
            Console.WriteLine($"Output: Sum of digits: {sum}\n\n");

            //10 - Reverse a Number
            //Write a program that reverses a number using arithmetic operators and loops.
            //Input: 1234
            //Output: "Reversed Number: 4321"
            Console.WriteLine("Input a number: ");
            string Input10 = Console.ReadLine();
            string reverses = "";
            for (int i = Input10.Length - 1; i >= 0; i--)
            {
                reverses += Input10[i];
            }
            Console.WriteLine($"Output: Reversed Number: {reverses}\n\n");


            //11 - Check Divisibility
            //Write a program to check if a number is divisible by another number using logical and arithmetic operators. Return a message "Divisible" or "Not Divisible".
            //Input: 25, 5
            //Output: "Divisible"
            Console.WriteLine("Input: ");
            Console.Write("Enter the first number: ");
            int fNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int sNumber = Convert.ToInt32(Console.ReadLine());
            if (fNumber % sNumber == 0)
            {
                Console.WriteLine($"Output: Divisible\n\n");
            }
            else
            {
                Console.WriteLine($"Output: Not Divisible\n\n");
            }


            //12 - Find the Middle Value
            //Write a program to find the middle value of three numbers using arithmetic and comparison operators.
            //Input: 15, 20, 10
            //Output: "The middle value is: 15"
            Console.WriteLine("Input: ");
            Console.Write("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            int middle;

            if ((firstNumber > secondNumber && firstNumber < thirdNumber) ||
                (firstNumber < secondNumber && firstNumber > thirdNumber))
            {
                middle = firstNumber;
            }
            else if ((secondNumber > firstNumber && secondNumber < thirdNumber) ||
                     (secondNumber < firstNumber && secondNumber > thirdNumber))
            {
                middle = secondNumber;
            }
            else
            {
                middle = thirdNumber;
            }

            Console.WriteLine($"The middle value is: {middle}");

        }
    }
}
