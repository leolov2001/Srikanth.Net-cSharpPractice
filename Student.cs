using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpDemo
{
    class Student
    {
        private int roll, totalFee, feePaid = 0; private string name, course;

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

        public string Payment(int feePaid)
        {
            string message;
            if (feePaid + this.feePaid > this.totalFee)
            {
                message = "Cannot accept the fee as it will make the total fee paid greater than the course fee.";
                return message;
            }
            else
            {
                this.feePaid = feePaid + this.feePaid;
                if (this.totalFee - this.feePaid == 0)
                {
                    message = feePaid + " is added to the fee paid. You have cleared all your dues.";
                    return message; 
                }
                else
                {
                    int bal = this.totalFee - this.feePaid;
                    message = feePaid + " is added to the fee paid. The balance is " + bal;
                    return message; 
                }
            }
        }
        public int GetCourseFee(string course)
        {
            
            if (course == "Java")
            {
                this.totalFee = 5000;
                return this.totalFee;
            }
            else
            {
                if (course == "Python")
                {
                    this.totalFee = 6000;
                    return this.totalFee;
                }
                else
                {
                    if (course == ".Net")
                    {
                        this.totalFee = 8000;
                        return this.totalFee;
                    }
                    else
                        return 0;
                }
            }
        }

        static void Main(string[] args)
        {
            int roll,feePaid; string name, course;
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

            Console.Write("Entered the amount paid so far: ");
            feePaid = Int32.Parse(Console.ReadLine());

            Console.WriteLine(s1.Payment(feePaid));

        }
    }
}
