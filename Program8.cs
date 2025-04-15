//Logical Operators
using System;
namespace Hello{
  class Program{
    static void Main(string[] args)
    {
      int x = 6;
      int y = 9;

      Console.WriteLine("logical && " +(x>5 && y<10));
      Console.WriteLine("logical || " +(x<5 || y<10));
      Console.WriteLine("logical ! " +(!(x>5 && y<10)));
    }
  }
}