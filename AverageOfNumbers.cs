using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpDemo
{
    class AverageOfNumbers
    {
        static void Main(string[] args)
        {
            int sum = 0, count = 0;
            for(int i =1; i <= 5; i++)
            {
                try
                {
                    int num = Int32.Parse(Console.ReadLine());
                    sum += num;
                    count++;
                }
                //catch(FormatException ex)
                //{
                //    Console.WriteLine("Sorry! Invalid Number!");
                //    Console.Write("Please re-enter the number:");
                //    i--;
                //}
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    Console.WriteLine("Sorry! Invalid Number!");
                    Console.Write("Please re-enter the number:");
                    i--;
                }
            }
            Console.WriteLine("Average = {0}", sum / count);
        }
    }
}
