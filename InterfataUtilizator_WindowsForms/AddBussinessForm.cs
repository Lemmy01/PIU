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

using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace InterfataUtilizator_WindowsForms
{
    public partial class AddBussinessForm : Form
    {
        AdministrareBussiness_fisierText adminBussiness;
        int nrBussinesses;
        public AddBussinessForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            SaveEmployee();
        }
        public AddBussinessForm(AdministrareBussiness_fisierText admin, int _nrBussinesses) : this()
        {
            adminBussiness = admin;
            nrBussinesses = _nrBussinesses;
        }
        private void SaveEmployee()
        {
            // Obține valorile din controalele specifice
            string nume = nameTxT.Text;
            string address = adressTxT.Text;
            string cityAdress = cityTxT.Text;

            
            string phoneNumber = phoneTxT.Text;

        
            // Crează un obiect de tip Employee și setează proprietățile corespunzătoare
            if (nume == "")
            {
                lblName.ForeColor = Color.Red;
                return;
            }
            if (address == "")
            {
                lblAdress.ForeColor = Color.Red;
                return;
            }


            try
            {

                nrBussinesses++;
                Bussiness business = new Bussiness(nrBussinesses,nume,Convert.ToInt32(phoneNumber),cityAdress,address);
                adminBussiness.AddBussiness(business);
                DialogResult = DialogResult.OK;
                // Salvează obiectul Employee într-un loc specific sau utilizează obiectul cum dorești
                // Exemplu: business.SaveToDatabase();
            }
            catch (FormatException)
            {
                nrBussinesses--;
                MessageBox.Show("Nu este un număr valid.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FileNotFoundException)
            {
                nrBussinesses--;
                Console.WriteLine("Fișierul specificat nu a fost găsit.");
            }
            catch (Exception ex)
            {
                nrBussinesses--;
                Console.WriteLine("A apărut o eroare la ștergerea angajatului: {0}", ex.Message);
            }



        }

    }
}
