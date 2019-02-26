using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpDemo
{
    class NoOfDays
    {
        static void Main(string[] args)
        {
            int year, month;
            Console.Write("Please enter the year: ");
            year = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter the number of the month (01 - 12): ");
            month = Int32.Parse(Console.ReadLine());

            switch (month)
            {
                case 02:
                case 2:
                    if (isLeap(year))
                    {
                        Console.WriteLine("The No. of Days in the month is 29");
                    }
                    else
                        Console.WriteLine("The No. of Days in the month is 28");
                    break;

                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("The No. of Days in the month is 31");
                    break;
                default:
                    Console.WriteLine("The No. of Days in the month is 30");
                    break;

            }
        }
    }
}
