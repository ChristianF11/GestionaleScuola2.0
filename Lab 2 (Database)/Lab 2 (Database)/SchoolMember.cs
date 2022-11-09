using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab_1__Form_Application_
{
    /// <summary>
    /// Classe astratta e "parent" delle classi "Student" e "Teacher"
    /// </summary>

    public abstract class SchoolMember : ICheck
    {
        protected string firstName;
        protected string secondName;
        protected string eMail;
        protected string password;
        protected int age;
        protected bool isLogged;
        protected string role;
        protected int code;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string SecondName
        {
            set { secondName = value; }
            get { return secondName; }
        }

        public string EMail
        {
            get { return eMail; }
            set { eMail = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int Age
        {
            get { return age; }
            set {  age = value; }
        }

        public bool IsLogged
        {
            get { return isLogged; }
            set { isLogged = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        public SchoolMember()
        {
            FirstName = "INDEFINITO";
            SecondName = "INDEFINITO";
            EMail = "INDEFINITA";
            Password = "password123";
            Age = -1;
            IsLogged = false;
        }

        public SchoolMember(string firstName)
        {
            FirstName = firstName;
            SecondName = "INDEFINITO";
            EMail = "INDEFINITA";
            Password = "password123";
            Age = -1;
            IsLogged = false;
        }
    
        public SchoolMember(string firstName, string secondName) : this(firstName)
        {
            SecondName = secondName;
            Age = -1;
            EMail = "INDEFINITA";
            Password = "password123";
            IsLogged = false;
        }

        public SchoolMember(string firstName, string secondName, int age) : this(firstName,secondName)
        {
            Age = age;
            EMail = "INDEFINITA";
            Password = "password123";
            IsLogged = false;
        }

        public SchoolMember(string firstName, string secondName, int age, string eMail) : this(firstName,secondName,age)
        {
            EMail = eMail;
            Password = "password123";
            IsLogged=false;
        }

        public SchoolMember(string firstName, string secondName, int age, string eMail, string password) : this(firstName, secondName, age, eMail)
        {
            Password = password;
            IsLogged = false;
        }

        public virtual string GetInfo(SchoolMember member)
        {
            return ($"_______________________________________________________\n\n" +
                $"Riepilogo di {member.SecondName}\n\nNome: {member.FirstName}\n\nCognome: {member.SecondName}\n\n" +
                $"Età: {member.Age} anni\n\nEmail: {member.EMail}\n\n");
        }

        public bool Access()
        {
            if(IsLogged)
                return true;

            return false;
        }
        
        public string AccessMessage(SchoolMember member)
        {
            if (member.Access())
                return "Stato Account: Sei già loggato";

            return "Stato Account: Non sei ancora loggato";
        }

    }
}
