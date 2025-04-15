//C# Strings methods
using System;
namespace Hello
{
  class Program{
    static void Main(string[] args)
    {
      string str = "Mrunal Raksale";
      string str1 = "Mansi Raksale";

      //Get Length of String
      Console.WriteLine("Length " + str.Length);
      //Convert to upper case
      Console.WriteLine("Toupper " + str.ToUpper());
      //Convert to lowercase
      Console.WriteLine("Tolower " + str.ToLower());
      //Concat string
      Console.WriteLine("Concate " + String.Concat(str, str1));
      Console.WriteLine("Concate " + (str+str1));

      //string interpolation
      Console.WriteLine($"My name is {str} and My sister name is {str1}");

      //Access strings
      Console.WriteLine(str[4]);
      Console.WriteLine(str.IndexOf('R'));
      Console.WriteLine(str.Substring(7));

    }
  }
}