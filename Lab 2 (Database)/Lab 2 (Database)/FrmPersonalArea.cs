using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1__Form_Application_
{
    public partial class FrmPersonalArea : Form
    {
        private SchoolMember authorizedUser;
        private Student authorizedStudent = new Student();
        private Teacher authorizedTeacher = new Teacher();

        public FrmPersonalArea()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmPersonalArea_Load(object sender, EventArgs e)
        {
            if (authorizedUser is Student)
                authorizedUser.Role = "Studente";

            else if (authorizedUser is Teacher)
                authorizedUser.Role = "Docente";

            txtFirstName.Text = authorizedUser.FirstName;
            txtSecondName.Text = authorizedUser.SecondName;
            txtEmail.Text = authorizedUser.EMail;
            txtPassword.Text = authorizedUser.Password;
            txtAge.Text = authorizedUser.Age.ToString() + " anni";
            txtRole.Text = authorizedUser.Role;

            //A seconda del ruolo verranno mostrate o meno le etichette "specifiche" (stipendio,corso,ecc...)
            if (authorizedUser is Student)
            {
                txtSalary.Visible = false;
                txtSubject.Visible = false;

                lblGpa.Visible = true;
                txtGpa.Visible = true;
                lblCourse.Visible = true;
                txtCourse.Visible = true;

                txtGpa.Text = authorizedStudent.Gpa.ToString();
                txtCourse.Text = authorizedStudent.Course;
            }

            else if(authorizedUser is Teacher)
            {
                txtGpa.Visible = false;
                txtCourse.Visible = false;

                lblSalary.Visible = true;
                txtSalary.Visible = true;
                lblSubject.Visible = true;
                txtSubject.Visible = true;

                txtSalary.Text = authorizedTeacher.Salary.ToString() + " €";
                txtSubject.Text = authorizedTeacher.Subject;
            }
                
        }

        /*Metodo che riceve come parametro dalla pagina precedente il membro in questione e lo 
        classifica come "Teacher" o "Student"*/
        public void GetMemberRole(SchoolMember member)
        {
            authorizedUser = member;

            if (member is Student)
                authorizedStudent = (Student) member;

            else
                authorizedTeacher = (Teacher) member;
        }

        private void lblSalary_Click(object sender, EventArgs e)
        {

        }
    }
}
