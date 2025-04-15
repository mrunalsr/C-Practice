//Operators in C#
//1)Arithemtetic Operators
using System;
namespace Hello
{
  class Program{
    static void Main(string[] args)
    {
      //1)Arithemetic operators
      int x = 9;
      int y = 5;
      Console.WriteLine("Addition : " +(x+y));
      Console.WriteLine("Substraction : " +(x-y));
      Console.WriteLine("Multiplication : " +(x*y));
      Console.WriteLine("Division : " +(x/y));
      Console.WriteLine("Modulus : " +(x%y));
      Console.WriteLine("Increment : " +(x++));
      Console.WriteLine("After Increment : " +(x));
      Console.WriteLine("Decrement : " +(y--));
      Console.WriteLine("After decrement : " +(y));
      Console.WriteLine("pre-increment : " +(++x));
      Console.WriteLine("pre-decrement : " +(--y));



      
    }
  }
} 