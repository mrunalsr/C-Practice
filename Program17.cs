//functions on array
using System;
using System.Linq;
namespace std{
    class Program{
        static void Main(string[] arg)
        {
            Console.WriteLine("Enter the size of array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];
            Console.WriteLine("Enter numbers in the array : ");
            for(int i=0;i<size;i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The numbers in array  are : ");
            for(int i=0;i<size;i++)
            {
                Console.Write(numbers[i] +" ");
            }

            //Sort array
           Array.Sort(numbers);
           Console.WriteLine("\nSorted Array:");
           foreach(int num in numbers)
           {
            Console.Write(num + " ");
           }

           //MAx in array
           int max = numbers.Max();
           Console.WriteLine("\nMAximum value in array : " +max);

           //Min of array
           int min = numbers.Min();
           Console.WriteLine("\nMinimum value in array is : "+min);

           //Sum of array
           int result = numbers.Sum();
           Console.WriteLine("\nsum of the array is : "+result);

        }
    } 
}