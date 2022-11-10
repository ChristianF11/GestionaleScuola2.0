using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2__Database_
{
    public partial class FrmAddMenu : Form
    {
        DbData dataOperation = new DbData();
        OperationMessage message = new OperationMessage();

        public FrmAddMenu()
        {
            InitializeComponent();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbRole.Text == "Docente")
            {
                TeacherVisible();
            }

            else if(cmbRole.Text == "Studente")
            {
                StudentVisible();
            }

            else if( cmbRole.Text != "Student" && cmbRole.Text != "Docente")
            {
                AllFieldsInvisible();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //dataOperation.Open();
            CheckInputField();
            //dataOperation.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Pulizia di tutti i campi di input
            Clear();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmAddMenu_Load(object sender, EventArgs e)
        {
            //Disabilita la possibilità di scrivere all'interno della CombBox
           cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CheckInputField()
        {
            int age = 0;

            if(txtFirstName.Text == "" || txtSecondName.Text == "" || txtAge.Text == "" || txtEmail.Text == "" || txtPassword.Text == "")
            {
                message.CustomBoxError("Compilare tutti i campi obbligatori", "Aggiunta Docente/Studente");
            }

            else
            {
                if (!int.TryParse(txtAge.Text, out age))
                    message.CustomBoxError("Inserire un'età valida", "Inserimento Docente/Studente");

                else
                {
                    MemberCreation(age);
                }
                
            }
        }

        private void TeacherVisible()
        {
            lblTeacher.Visible = true;
            lblSalary.Visible = true;
            txtSalary.Visible = true;
            lblSubject.Visible = true;
            txtSubject.Visible = true;

            lblStudent.Visible = false;
            lblGpa.Visible = false;
            txtGpa.Visible = false;
            lblCourse.Visible = false;
            txtCourse.Visible = false;
        }

        private void StudentVisible()
        {
            lblStudent.Visible = true;
            lblGpa.Visible = true;
            txtGpa.Visible = true;
            lblCourse.Visible = true;
            txtCourse.Visible = true;

            lblTeacher.Visible = false;
            lblSalary.Visible = false;
            txtSalary.Visible = false;
            lblSubject.Visible = false;
            txtSubject.Visible = false;
        }

        private void AllFieldsInvisible()
        {
            lblTeacher.Visible = false;
            lblSalary.Visible = false;
            txtSalary.Visible = false;
            lblSubject.Visible = false;
            txtSubject.Visible = false;

            lblStudent.Visible = false;
            lblGpa.Visible = false;
            txtGpa.Visible = false;
            lblCourse.Visible = false;
            txtCourse.Visible = false;
        }

        private void Clear()
        {
            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtAge.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtGpa.Text = "";
            txtCourse.Text = "";
            txtSalary.Text = "";
            txtSubject.Text = "";


            lblTeacher.Visible = false;
            lblSalary.Visible = false;
            txtSalary.Visible = false;
            lblSubject.Visible = false;
            txtSubject.Visible = false;

            lblStudent.Visible = false;
            lblGpa.Visible = false;
            txtGpa.Visible = false;
            lblCourse.Visible = false;
            txtCourse.Visible = false;

            cmbRole.Text = "";
        }

        private void MemberCreation(int age)
        {
            //Il valore di questa stringa corrisponderà con il nome della tabella del db in cui inserire la nuova persona
            string role = "";
            double gpa = 0;
            int salary = 0;

            if (cmbRole.Text == "Studente")
            {
                if (!double.TryParse(txtGpa.Text, out gpa))
                    gpa = 0;

                role = "Student";
                Student student = new Student(txtFirstName.Text, txtSecondName.Text, age, txtEmail.Text, txtPassword.Text, gpa, txtCourse.Text);
                dataOperation.AddMember(role, student);
            }

            else if (cmbRole.Text == "Docente")
            {
                if (!int.TryParse(txtSalary.Text, out salary))
                    salary = 0;

                role = "Teacher";
                Teacher teacher = new Teacher(txtFirstName.Text, txtSecondName.Text, age, txtEmail.Text, txtPassword.Text, salary, txtSubject.Text);
                dataOperation.AddMember(role, teacher);
            }

            else
                message.CustomBoxError("Errore di compilazione", "Inseirmento Docente/Studente");
        }
    }
}
