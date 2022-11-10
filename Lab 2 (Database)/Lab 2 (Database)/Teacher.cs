using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2__Database_
{
    public class Teacher : SchoolMember
    {
        private int salary;
        private string subject;

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
    
        public Teacher()
        {
            FirstName = "INDEFINITO";
            SecondName = "INDEFINITO";
            EMail = "INDEFINITA";
            Password = "password123";
            Age = -1;
            Salary = 0;
            Subject = "INDEFINITA";
        }

        public Teacher(string firstName)
        {
            FirstName = firstName;
            SecondName = "INDEFINITO";
            EMail = "INDEFINITA";
            Password = "password123";
            Age = -1;
            Salary = 0;
            Subject = "INDEFINITA";

        }

        public Teacher(string firstName, string secondName) : base(firstName)
        {
            SecondName = secondName;
            Age = -1;
            EMail = "INDEFINITA";
            Password = "password123";
            Salary = 0;
            Subject = "INDEFINITA";

        }

        public Teacher(string firstName, string secondName, int age) : this(firstName, secondName)
        {
            Age = age;
            EMail = "INDEFINITA";
            Password = "password123";
            Salary = 0;
            Subject = "INDEFINITA";

        }

        public Teacher(string firstName, string secondName, int age, string eMail) : base(firstName, secondName, age)
        {
            EMail = eMail;
            Password = "password123";
            Salary = 0;
            Subject = "INDEFINITA";
        }

        public Teacher(string firstName, string secondName, int age, string eMail, string password) 
            : base(firstName, secondName, age, eMail)
        {
            Password = password;
            Salary = 0;
            Subject = "INDEFINITA";

        }

        public Teacher(string firstName, string secondName, int age, string eMail, string password,int salary)
            : base(firstName, secondName, age, eMail) 
        {

            Salary = salary;
            Subject = "INDEFINITO";
        }

        public Teacher(string firstName, string secondName, int age, string eMail, string password, int salary, string subject)
            : base(firstName, secondName, age, eMail,password)
        {
            Salary = salary;
            Subject=subject;
        }

        public override string GetInfo(SchoolMember teacher)
        {
            return ($"{base.GetInfo(teacher)}Ruolo: Docente\nStipendio: {Salary} euro\nMateria: {Subject}\n" +
                $"{AccessMessage(teacher)}");
        }

    }
}
