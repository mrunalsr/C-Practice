//C# Method Overriding
using System;
namespace std{
    class Animal{
        public virtual void Sound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }
    class Dog : Animal{
        public override void Sound()
        {
            
            Console.WriteLine("Dog Barks");
        }
    }
    class Cat : Animal{
        public override void Sound()
        {
            Console.WriteLine("Cat Meow");
        }
    }
    class Program{
        static void Main(string[] args)
        {
            Animal a = new Animal();
            a.Sound();

            Animal dog = new Dog();
            dog.Sound();

            Animal cat = new Cat();
            cat.Sound();
        }
        

    }
}