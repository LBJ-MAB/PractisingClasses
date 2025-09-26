using System;

namespace PractisingClasses
{
    // Car class
    class Car
    {
        public string color;                // color - field
        public string model;                // model - field - not defined yet
        public int year;                    // year - field - not defined yet
        public int maxSpeed;                // maxSpeed - field - not defined yet
        
        // creating a class constructor. Must be same name as class, and not have a return type
        public Car(string modelName)
        {
            maxSpeed = 100;             // set max speed to 100
            model = modelName;          // setting model to modelName arg
        }
        
        // fullThrottle - method
        public void fullThrottle()
        {
            Console.WriteLine("This car is going full speed!");
        }

        public void printCarDetails()
        {
            Console.WriteLine("--- Car Info ---");
            Console.WriteLine("Car color: {0}", color);
            Console.WriteLine("Car model: {0}", model);
            Console.WriteLine("Car maxSpeed: {0}", maxSpeed);
            Console.WriteLine("Car year: {0}", year);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("C1");      // creating instance of Car class

            myCar.color = "red";    // set color
            myCar.year = 2018;      // set year

            myCar.fullThrottle();       // call full throttle method
            myCar.printCarDetails();    // print car details method
        }
    }
}