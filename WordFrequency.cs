using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpDemo
{
    class WordFrequency
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"D:\.NET Practice\cSharpPractice\toCheckWordFrequency.txt");
            var frequency = new SortedDictionary<string,int>();

            while (true)
            {
                string line = sr.ReadLine();
                if (line == null)
                {
                    break;
                }
                string[] words = line.Split(',',' ','.');
                foreach (string w in words)
                {
                    if (frequency.Keys.Contains(w))
                        frequency[w]++; //increment of the word 'w'
                    else
                        frequency[w] = 1; //new word 'w', set count to 1.
                }
            }
            sr.Close();

            foreach (string w in frequency.Keys)
            {
                Console.WriteLine($"{w} ---> {frequency[w]}");
            }
        }
    }
}
