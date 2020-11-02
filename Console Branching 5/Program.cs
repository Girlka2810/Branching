using System;
using Branching;
namespace Console_Branching_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two-digit number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            string b = Branching.WriteNumber.IdentifyNumber(a);
            Console.WriteLine(b);
        }
    }
}
