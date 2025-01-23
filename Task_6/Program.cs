using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Add(int x, int y, int z)
        {
            return x + y + z;
        }
        public double Add(double x, double y)
        {
            return x + y;
        }
    }

    class Shape
    {
        public virtual void draw()
        {
            Console.WriteLine("Drawing a Shape");
        }
    }

    class Circle: Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }

    class Rectangle  : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }

    abstract class Animal
    {
        public abstract void MakeSound();
        public void Sleep()
        {
            Console.WriteLine("Animal is sleeping.");
        }
    }

    class Dog: Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows.");
        }
    }

    interface Playable
    {
        void Play();
    }

    class Guitar: Playable
    {
        public void Play()  
        {
            Console.WriteLine("Playing the guitar.");
        }
    }

    class Piano  : Playable
    {
        public void Play()
        {
            Console.WriteLine("Playing the piano.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Overloading:");
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(2, 3, 6));
            Console.WriteLine(calculator.Add(3.8, 4));

            Console.WriteLine("\n\nOverriding:");
            Shape circle= new Circle();
            circle.draw();
            Shape rectangle = new Rectangle();
            rectangle.draw();

            Console.WriteLine("\n\nAbstract Class:");
            Animal dog = new Dog();
            dog.MakeSound();
            Animal cat = new Cat();
            cat.MakeSound();

            Console.WriteLine("\n\nInterface:");
            Guitar guitar = new Guitar();
            guitar.Play();
            Piano piano = new Piano();
            piano.Play();
        }
    }
}
