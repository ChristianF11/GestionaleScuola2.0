using Lab_2__Database_;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Lab_2__Database_
{
    public class DbData
    {
        SqlConnection sqlConnection = new SqlConnection();
        const string connectionString = "Server = LAPTOP-OH2IC4QE\\SQLEXPRESS;Integrated Security = False;Database = schoolDB;Persist Security Info=False;User ID = sa;Password = Christian11;";

        public DbData()
        {
            sqlConnection.ConnectionString = connectionString;
        }

        private OperationMessage message = new OperationMessage(); //Oggetto che permette di visualizzare degli alert
        public void Open()
        {
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
        }

        public void Close()
        {
            if (sqlConnection.State == ConnectionState.Open)
                sqlConnection.Close();
        }

        public void AddMember(string tableName, SchoolMember member)
        {
            try
            {
                
                string query = $"insert into {tableName} values (@FirstName, @SecondName,@Age, @Email, @Password, @FirstSpecialParam, @SecondSpecialParam)";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@FirstName", member.FirstName);
                sqlCommand.Parameters.AddWithValue("@SecondName", member.SecondName);
                sqlCommand.Parameters.AddWithValue("@Age", member.Age);
                sqlCommand.Parameters.AddWithValue("@Email", member.EMail);
                sqlCommand.Parameters.AddWithValue("@Password", member.Password);

                //Assegnazione dei parametri "speciali" a seconda del ruolo
                MemberRoleCheck(member, sqlCommand);
                sqlCommand.ExecuteScalar();

                message.CustomBoxInformation("Operazione andata a buon fine!", "Aggiunta Docente/Studente");
            }

            catch
            {
                message.ErrorMessage();
            }

        }

        public void DeleteMember(string query)
        {
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.ExecuteScalar();

        }

        public void DeleteAllList(string query)
        {
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.ExecuteScalar();
        }

        public void UpdateMember(DataGridView selectedMember, string query)
        {
            SqlCommand command = new SqlCommand(query, sqlConnection);

            command.Parameters.AddWithValue("@FirstName", selectedMember.CurrentRow.Cells[1].Value);
            command.Parameters.AddWithValue("@SecondName", selectedMember.CurrentRow.Cells[2].Value);
            command.Parameters.AddWithValue("@Age", selectedMember.CurrentRow.Cells[3].Value);
            command.Parameters.AddWithValue("@Email", selectedMember.CurrentRow.Cells[4].Value);
            command.Parameters.AddWithValue("@Password", selectedMember.CurrentRow.Cells[5].Value);
            command.Parameters.AddWithValue("@FirstSpecialParam", selectedMember.CurrentRow.Cells[6].Value);
            command.Parameters.AddWithValue("@SecondSpecialParam", selectedMember.CurrentRow.Cells[7].Value);

            command.ExecuteScalar();
        }

        private void MemberRoleCheck(SchoolMember member, SqlCommand sqlCommand)
        {
            if (member is Student)
            {
                Student student = (Student)member;

                sqlCommand.Parameters.AddWithValue("@FirstSpecialParam", student.Gpa);
                sqlCommand.Parameters.AddWithValue("@SecondSpecialParam", student.Course);

            }

            else if (member is Teacher)
            {
                Teacher teacher = (Teacher)member;

                sqlCommand.Parameters.AddWithValue("@FirstSpecialParam", teacher.Salary);
                sqlCommand.Parameters.AddWithValue("@SecondSpecialParam", teacher.Subject);
            }
        }

        public DataTable ReadDataTable(string query)
        {
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

            DataTable dt = new DataTable();

            dataAdapter.Fill(dt);

            return dt;
        }

        public Object CountElements(string query)
        {
            Object elements;

            SqlCommand command = new SqlCommand(query, sqlConnection);
            elements = command.ExecuteScalar();

            return elements;
        }
    }
}
