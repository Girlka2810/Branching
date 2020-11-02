using System;
using Branching;
namespace Console_Branching_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter А: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            string c = Branching.SearchForQuater.Quater(a, b);
            Console.WriteLine(c);


        }
    }
}
