//while and do-while loop

/*using System;
namespace std
{
  class Program{
    static void Main(string[] args)
    {
      int i =6;
      while( i != 0)
      {
        Console.WriteLine(i);
        i--;
      }
    }
  }
}*/

using System;
namespace std{
  class Program{
    static void Main(string[] args)
    {
      int i = 0;
      do{
        Console.WriteLine(i);
        i++;
      }
      while(i<=5);
    }
  }
}