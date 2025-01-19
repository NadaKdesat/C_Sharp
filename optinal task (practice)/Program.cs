using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optinal_task_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Define an array named fruits that holds more than 5 different types of fruits. Then, print each fruit
            //along with its indexin the array, followed by the total number of fruits in the array.
            string[] fruits = { "Apple", "Banana", "Orange", "Mango", "Strawberry", "Grapes" };
            int i = 0;
            foreach (string fruit in fruits)
            {
                Console.WriteLine($"Fruit at index {++i}: {fruit}");
            }
            Console.WriteLine($"The Total number of fruits: {fruits.Length}\n\n");



            //2 - Write a program in C# to store 5 integers in an array. Then, reverse the order of the elements and print
            //both the original and reversed arrays.
            //HINT : Convert.ToInt32(console.ReadLine())
            int[] integers = new int[5];
            Console.WriteLine("Input 5 numbers into the array:");
            for (int j = 0; j < integers.Length; j++)
            {
                Console.Write($"Numbers at index {j}: ");
                integers[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Original array: ");
            for (int j = 0; j < integers.Length; j++)
            {
                Console.Write($"{integers[j]} ");
            }
            Console.Write("\nreversed array: ");
            for (int j = integers.Length - 1; j >= 0; j--)
            {
                Console.Write($"{integers[j]} ");
            }


            //3 - Write a program in C# to define an array of strings representing different colors. Then, count and display
            //how many colors start with the letter "R" (case insensitive).
            Console.Write("\n\nInput colors into the array: ");
            string input = Console.ReadLine();
            string[] colors = input.Split(',');
            Console.Write("Colors string with 'R': ");
            int count = 0;
            for (int j = 0; j < colors.Length; j++)
            {
                if (colors[j].FirstOrDefault() == 'R')
                {
                    Console.Write($"{colors[j]}, ");
                    count++;
                }
            }
            Console.Write($"\nTotal count: {count}");



            //4 - Sum , sort , min , max and Average of Array Elements
            //Hint: using Convert.ToInt32(console.ReadLine())
            int[] integers2 = new int[5];
            Console.WriteLine("\n\nInput 6 numbers into the array:");
            for (int j = 0; j < integers2.Length; j++)
            {
                Console.Write($"Numbers at index {j}: ");
                integers2[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"\nSum of elements: {integers2.Sum()}");
            Console.WriteLine($"Average of elements: {integers2.Average()}");
            Console.WriteLine($"The Min element: {integers2.Min()}");
            Console.WriteLine($"The Max element: {integers2.Max()}");
            Array.Sort(integers2);
            Console.WriteLine($"The array after sort: {string.Join(", ", integers2)}");

        }
    }
}
