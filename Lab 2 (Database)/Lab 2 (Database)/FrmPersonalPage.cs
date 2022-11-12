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
    public partial class FrmPersonalPage : Form
    {
        DbData dataOperation = new DbData();
        private string selectedTable;

        public FrmPersonalPage()
        {
            InitializeComponent();
        }

        public string SelectedTable
        {
            get { return selectedTable; }
            set { selectedTable = value; }

        }

        public FrmPersonalPage(string selectedTable)
        {
            InitializeComponent();
            this.SelectedTable = selectedTable;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void FrmPersonalArea_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string selectedId = dataGridPersonal.CurrentRow.Cells[0].Value.ToString();
            dataOperation.Open();
            dataOperation.UpdateMember(dataGridPersonal, LongQuery(selectedId, SelectedTable));
            dataOperation.Close();
            this.Hide();
        }

        public void GetMemberData(DataTable dataTable)
        {
            DataTable dt;
            dataOperation.Open();
            dt = dataTable;
            dataGridPersonal.DataSource = dt;
            dataOperation.Close();
        }

        private string LongQuery(string selectedId, string tableName)
        {
            /*string query = "update" + tableName + "set FirstName = @FirstName, SecondName = @SecondName, " +
                "Age = @Age, Email = @Email, Password = @Password, " + "Gpa = @Gpa, Course = @Course where Id = " + selectedId;*/

            string query = "update " + tableName + " set FirstName = @FirstName where Id = " + selectedId;

            return query;
        }

        
    }
}
