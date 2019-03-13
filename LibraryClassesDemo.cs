using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpDemo
{
    class LibraryClassesDemo
    {
        public static void PrintVertical(string v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine(v[i]);
            }
        }
        public static void ValidPhoneNumber(string v)
        {
            if(v.Length == 10)
            {
                Console.WriteLine("It is a valid phone number.");
            }
            else
            {
                Console.WriteLine("It is not a valid phone number.");
            }
            
        }
        public static void SplitNames(string v)
        {
            string[] names = v.Split(',');
            foreach (string n in names)
                Console.WriteLine(n.ToUpper());

        }

        public static void IsCount(string v)
        {
            int count = 0, start = 0;
            while (v.IndexOf("is", start)!=-1)
            {
                count++;
                start = (v.IndexOf("is", start))+1;
            }

            if (count > 0)
            {
                Console.WriteLine("The string 'is' appears for {0} number of times in the given string.", count);
            }
            else
            {
                Console.WriteLine("The string 'is' does not appear in the given string.");
            }
            
        }

        static void Main(string[] args)
        {
            string vertical;

            //Ex 8.1
            //Console.Write("Please enter the string to be printed vertically: ");
            //vertical = Console.ReadLine();

            //PrintVertical(vertical);


            //Ex8.2
            //Console.Write("Please enter the string to be checked as valid phone #: ");
            //vertical = Console.ReadLine();

            //ValidPhoneNumber(vertical);

            //Ex8.3
            //Console.Write("Please enter the string of names seperated by ','s: ");
            //vertical = Console.ReadLine();

            //SplitNames(vertical);

            //Ex8.4
            //Console.Write("Please enter the string to check for 'is': ");
            //vertical = Console.ReadLine();

            //IsCount(vertical);

            //Ex8.5
            Console.Write("Please enter the string to check for 'is': ");
            vertical = Console.ReadLine();

            IsCount(vertical);
        }
    }
}
