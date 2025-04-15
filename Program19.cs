//C# Multidimensional array
using System;
namespace std{
    class Program{
        static void Main(string[] args)
        {
            int[,] num = {{1,4,2},{3,6,8}};
            //using for loop
            for(int i=0;i<num.GetLength(0);i++)
            {
                for(int j=0;j<num.GetLength(1);j++)
                {
                    Console.WriteLine(num[i,j]);
                }
            }
        }
    }
}