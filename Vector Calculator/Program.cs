using System;

namespace Vector_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector test1 = new Vector(1, 2, 3);
            Vector test2 = new Vector(-1, 2, -3);
            
            
            // This should be 0, 4, 0
            Console.WriteLine(Vector.Add(test1, test2));
            Console.WriteLine(Vector.Subtract(test1, test2));
            Console.WriteLine(Vector.Negate(test2));
            Console.WriteLine(test2.GetMagnitude());
            Console.WriteLine(test1.GetDirection());
            Console.WriteLine(Vector.Scale(test1, 5.356f));
            Console.WriteLine(Vector.Normalize(test1).GetMagnitude());
            Console.WriteLine(Vector.DotProduct(test1, test2));
            Console.WriteLine(Vector.CrossProduct(test1, test2));
            Console.WriteLine(Vector.AngleBetween(test1, test2));
            Console.WriteLine(Vector.ProjectOnto(test1, test2));
        }
    }
}
