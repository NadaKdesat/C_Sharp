using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Create console application that read string from user and print the same string
            Console.Write("Enter String:");
            string str = Console.ReadLine();
            Console.WriteLine(str);

            //2 - Define variables with kind of
            //a.Double
            //b.String
            //c.Char
            //d.Bool
            //e.Int
            //f.Const
            //Then display it in console application

            double d = 4.7;
            String s = "Nada";
            Char c = 'n';
            bool b = true;
            int i = 22;
            const float pi = 3.14f;
            Console.WriteLine($"Double: {d}");
            Console.WriteLine($"String: {s}");
            Console.WriteLine($"Char: {c}");
            Console.WriteLine($"Bool: {b}");
            Console.WriteLine($"Int: {i}");
            Console.WriteLine($"Const: {pi}");

            //3 - Define array with name car that hold more than 3 kinds on cars, then print all the cars with the array length.
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine(cars.Length);

            //4 - Write a program in C# that reads a first name, Lastname and year of birth and display the names and the year one after another sequentially.Go to the editor
            //    •	Input your firstname: Sami
            //    •	Input your lastname: Ali
            //    •	Input your year of birth: 1999
            //    •	Sami Ali 1999
            Console.WriteLine("Enter your firstname: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter your lastname: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter your year of birth: ");
            string yearOfBirth = Console.ReadLine();
            Console.WriteLine($"{firstname} {lastname} {yearOfBirth}");

            //5 - Write a program in C # to store elements in an array and print it. 
            //    •	Test Data :	
            //    •	Input 10 elements in the array :
            //    •	element - 0 : 1
            //    •	element - 1 : 1
            //    •	element - 2 : 2
            //    •	.......
            //    •	Expected Output :
            //    •	Elements in array are: 1 1 2 3 4 5 6 7 8 9
            int[] num = new int[10];
            for (int y = 0; y < num.Length; y++)
            {
                Console.Write($"element - {y} :");
                num[y] = Convert.ToInt32(Console.ReadLine());
            }
            for (int y = 0; y < num.Length; y++)
            {
                Console.Write(y + " ");
            }
        }
    }
}
