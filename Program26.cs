//C# Method Overloading
using System;
namespace std
{
    class Program{
        static int MyMethod(int x)
        {
            return x+7;
        }
        static float MyMethod(float x)
        {
            return x + 7;
        }
        static void Main(string[] args)
        {
            int intResult = MyMethod(5);
            float floatResult = MyMethod(5.2656f);

            Console.WriteLine("Result for int : " +intResult);
            Console.WriteLine("Result for float : " +floatResult);
        }
    }
}