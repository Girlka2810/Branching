using System;
using Branching;
namespace Console_Branching_4
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
            string d = Branching.BranchingMethods.FindDiscriminant(a, b, c);
            Console.WriteLine(d);
        }
    }
}
