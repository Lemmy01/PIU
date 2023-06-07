using NivelStocareDate;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfataUtilizator_WindowsForms
{
    public partial class DeleteBussinessForm : Form
    {
        AdministrareBussiness_fisierText adminBussiness;


        public DeleteBussinessForm(AdministrareBussiness_fisierText admin) : this()
        {
            adminBussiness = admin;
        }
        public DeleteBussinessForm()
        {
            InitializeComponent();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int employeeId = Convert.ToInt32(idBox.Text);
                adminBussiness.DeleteEmployee(employeeId);
                Console.WriteLine("Angajatul cu ID-ul {0} a fost șters cu succes.", employeeId);
                DialogResult = DialogResult.OK;
            }
            catch (FormatException)
            {

                MessageBox.Show("ID-ul introdus nu este un număr valid.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Fișierul specificat nu a fost găsit.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("A apărut o eroare la ștergerea angajatului: {0}", ex.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }

}
