//C# Abstraction
using System;
namespace std{
    public abstract class Animal{
        string name = "Dog";
        public abstract void Sound();
        public void Sleep()
        {
            Console.WriteLine("zzz");
        }
    }
    class Pig : Animal{
        public override void Sound()
        {
            Console.WriteLine("Wee Wee");
        }
    }
    class Dog : Animal{
        public override void Sound()
        {
            throw new NotImplementedException();
            Console.WriteLine("Bow BOw");
        }
    }
    class Program{
        static void Main(string[] args)
        {
            Pig obj = new Pig();
            Dog obj1 = new Dog();
            obj.Sound();
            obj.Sleep();
        }
    }
}