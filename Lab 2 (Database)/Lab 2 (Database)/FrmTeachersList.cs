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
    public partial class FrmTeachersList : Form
    {
        DbData dataOperation = new DbData();
        OperationMessage message = new OperationMessage();

        private string selectedId;
        public FrmTeachersList()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmTeachersList_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            ToPersonalPage();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelected();
        }

        private void LoadList()
        {
            DataTable dt;
            dataOperation.Open();
            dt = dataOperation.ReadDataTable("select Id, FirstName,SecondName,Age,Email from Teacher");
            dataGridTeacher.DataSource = dt;
            dataOperation.Close();
        }

        private void ToPersonalPage()
        {
            FrmPersonalPage personalPage = new FrmPersonalPage("Teacher");

            dataOperation.Open();

            //Verifico che sia presente almeno un elemento
            if (dataOperation.CountElements("select Id from Teacher") == null)
            {
                message.CustomBoxError("Lista vuota", "Visualizza dettagli");
                dataOperation.Close();
            }

            else
            {
                //Comando che ottiene e salva l'ID selezionato
                selectedId = dataGridTeacher.CurrentRow.Cells[0].Value.ToString();
                personalPage.GetMemberData(dataOperation.ReadDataTable($"select * from Teacher where Id = {selectedId}"));
                dataOperation.Close();
                personalPage.ShowDialog();
            }
        }

        private void DeleteSelected()
        {
            dataOperation.Open();

            if (dataOperation.CountElements("select Id from Teacher") == null)
            {
                message.CustomBoxError("Lista vuota", "Visualizza dettagli");
                dataOperation.Close();
            }

            else
            {
                //Eliminazione confermata (tramite "MessageBox") dell'elemento selezionato
                selectedId = dataGridTeacher.CurrentRow.Cells[0].Value.ToString();
                if (message.ConfirmDelete())
                {
                    dataOperation.Open();
                    dataOperation.DeleteMember($"delete from Teacher where Id = {selectedId}");
                    dataOperation.Close();
                    LoadList();
                }
            }

        }

        private void DeleteAll()
        {
            dataOperation.Open();

            if (dataOperation.CountElements("select Id from Teacher") == null)
            {
                message.CustomBoxError("Lista vuota", "Visualizza dettagli");
                dataOperation.Close();
            }

            else
            {
                selectedId = dataGridTeacher.CurrentRow.Cells[0].Value.ToString();
                if (message.ConfirmDeleteAll())
                {
                    dataOperation.Open();
                    dataOperation.DeleteAllList("delete from Teacher");
                    dataOperation.Close();
                    message.CustomBoxInformation("Operazione andata a buon fine!", "Eliminazione");
                    LoadList();
                }
            }
        }

        private void btnDeletAll_Click(object sender, EventArgs e)
        {
            DeleteAll();
        }
    }
}
