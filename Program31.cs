//C# Constructor with and without parameters
using System;
namespace std{
    class Car{
        string name = "Mrunal";
        string model;
        public Car(){
            model= "Samsung";
        }
        public Car(string lname) //it uses the parameterized constructor (Car(string lname)), so: name becomes "Raksale".model stays null because this constructor doesn't set model.
        {
            name = lname;
        }
        static void Main(string[] args)
        {
            Car obj = new Car("Raksale");
            Console.WriteLine(obj.name);
            Console.WriteLine(obj.model);
            Console.WriteLine(obj.name);
        }
    }
}
/*
using System;

namespace std
{
    class Car
    {
        public string name;  // Make it public so Main can access it
        public string model; // Make it a class-level variable

        // Constructor without parameters
        public Car()
        {
            name = "Mrunal";
            model = "Samsung";
        }

        // Constructor with parameters
        public Car(string name, string model)
        {
            this.name = name;
            this.model = model;
        }

        static void Main(string[] args)
        {
            // Using constructor without parameters
            Car obj1 = new Car();
            Console.WriteLine($"Name: {obj1.name}");
            Console.WriteLine($"Model: {obj1.model}");

            // Using constructor with parameters
            Car obj2 = new Car("Toyota", "Corolla");
            Console.WriteLine($"Name: {obj2.name}");
            Console.WriteLine($"Model: {obj2.model}");
        }
    }
}
*/