using System;

namespace Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("it is even");
            }
            else
            {
                Console.WriteLine("It is odd");
            }


        }
    }
}
