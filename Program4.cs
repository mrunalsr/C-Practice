//Typecasting in C# using inbuilt funtcions
using System;
namespace Helllo
{
  class Program4
  {
    static void Main(string[] args)
    {
      int num = 72;
      double dnum = 7.2955;
      char cnum = 'M';
      bool bnum = true;

      Console.WriteLine("Before Typecasting");

      Console.WriteLine(num);
      Console.WriteLine(dnum);
      Console.WriteLine(cnum);
      Console.WriteLine(bnum);

      Console.WriteLine("After Typecasting");
      Console.WriteLine(Convert.ToChar(num));
      Console.WriteLine(Convert.ToInt32(dnum));
      Console.WriteLine(Convert.ToInt32(cnum));
      Console.WriteLine(Convert.ToInt32(bnum));
    }
  }
}