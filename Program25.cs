//C# Named Arguments
using System;
namespace std{
    class Program{
        static void MyMethod(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is : " +child3);
            Console.WriteLine("The second child is : " +child2);
            Console.WriteLine("The first child is : " +child1);
        }
        static void Main(string[] args)
        {
            MyMethod(child3: "Mrunal", child1: "Sakshi", child2:"Srushti");
        }
    }
}