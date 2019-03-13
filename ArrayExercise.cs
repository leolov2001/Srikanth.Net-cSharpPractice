using System;

namespace cSharpDemo
{
    class ArrayExercise
    {
        static void Fill(int[] arr, int num = 1, int l = 10)
        {
            for(int i = 0; i < l; i++)
            {
                arr[i] = num;
            }

            for (int i = 0; i < 10; i++)
            {
                 if (i == 0)
                    {
                        Console.Write("[{0},", arr[i]);
                    }
                 else
                 {
                    if (i == 9)
                        {
                            Console.WriteLine("{0}]", arr[i]);
                        }
                    else
                        {
                            Console.Write("{0},", arr[i]);
                        }
                 }
            }
        }
        static void Main(string[] args)
        {
            //int[] n = new int[10];
            //int[] a = new int[10];
            //int min = 0, max = 9;
            //Console.Write("Please enter 10 numbers randomly: ");
            //for (int i=0; i<10;i++)
            //{
            //    n[i]=Int32.Parse(Console.ReadLine());
            //}
            //foreach (int i in n)
            //{
            //    if (i % 2 == 0)
            //    {
            //        a[min] = i;
            //        min += 1;
            //    }
            //    else
            //    {
            //        a[max] = i;
            //        max -= 1;
            //    }
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 0)
            //    {
            //        Console.Write("[{0},", a[i]);
            //    }
            //    else
            //    {
            //        if (i == 9)
            //        {
            //            Console.WriteLine("{0}]", a[i]);
            //        }
            //        else

            //        {
            //            Console.Write("{0},", a[i]);
            //        }
            //    }
            //}

            //Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            //Console.WriteLine("Lets do exercise 4.2 - Factorial of a given #");
            //Console.WriteLine(); Console.WriteLine();

            //Console.Write("Please enter a number: ");
            //int num2 = Int32.Parse(Console.ReadLine());
            //int fact = 1;
            //for (int i = 2; i <= num2; i++)
            //{
            //    fact = fact * i;
            //}
            //Console.WriteLine(); Console.WriteLine();
            //Console.WriteLine("Factorial of {0} is {1}.",num2,fact);

            //Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            //Console.WriteLine("Lets do exercise 4.3 - Factorial of a given #");
            //Console.WriteLine(); Console.WriteLine();

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Lets do exercise 4.4 - Fill Function");
            Console.WriteLine(); Console.WriteLine();

            int[] a = new int[10];
            Console.Write("Enter a number that you would like to fill the array");
            int n1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(); Console.WriteLine();
            Fill(a, n1);
            Console.WriteLine(); Console.WriteLine();
            Fill(a);
            Console.WriteLine(); Console.WriteLine();
            Fill(a, n1, 5);
            Console.WriteLine(); Console.WriteLine();
        }
    }
}
