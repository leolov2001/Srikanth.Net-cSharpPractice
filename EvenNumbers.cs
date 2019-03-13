using System;

namespace cSharpDemo
{
    class EvenNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number from 1 - 25: ");
            int i = Int32.Parse(Console.ReadLine());

            //for (int j=1; j<=i; j++)
            //{
            //    if (j % 2 == 0)
            //    {
            //        Console.WriteLine(j);
            //    }
            //}
            for (int j = 2; j <= i; j+=2)
            {
                Console.WriteLine(j);
            }

        }
    }
}
