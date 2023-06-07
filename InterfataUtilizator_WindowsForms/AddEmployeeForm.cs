using LibarieModele;

using NivelStocareDate;

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace InterfataUtilizator_WindowsForms
{
    public partial class AddEmployeeForm : Form
    {

        AdministrareEmployee_fisierText adminEmployee;
        int nrEmployee;
        ArrayList slujbeSelectate = new ArrayList();

        public AddEmployeeForm()
        {
           
            InitializeComponent();
        }

        public AddEmployeeForm(AdministrareEmployee_fisierText admin, int _nrEmployee) : this()
        {
            adminEmployee = admin;
            nrEmployee= _nrEmployee;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveEmployee(); 
        
        }
        private void Ckb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox; //operator 'as'
            //sau
            //CheckBox checkBoxControl = (CheckBox)sender;  //operator cast

            string slujbaSelectate = checkBoxControl.Text;

            //verificare daca checkbox-ul asupra caruia s-a actionat este selectat
            if (checkBoxControl.Checked == true)
                slujbeSelectate.Add(slujbaSelectate);
            else
                slujbeSelectate.Remove(slujbaSelectate);
        }
        private void SaveEmployee()
        {
            // Obține valorile din controalele specifice
            string nume = numeTextBox.Text;
            string prenume = prenumeTextBox.Text;
            string cnp = cnpTextBox.Text;

            string gen;
            string idBusiness = busIdTextBox.Text;

            if (mRadButton.Checked)
            {
                gen = mRadButton.Text;
            }
            else
            {
                gen = fRadButton.Text;
            }
            // Crează un obiect de tip Employee și setează proprietățile corespunzătoare
            if (nume == "")
            {
                lblName.ForeColor = Color.Red;
                return;
            }
            if (prenume == "")
            {
                lblPrenume.ForeColor = Color.Red;
                return;
            }

           
            try
            {

                nrEmployee++;
                Employee employee = new Employee(Convert.ToInt32(cnp), nume, prenume, gen, nrEmployee, Convert.ToInt32(idBusiness));
              
                employee.role.AddRange(slujbeSelectate);
                adminEmployee.AddEmployee(employee);
                DialogResult = DialogResult.OK;
                // Salvează obiectul Employee într-un loc specific sau utilizează obiectul cum dorești
                // Exemplu: employee.SaveToDatabase();
            }
            catch (FormatException)
            {

                MessageBox.Show("Nu este un număr valid.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void mRadButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void chkBussiness_Click(object sender, EventArgs e)
        {
            using (CheckBusinesses frmDest = new CheckBusinesses())
            {
                var dr = frmDest.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                   
                    frmDest.Close();
                }
            }
        }
    }
}
