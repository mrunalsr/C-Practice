﻿//C# Inheritance
using System;
namespace std{
    /*sealed*/class Health{
        public string name = "Mrunal";
        public void Drink()
        {
            Console.WriteLine("Drink 5Li of water everyday");
        }
    }
    class Person : Health{
        public string level = "3lit";

    }
    //sealed class
    sealed class BP : Health
    {
        public string bp = "345";
        public void Test(){
            Console.WriteLine("Due to drininking water daily my BP is in contrl now");

        }
        
    }
    class Program{
        static void Main(string[] args)
        {
            Person obj = new Person();
            obj.Drink();
            Console.WriteLine($"Hii My name is {obj.name} and everyday I drink {obj.level} of water");
            BP obj1 = new BP();
            Console.WriteLine($"My BP is {obj1.bp}");
            obj1.Drink();
            
        }
    }
}