using System;

namespace cSharpDemo
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter the number to display it in reverse order: ");
            num = Int32.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("The Reverse Order is: ");
            while (num > 0)
            {
                //Console.WriteLine();
                //Console.WriteLine(num % 10);
                Console.Write(num % 10);
                num = num / 10;
            }
            Console.WriteLine(); Console.WriteLine();
        }
    }
}
