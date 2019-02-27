﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpDemo
{
    class ArrayExercise
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            int[] a = new int[10];
            int min = 0, max = 9;
            Console.Write("Please enter 10 numbers randomly: ");
            for (int i=0; i<10;i++)
            {
                n[i]=Int32.Parse(Console.ReadLine());
            }
            foreach (int i in n)
            {
                if (i % 2 == 0)
                {
                    a[min] = i;
                    min += 1;
                }
                else
                {
                    a[max] = i;
                    max -= 1;
                }
            }

            for(int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    Console.Write("[{0},", a[i]);
                }
                else
                {
                    if (i == 9)
                    {
                        Console.WriteLine("{0}]", a[i]);
                    }
                    else
                    {
                        Console.Write("{0},", a[i]);
                    }
                }
            }
        }
    }
}