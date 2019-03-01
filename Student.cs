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
    }
}
