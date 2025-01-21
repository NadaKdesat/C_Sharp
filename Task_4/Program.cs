using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Task_4
{
    class Student //Creat Class
    {
        private int studentAge;
        public string StudentName {  get; set; } //property 
        public int StudentAge //property
        { 
            get
            {
                return studentAge; 
            }
            set 
            {
                if(studentAge>= MinAge && studentAge <= MaxAge)
                {
                    studentAge = value;
                }
                else
                {
                    studentAge = 18;
                }
            } 
        }  
        public int StudentId { get; set; } //property 
        public string studentEmail { get; set; } //property 
        public const int MinAge = 18; //constant
        public const int MaxAge = 40; //constant

        public void GetDetails() //method 
        {
            Console.WriteLine($"The student's name: {StudentName}");
            Console.WriteLine($"The student's age: {studentAge}");
            Console.WriteLine($"The student's ID: {StudentId}\n");
        }

        public Student() // Default Constructor without Parameter
        {
            this.StudentName = StudentName;
            this.StudentAge = StudentAge;
            this.StudentId = StudentId;
        }
        public Student(string StudentName, int StudentAge, int StudentId) // Parameterized Constructor
        {
            this.StudentName = StudentName;
            this.StudentAge = StudentAge;
            this.StudentId = StudentId;
        }

        ~Student()//Destructor
        {
            Console.WriteLine("Finish");
        }
    }  
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(); //Creat object
            student.StudentName = "Ahmad"; //change studen tName
            student.StudentAge = 22; //change student Age
            student.StudentId = 1001; //change student Id
            student.GetDetails();//Call the GetDetails method
            Student student2 = new Student("Nada",22,1002);//Creat object  
            student2.GetDetails();//Call the GetDetails method
            Student student3 = new Student("Mona", 23, 1003);//Creat object
            student3.GetDetails();//Call the GetDetails method
        }
    }

    //Questions :
    //1-What is class
    //A class is a blueprint for creating objects.
    //It defines properties (attributes) and methods (behaviors) that objects of the class can have.

    //2-What is object
    //An object is an instance of a class.
    //It is created based on the class and has specific values for its properties.

    //3-Difference between class && object
    //Class: A template or blueprint.
    //Object: A specific instance created from the class.


    //4-Mention the OOP Principles
    //1.Encapsulation: Hiding internal details and exposing functionality.
    //2.Abstraction: Simplifying complex systems by showing only essential features.
    //3.Inheritance: Reusing and extending code from a parent class.
    //4.Polymorphism: Performing a single action in different ways.

    //5-What is property 
    //A property is a characteristic of a class that defines the attributes of its objects,
    //often with getter and setter methods.

    //6-What is field 
    //A field is a variable declared in a class to store data.
    //It typically represents the internal state of an object.

    //7-What is constructor 
    //A constructor is a special method in a class used to initialize objects.
    //It runs automatically when an object is created.

    //8-What is encapsulation
    //Encapsulation is the practice of restricting access to certain parts of an object
    //and bundling data with methods to protect it from unauthorized access.









}
