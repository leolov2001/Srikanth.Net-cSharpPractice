using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpDemo
{
    class Student
    {
        private int roll; private string name, course;

        public Student(int roll, string name)
        {
            this.roll = roll;
            this.name = name;
            this.course = "Java";
        }
        public Student(int roll, string name, string course)
        {
            this.roll = roll;
            this.name = name;
            this.course = course;
        }

        public int GetCourseFee(string course)
        {
            int fee;
            if (course == "Java")
            {
                fee = 5000;
                return fee;
            }
            else
            {
                if (course == "Python")
                {
                    fee = 6000;
                    return fee;
                }
                else
                {
                    if (course == ".Net")
                    {
                        fee = 8000;
                        return fee;
                    }
                    else
                        return 0;
                }
            }
        }

        static void Main(string[] args)
        {
            int roll; string name, course;
            Console.Write("Please enter the roll #: ");
            roll=Int32.Parse(Console.ReadLine());
            Console.Write("Please enter the name of the student: ");
            name = (Console.ReadLine());
            Console.Write("Please enter the course: ");
            course = (Console.ReadLine());

            Student s1 = new Student(roll, name, course);

            Console.WriteLine(); Console.WriteLine();
            Console.Write("The Fee for {0} course to be paid by {1} is :", course, name);
            Console.WriteLine(s1.GetCourseFee(course));
        }
    }
}
