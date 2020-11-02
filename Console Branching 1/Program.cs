using System;
using Branching;
namespace Console_Branching_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Branching.CompareAAndBAndSolve.Condition1(a, b);
            Console.WriteLine(c);
        }
    }
}
