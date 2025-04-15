//3) Comparison operator
using System;
namespace Hello{
  class Program{
    static void Main(string[] args)
    {
      int x = 10;
      int y = 12;
      
      Console.WriteLine("Operator == " +(x==y));
      Console.WriteLine("Operator != " +(x!=y));
      Console.WriteLine("Operator == " +(x>y));
      Console.WriteLine("Operator == " +(x<y));
      Console.WriteLine("Operator == " +(x>=y));
      Console.WriteLine("Operator == " +(x<=y));
      
    }
  }
}