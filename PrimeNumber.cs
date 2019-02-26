using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpDemo
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            int num, check;
            Console.Write("Please enter a number to check if it is a prime number: ");
            num = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            if (num == 1)
            {
                Console.WriteLine("1 is neither Prime nor Composite number");
                return;
            }
            check = num;
            while (check > 1)
            {
                check = check - 1;
                if (check == 1)
                {
                    Console.WriteLine("{0} is a Prime number", num);
                }
                else
                    if ( num % check == 0)
                {
                    Console.WriteLine("{0} is NOT a Prime number", num);
                    break;
                }
            }
        }
    }
}
