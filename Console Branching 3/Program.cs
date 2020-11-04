using System;
using Branching;
namespace Console_Branching_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter А: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter C: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int[] array =Branching.BranchingMethods.SortInIncreasingNumbers(a, b, c);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            
        }
    }
}
