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
    public partial class FrmAddMenu : Form
    {

        public FrmAddMenu()
        {
            InitializeComponent();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbRole.Text == "Docente")
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

            else if(cmbRole.Text == "Studente")
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

            else if( cmbRole.Text != "Student" && cmbRole.Text != "Docente")
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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Pulizia di tutti i campi di input

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmAddMenu_Load(object sender, EventArgs e)
        {
            //Disabilita la possibilità di scrivere all'interno della CombBox
           cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void lblCourse_Click(object sender, EventArgs e)
        {

        }
    }
}
