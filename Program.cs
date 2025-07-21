using System;
namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(3, 4);
            var p2 = new Point(1, 2);
            var sum =p1+p2;
            var difference =p1-p2;
            var scaled =p1 *2;
            var divided =  p1/2;
            Console.WriteLine($"sum of {p1} and {p2} is {sum}");
            Console.WriteLine($"difference of {p1} and {p2} is {difference}");
            Console.WriteLine($"scaled {p1} by 2 is {scaled}");
            Console.WriteLine($"divided {p1} by 2 is {divided}");
        }
    }
}   
