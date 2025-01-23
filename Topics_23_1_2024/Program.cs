using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics_23_1_2024
{
    //class Animal  // Base class (parent) 
    //{
    //    public virtual void animalSound()
    //    {
    //        Console.WriteLine("The animal makes a sound");
    //    }
    //}

    //class Pig : Animal  // Derived class (child) 
    //{
    //    public override void animalSound()
    //    {
    //        base.animalSound();
    //        Console.WriteLine("The pig says: wee wee");
    //    }
    //}

    //class Dog : Animal  // Derived class (child) 
    //{
    //    public override void animalSound()
    //    {
    //        Console.WriteLine("The dog says: bow wow");
    //    }
    //}


    // Abstract class
    abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Animal)
    class Pig : Animal
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            //Animal myDog = new Dog();  // Create a Dog object

            //myAnimal.animalSound();
            myPig.animalSound();
            //myDog.animalSound();
        }
    }
}
