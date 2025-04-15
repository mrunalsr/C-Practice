//C# Multidimensional array
using System;
namespace std{
    class Program{
        static void Main(string[] args)
        {
            int[,] num = {{1,4,2},{3,6,8}};
            Console.WriteLine(num[0,2]);
            Console.WriteLine(num[0,0]);

            //using foreach loop
            foreach(int i in num)
            {
                Console.WriteLine(i);
            }
        }
    }
}