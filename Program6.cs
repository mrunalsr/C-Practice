using System;
namespace Hello
{
  class Program{
    static void Main(string[] args)
    {
      //2)Assignment operator
      int x = 5;
      Console.WriteLine("Operator = " +(x));
      Console.WriteLine("Operator += " +(x+=3));
      Console.WriteLine("Operator -= " +(x-=3));
      Console.WriteLine("Operator *= " +(x*=3));
      Console.WriteLine("Operator /= " +(x/=3));
      Console.WriteLine("Operator %= " +(x%=3));
      Console.WriteLine("Operator &= " +(x&=3));
      Console.WriteLine("Operator |= " +(x|=3));
      Console.WriteLine("Operator ^= " +(x^=3));
      Console.WriteLine("Operator >>= " +(x>>3));
      Console.WriteLine("Operator = " +(x));
      Console.WriteLine("Operator <<= " +(x<<3));
      Console.WriteLine("Operator = " +(x));

    }
  }
}