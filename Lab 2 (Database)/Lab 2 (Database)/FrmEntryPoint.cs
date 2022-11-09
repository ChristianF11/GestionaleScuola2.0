using Lab_1__Form_Application_;
using System;
using System.Windows.Forms;

namespace Lab_2__Database_
{
    public partial class FrmEntryPoint : Form
    {
        private bool operationDone = false;
        public FrmEntryPoint()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin loginForm = new FrmLogin();
            loginForm.ShowDialog();
        }

        private void btnViewList_Click(object sender, EventArgs e)
        {
            FrmList listForm = new FrmList();
            listForm.ShowDialog();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            FrmAddMenu addForm = new FrmAddMenu();
            addForm.ShowDialog();
        }

    }

}