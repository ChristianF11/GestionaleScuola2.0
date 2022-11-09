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

        }

        private void btnListBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //ELIMINAZIONE di un membro della lista
        private void btnDeleteMember_Click(object sender, EventArgs e)
        {

        }


        /*Metodo che restituisce alcuni DETTAGLI del membro selezionato sotto forma
        di "MessageBox*/
        private void btnDetails_Click(object sender, EventArgs e)
        {

        }

        //ELIMINAZIONE di TUTTA la lista
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {


        }

        public void AddToList(SchoolMember member)
        {
            schoolList.Add(member);
        }


    }
}
