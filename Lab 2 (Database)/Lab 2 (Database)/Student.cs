using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2__Database_
{
    public class Student : SchoolMember
    {
        private double gpa;
        private string course;

        public double Gpa
        {
            get { return gpa; }
            set { gpa = value; }
        }

        public string Course
        {
            get { return course; }
            set { course = value; }
        }


        public Student()
        {
            FirstName = "INDEFINITO";
            SecondName = "INDEFINITO";
            EMail = "INDEFINITA";
            Password = "password123";
            Age = -1;
            Gpa = 0;
            Course = "NON DEFINITO";
        }

        public Student(string firstName)
        {
            FirstName = firstName;
            SecondName = "INDEFINITO";
            EMail = "INDEFINITA";
            Password = "password123";
            Age = -1;
            Gpa = 0;
            Course = "NON DEFINITO";

        }

        public Student(string firstName, string secondName) : base(firstName)
        {
            SecondName = secondName;
            Age = -1;
            EMail = "INDEFINITA";
            Password = "password123";
            Gpa = 0;
            Course = "NON DEFINITO";

        }

        public Student(string firstName, string secondName, int age) : this(firstName, secondName)
        {
            Age = age;
            EMail = "INDEFINITA";
            Password = "password123";
            Gpa = 0;
            Course = "NON DEFINITO";

        }


        public Student(string firstName, string secondName, int age, string eMail) : base(firstName, secondName, age)
        {
            EMail = eMail;
            Password = "password123";
            Gpa = 0;
            Course = "NON DEFINITO";
        }

        public Student(string firstName, string secondName, int age, string eMail, string password) : base(firstName, secondName, age, eMail)
        {
            Password = password;
            Gpa = 0;
            Course = "NON DEFINITO";

        }

        public Student(string firstName, string secondName, int age, string eMail, string password, double gpa)
            : base(firstName, secondName, age, eMail, password)
        {
            Gpa = gpa;
            Course = "NON DEFINITO";

        }

        public Student(string firstName, string secondName, int age, string eMail, string password, double gpa, string course)
            : base(firstName, secondName, age, eMail, password)
        {
            Gpa = gpa;
            Course = course;

        }


        public override string GetInfo(SchoolMember student)
        {
            return ($"{base.GetInfo(student)}Ruolo: Studente\nGPA: {Gpa}\nMateria di studio: {Course}\n" +
                $"\n{AccessMessage(student)}");
        }
    }
}
