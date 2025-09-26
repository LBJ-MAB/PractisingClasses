using System;

namespace PractisingClasses
{
    // Car class
    class Car
    {
        public string color = "red";        // color - field
        public string model;                // model - field - not defined yet
        public int maxSpeed;                // max speed - field - not defined yet
        public int year;                    // year - field - not defined yet
        
        // fullThrottle - method
        public void fullThrottle()
        {
            Console.WriteLine("This car is going full speed!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // making an instance of Car class called myObj
            Car myObj = new Car();
            // setting the max speed of myObj
            myObj.maxSpeed = 200;
            
            // outputting color of myObj to console
            Console.WriteLine($"The color of myObj is {myObj.color}");
            // outputting maxSpped of myObj to console
            Console.WriteLine("The max speed of myObj is {0}", myObj.maxSpeed);
            
            // making a new instance of Car class with different features
            Car citroenC1 = new Car();
            citroenC1.maxSpeed = 71;
            citroenC1.year = 2018;
            citroenC1.model = "C1";
            
            // call the fullThrottle method
            citroenC1.fullThrottle();

        }
    }
}