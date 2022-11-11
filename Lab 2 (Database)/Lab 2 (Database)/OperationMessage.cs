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

        public bool ConfirmDelete()
        {
            DialogResult userChoice;

            userChoice = MessageBox.Show("Sei sicuro di voler eliminare questo elemento?", "Eliminazione", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DialogResult.Yes == userChoice)
                return true;

            return false;
        }

        public bool ConfirmDeleteAll()
        {
            DialogResult userChoice;

            userChoice = MessageBox.Show("Sei sicuro di voler eliminare TUTTO L'ELENCO?", "Eliminazione",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DialogResult.Yes == userChoice)
                return true;

            return false;
        }

    }
}
