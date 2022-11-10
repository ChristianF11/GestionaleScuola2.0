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
    public partial class FrmLogin : Form
    {
        //Lista in cui verranno salvati i docenti e gli studenti creati
        private List<SchoolMember> memberList = new List<SchoolMember>();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLoginBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*Questa variabile cambia il valore nel momento in cui viene effettuato l'accesso
             (questo per evitare di rifare i controlli quando si deve mostrare il messaggio di
            errore)*/
            bool access = false;

            foreach(SchoolMember member in memberList)
            {
                if(txtUsername.Text == member.EMail && txtPassword.Text == member.Password)
                {
                    //Accesso all'"Area personale"
                    FrmPersonalArea personalAreaForm = new FrmPersonalArea();
                    access = true;
                    this.Hide();
                    personalAreaForm.GetMemberRole(member);
                    personalAreaForm.ShowDialog();
                    
                }

            }

            if(txtUsername.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Compila tutti i campi", "Inserire credenziali",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if(!access && (txtUsername.Text != "" && txtPassword.Text != ""))
            {
                MessageBox.Show("Credenziali errate!", "Accesso negato",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        public void AddToList(SchoolMember member)
        {
            memberList.Add(member);
        }

        public void RemoveFromList(int index)
        {
            memberList.RemoveAt(index);
        }

        public void DeleteList()
        {
            memberList.Clear();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
