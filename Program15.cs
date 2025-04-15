//Foreach loop
using System;
namespace std{
    class Program{
        static void Main(string[] args)
        {
            string[] cars = {"A","B","C", "D","E"};
            foreach(string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}