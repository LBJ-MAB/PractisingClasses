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
    
    // practising properties and encapsulation
    class Person
    {
        // private string name;    // make a private field for name
        // public string Name // this is a property for name field
        // {
        //     get { return name; }    // get method
        //     set { name = value;  }  // set method
        // }
        
        // much more concise way of doing it:
        public string Name
        { get; set; }
    }
    
    // practising inheritance by defining a Vehicle class
    class Vehicle   // base class (parent)
    {
        public string brand = "Ford";    // brand of vehicle
        public void horn()
        {
            Console.WriteLine("Honk");
        }
    }
    // Van class will inherit Vehicle
    class Van : Vehicle     // derived class (child)
    {
        public int volume = 100;
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


            Person Adam = new Person();     // new Person class
            Adam.Name = "Adam";             // set name property
            Console.WriteLine("name : {0}", Adam.Name);    // get name property

            Van myVan = new Van();      // make an instance of Van which inherits vehicle
            myVan.horn();               // access the honk method because Van inherits Vehicle
            Console.WriteLine("Van volume: {0}", myVan.volume);    // access the volume field from Van itself
        }
    }
}