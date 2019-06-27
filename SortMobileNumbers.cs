using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpDemo
{
    class SortMobileNumbers
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"D:\.NET Practice\cSharpPractice\mobilenumbers.txt");
            var mobiles = new SortedSet<string>();

            while (true)
            {
                string line = sr.ReadLine();
                if(line == null)
                {
                    break;
                }
                string[] numbers = line.Split(',');
                foreach(string n in numbers)
                {
                    if (n.Length == 10 && !mobiles.Contains(n))
                        mobiles.Add(n);
                }
            }
            sr.Close();

            foreach(string n in mobiles)
            {
                Console.WriteLine(n);
            }
        }
    }
}
