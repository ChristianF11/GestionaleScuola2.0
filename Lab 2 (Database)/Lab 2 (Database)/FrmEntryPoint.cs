using Lab_2__Database_;
using System;
using System.Windows.Forms;

namespace Lab_2__Database_
{
    public partial class FrmEntryPoint : Form
    {
        public FrmEntryPoint()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnViewList_Click(object sender, EventArgs e)
        {
            FrmStudentsList studentListForm = new FrmStudentsList();
            studentListForm.ShowDialog();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            FrmAddMenu addForm = new FrmAddMenu();
            addForm.ShowDialog();
        }

        private void btnToTeacherList_Click(object sender, EventArgs e)
        {
            FrmTeachersList teacherListForm= new FrmTeachersList();
            teacherListForm.ShowDialog();
        }
    }

}