//C# If-else
using System;
namespace HEllo
{
  class Program{
    static void Main(string[] args)
    {
      int x = 5;
      int y = 9;
      /*if(x<y)
      {
        Console.WriteLine("y is greater");
      }
      else if(x>y)
      {
        Console.WriteLine("X is greater");
      }
      else{
        Console.WriteLine("Error");
      }*/
      //short-hand if-else
      string result = (x>y) ? "x is greater" : "y is greater";
      Console.WriteLine(result);
    }
  }
}