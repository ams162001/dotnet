
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    //    Create an Abstract class Student with Name, StudentId, Grade as members
    //    and also an abstract method Boolean Ispassed(grade) which takes grade as an input and checks whether student passed the course or not.
    //Create 2 Sub classes Undergraduate and Graduate that inherits all members of the student and overrides Ispassed() method
    //For the UnderGrad class, if the grade is above 70.0, then isPassed returns true, otherwise it returns false.
    //For the Grad class, if the grade is above 80.0, then isPassed returns true, otherwise returns false.


    abstract class Student
    {
        public string Name;
        public int StudentId;
        public float grade;

        public abstract Boolean IsPassed(float grade);

    }

    class UndergGrad : Student
    {


        public override bool IsPassed(float grade) //overrided the abstract method regarding with the details of UnderGrad class.
        {
            if (grade > 70.0f)
            {
                Console.WriteLine("Passed");
                return true;
            }
            else
            {
                Console.WriteLine("Failed");
                return false;
            }
        }
    }
    class Grad : Student
    {
        public override bool IsPassed(float grade)//overrided the abstract method regarding with the details of Grad class.
        {
            if (grade > 80.0f)
            {
                Console.WriteLine("Passed");
                return true;
            }
            else
            {
                Console.WriteLine("Failed");
                return false;
            }
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            Student student = new UndergGrad();
            student.Name = "Aishwarya";
            student.StudentId = 1030061;
            Console.WriteLine("enter the grade for undergrad:");
            student.grade = Convert.ToSingle(Console.ReadLine());
            student.IsPassed(student.grade);
            student = new Grad();
            student.Name = "Roopa";
            student.StudentId = 1030062;
            Console.WriteLine("Enter the grade for grad");
            student.grade = Convert.ToSingle(Console.ReadLine());
            student.IsPassed(student.grade);
            Console.Read();



        }
    }
}
