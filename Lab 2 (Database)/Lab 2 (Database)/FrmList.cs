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
    public partial class FrmList : Form
    {
        //Lista in cui verranno salvati i docenti e gli studenti creati
        private List<SchoolMember> schoolList = new List<SchoolMember>();
        private ListViewItem membersView = new ListViewItem();

        public FrmList()
        {
            InitializeComponent();
        }

        private void frmList_Load(object sender, EventArgs e)
        {
            int code = 0;

            listViewSchool.Items.Clear();

            //Creazione della tabella
            foreach(SchoolMember member in schoolList)
            {
                
                member.Code = code;

                if (member is Student)
                    member.Role = "Studente";

                else if (member is Teacher)
                    member.Role = "Docente";

                //Creazione della riga e aggiunta nella ListView
                string[] row = { member.Code.ToString(), member.FirstName, member.SecondName,member.Age.ToString(), member.EMail, member.Role };
                membersView = new ListViewItem(row);
                listViewSchool.Items.Add(membersView);

                code++;
            }
        }

        private void btnListBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //ELIMINAZIONE di un membro della lista
        private void btnDeleteMember_Click(object sender, EventArgs e)
        {

        }

        private void listSchool_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }


        /*Metodo che restituisce alcuni DETTAGLI del membro selezionato sotto forma
        di "MessageBox*/
        private void btnDetails_Click(object sender, EventArgs e)
        {
            //Verifico che la lista contenga almeno un elemento e che si stato selezionato qualcosa
            if(schoolList.Count > 0)
            {
                try
                {
                    MessageBox.Show(GetInfo(listViewSchool.SelectedIndices[0]), "Maggiori dettagli",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch(Exception)
                {
                    MessageBox.Show("Nessun elemento selezionato", "Errore",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else
            {
                MessageBox.Show("La lista è vuota", "Attenzione",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //ELIMINAZIONE di TUTTA la lista
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {


        }

        public void AddToList(SchoolMember member)
        {
            schoolList.Add(member);
        }


        /*Metodo che restituisce le informazioni presenti in tabella del membro selezionato
        sotto forma di "string"*/
        private string GetInfo(int index)
        {
            SchoolMember member = schoolList[index];
            string details = "";
            string censoredPassword = "";

            //Stampa password censurata
            for (int i = 0; i < member.Password.Length; i++)
            {
                censoredPassword += "*";
            }

            details += "Nome: " + member.FirstName + "\nCognome: " + member.SecondName;
            details += "\nEtà: " + member.Age + "\nEmail: " + member.EMail + "\nPassword: " + censoredPassword; 

            return details;
            
        }

    }
}
