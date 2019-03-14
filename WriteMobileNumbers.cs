using System;
using System.IO;

namespace cSharpDemo
{
    class WriteMobileNumbers
    {
        static bool IsMobileNumber(string s)
        {
            if (s.Trim().Length != 10)
                return false;

            for (int i = 0; i < s.Length; i++)
            {
                if (!Char.IsDigit(s[i]))
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            int lineNumber = 0;
            string word;
            StreamReader sr = new StreamReader
                (@"C:\Users\Tammina 121\Dropbox\.Net Course - Srikanth Technologies\Phones.txt");
            StreamWriter sw = new StreamWriter
                (@"C:\Users\Tammina 121\Dropbox\.Net Course - Srikanth Technologies\Mobiles.txt");

            while (true)
            {
                string line = sr.ReadLine();
                if (line == null)
                    break;

                //ignore line if it is blank.
                if (line.Trim().Length == 0)
                    continue;

                //split line using ,
                string[] parts = line.Split(',');
                
                //write to target file.
                foreach(string p in parts)
                {
                    if (IsMobileNumber(p))
                    {
                        lineNumber++;
                        word = lineNumber+": " + p;
                        sw.WriteLine(word);
                    }
                    
                }
            }//end of while loop.
            sw.Close();
            sr.Close();
        }
    }
}
