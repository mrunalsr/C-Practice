//C# Arrays
using System;
namespace std{
    class PRogram{
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array : ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[size];

            for(int i=0;i<size;i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nYou enterred the following numbers:");
            for(int i=0;i< size;i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}