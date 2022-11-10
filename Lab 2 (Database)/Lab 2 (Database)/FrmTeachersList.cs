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
            DataTable dt;
            dataOperation.Open();
            dt = dataOperation.ReadDataTable("select * from Teacher");
            dataGridView1.DataSource = dt;
            dataOperation.Close();
           
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            //dataOperation.ShowDetails(listTeachers, listTeachers.SelectedIndices[0]);
            string s = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            MessageBox.Show("current row:" + s);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
