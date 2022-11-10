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
                Open();

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@FirstName", member.FirstName);
                sqlCommand.Parameters.AddWithValue("@SecondName", member.SecondName);
                sqlCommand.Parameters.AddWithValue("@Age", member.Age);
                sqlCommand.Parameters.AddWithValue("@Email", member.EMail);
                sqlCommand.Parameters.AddWithValue("@Password", member.Password);

                //Assegnazione dei parametri "speciali" a seconda del ruolo
                MemberRoleCheck(member, sqlCommand);
                sqlCommand.ExecuteScalar(); //L'eccezione si verifica arrivati a questo punto

                message.CustomBoxInformation("Operazione andata a buon fine!", "Aggiunta Docente/Studente");
            }

            catch
            {
                message.ErrorMessage();
            }

            finally
            {
                Close();
            }
        }

        public void DeleteMember(ListView list, int index)
        {


        }

        public void ShowDetails(ListView list, int index)
        {
            try
            {
                Open();
                string query = $"select * from {CheckTable(list)} where Id = @Id";
                SqlCommand command = new SqlCommand(query, sqlConnection);

                command.Parameters.AddWithValue("@Id", list.SelectedIndices);

                command.ExecuteReader();
            }
            catch
            {
                message.ErrorMessage();
            }
            finally
            {
                Close();
            }          

        }
        public void UpdateStudent(int index, Student student)
        {
            //Da richiamare in "FrmPersonalArea"
        }

        public void UpdateTeacher(int index, Teacher teacher)
        {
            //Da richiamare in "FrmPersonalArea"
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

        /// <summary>
        /// A seconda del nome della ListView, restituisce il nome della tabella nel DB corrispondente
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private string CheckTable(ListView list)
        {
            if (list.Name == "listStudents")
                return "Student";
  
            return "Teacher";
        }

        public DataTable ReadDataTable(string query)
        {
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

            DataTable dt = new DataTable();

            dataAdapter.Fill(dt);

            return dt;
        }
    }
}
