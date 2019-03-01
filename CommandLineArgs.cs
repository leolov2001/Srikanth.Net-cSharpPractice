using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpDemo
{
    class CommandLineArgs
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please make sure you enter arguments along with the application name when you are trying to run the app from command line.");
                return;
            }
            else
            {
                int i = Int32.Parse(args[0]);

                Console.WriteLine("You have entered {0}", i);
            }
            


        }
    }
}
