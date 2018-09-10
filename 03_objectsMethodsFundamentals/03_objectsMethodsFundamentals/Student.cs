using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_objectsMethodsFundamentals
{
    class Student
    {
        //    1      2       3
        //public student(string firstName, string lastName, int grade)
        //{
        //          4                  5
        //this.FirstName = firstName;
        //this.LastName = lastName;
        //this.Grade = grade;

        // 1. Access Modifier
        // 2. Name of constructor(same name as class)
        // 3. Parameters for the constructor.The properties of the class are what your parameters can be
        // 4. Accessing the properties of your class using the keyword this
        // 5. We attach the properties to the parameters of the constructor so that when we instantiate new objects it will bring over the correct properties.
        //}

        //Constructor 1

        public Student()
        {
            
        }

        //Constructor 2

        public Student(string firstName)
        {
            this.FirstName = firstName;
        }

        //Constructor 3

        public Student(string firstName, string lastName)
        {
            this.LastName = lastName;
        }

        //Constructor 4

        public Student(string firstName, string lastName, int grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        //Constructor 5

        public Student(string firstName, string lastName, int grade, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
            this.Age = age;
        }

        //Properties

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
    }
}
