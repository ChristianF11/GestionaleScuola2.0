using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2__Database_
{
    /// <summary>
    /// Classe che si occupa di gestire e mostrare tutti i messaggi necessari all'interno del programma tramite "MessageBox"
    /// </summary>
    public class OperationMessage
    {
        public void ErrorMessage()
        {
            MessageBox.Show("Qualcosa è andato storto!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Messaggio di informazione personalizzabile
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        public void CustomBoxInformation(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Messaggio di errore personalizzabile
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        public void CustomBoxError(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ConfirmDelete()
        {
            MessageBox.Show("Sei sicuro di voler eliminare questo elemento?", "Eliminazione", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        public void ShowDetails(SchoolMember member)
        {
            MessageBox.Show(StringDetails(member), "Dettagli", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 

        private string StringDetails(SchoolMember member) 
        {
            string details = "";

            details += "Nome: " + member.FirstName + "\nCognome: " + member.SecondName + "\nEtà: " + member.Age.ToString() +
                "\nEmail: " + member.EMail;

            if(member is Student)
            {
                Student student = (Student) member;
                details += "\nRuolo: Studente" + "\nCorso: " + student.Course;
            }

            else if(member is Teacher)
            {
                Teacher teacher = (Teacher)member;
                details += "\nRuolo: Docente" + "\nMateria: " + teacher.Subject;
            }
            return details;
        }

    }
}
