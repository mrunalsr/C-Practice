//Use of const keyword
using System;
namespace HelloWorld{
  class Program{
    static void Main(string[] args)
    {
      const int num = 10;
      //num = 20 error
      Console.WriteLine(num);
    }
  }
}