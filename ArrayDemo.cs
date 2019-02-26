using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpDemo
{
    class ArrayDemo
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];//Initialized with 0s.

            Console.WriteLine("Enter 5 numbers one after the other:");

            for (int i = 0; i < 5; i++)
            {
                a[i] = Int32.Parse(Console.ReadLine());
            }

            //reverse order.
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.Write("The reverse order is: [");
            for (int i=4; i >= 0; i--)
            {
                if (i != 0)
                    Console.Write("{0},", a[i]);
                else
                    Console.Write("{0}]", a[i]);

            }
            //ascending order.
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

            int[] b = new int[5];
            for(int i=0; i < 5; i++)
            {
                for (int j=i+1; j < 5; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[j];
                        a[j] = a[i];
                        a[i] = temp;
                    }
                }
            }

            Console.Write("The ascending order is: [");
            for (int i = 0; i < 5; i++)
            {
                if (i != 4)
                    Console.Write("{0},", a[i]);
                else
                    Console.Write("{0}]", a[i]);
            }
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
        }
    }
}
