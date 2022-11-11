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
        private DataTable personalDataTable;

        public FrmPersonalPage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void FrmPersonalArea_Load(object sender, EventArgs e)
        {
            dataGridPersonal.DataSource = personalDataTable;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
        }

        public void GetMemberData(DataTable dataTable)
        {
            dataOperation.Open();
            personalDataTable = dataTable;
            dataGridPersonal.DataSource = personalDataTable;
            dataOperation.Close();
        }
    }
}
