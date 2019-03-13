using System;

namespace cSharpDemo
{
    class LeapYear
    {
        static void Main()
        {
            int year;
            Console.Write("Enter an Year: ");
            year=Int32.Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 100 == 0)
            {
                Console.WriteLine("{0} is a Leap Year", year);
            }
            else
                Console.WriteLine("{0} is NOT a Leap Year", year);
        }
    }
}
