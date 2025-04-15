//Switch case
/*using System;
namespace Hello
{
  class Program{
    static void Main(string[] args)
    {
      Console.WriteLine("simple calculator");
      Console.WriteLine("Enter the first number : ");
      double num1 = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Enter the second number : ");
      double num2 = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Choose Operation you want");
      Console.WriteLine("1. Addition (+)");
      Console.WriteLine("2. Substarction (-)");
      Console.WriteLine("3. Multiplication (*)");
      Console.WriteLine("4. Division (/)");

      int choice = Convert.ToInt32(Console.ReadLine());

      switch(choice)
      {
        case 1:
            Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
            break;
        case 2:
            Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
            break;
        case 3:
            Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
            break;
        case 4:
            if(num2 != 0)
            {
              Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
            }
            else
            {
              Console.WriteLine("Error");
  
            }
            break;
        default:
            Console.WriteLine("Invalid Choice");
            break;
      }
    }
  }
}*/

using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("\n--- Simple Calculator ---");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 5)
                {
                    keepRunning = false;
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                }
                else
                {
                    Console.Write("Enter First Number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter Second Number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
                            break;
                        case 2:
                            Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
                            break;
                        case 3:
                            Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
                            break;
                        case 4:
                            if (num2 != 0)
                            {
                                Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
                            }
                            else
                            {
                                Console.WriteLine("Error: Division by zero is not allowed.");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Choice! Please select a number between 1 and 5.");
                            break;
                    }
                }
            }
        }
    }
}
