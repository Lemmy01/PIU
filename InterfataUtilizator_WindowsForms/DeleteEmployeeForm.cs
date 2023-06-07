using LibarieModele;

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
    public partial class DeleteEmployeeForm : Form
    {
        
        AdministrareEmployee_fisierText adminEmployee;
      
        public DeleteEmployeeForm()
        {
           
            InitializeComponent();
        }
        public DeleteEmployeeForm(AdministrareEmployee_fisierText admin) : this()
        {
            adminEmployee = admin;
            
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int employeeId = Convert.ToInt32(idBox.Text);
                adminEmployee.DeleteEmployee(employeeId);
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
