using LibarieModele;
using NivelStocareDate;

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfataUtilizator_WindowsForms
{
    public partial class MainBussinessesForm : Form
    {
        string numeFisier1 = "BussinessesFile";
        AdministrareBussiness_fisierText adminBussiness;
        int nrBussiness = 0;

        string columnId="Id";
        string columnNume= "Nume";
        string columnCityName= "CityName";
        string columnAddress="Address";
        string columnPhoneNumber= "PhoneNumber";


        public MainBussinessesForm()
        {

     
             adminBussiness = new AdministrareBussiness_fisierText(numeFisier1);
            adminBussiness.GetBussiness(out nrBussiness);
            InitializeComponent();
            dataGridView1.ReadOnly = false;
        
        }
 

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Bussiness> bussinesses = adminBussiness.GetBussiness(out nrBussiness);

            AfiseazaBussinesses(bussinesses);
        }
        public void RemoveControls(params Control[] controls)
        {
            foreach (Control control in controls)
            {
                if (control.Parent != null)
                {
                    control.Parent.Controls.Remove(control);
                }
            }
        }

        private void AfiseazaBussinesses(List<Bussiness> bussinesses)
        {
           

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add(columnId);
            dataTable.Columns.Add(columnNume);
            dataTable.Columns.Add(columnCityName);
            dataTable.Columns.Add(columnAddress);
            dataTable.Columns.Add(columnPhoneNumber);

            foreach (var bussiness in bussinesses)
            {
                // Obține obiectul DataTable asociat controlului DataGridView
               

                // Adaugă un nou rând în DataTable
                DataRow newRow = dataTable.NewRow();
                newRow[columnId] = bussiness.id;
                newRow[columnNume] = bussiness.name;
                newRow[columnCityName] = bussiness.cityName;
                newRow[columnAddress] = bussiness.address;
                newRow[columnPhoneNumber] = bussiness.phoneNumber;


                // Adaugă rândul nou în DataTable
                dataTable.Rows.Add(newRow);

                // Actualizează DataSource pentru a reflecta modificările în DataGridView
               
            }
            dataGridView1.DataSource = dataTable;

        }


        private void addButton_Click(object sender, EventArgs e)
        {
            using (AddBussinessForm frmDest = new AddBussinessForm(adminBussiness, nrBussiness))
            {
                var dr = frmDest.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    adminBussiness.GetBussiness(out nrBussiness);
                    frmDest.Close();
                }
            }

        }


        private void viewButton_Click_1(object sender, EventArgs e)
        {
            List<Bussiness> bussinesses = adminBussiness.GetBussiness(out nrBussiness);
            AfiseazaBussinesses(bussinesses);
           
        }

        private void deleteButton_Click_1(object sender, EventArgs e)
        {
         
            
                // Verifică dacă există cel puțin un rând selectat
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Parcurge fiecare rând selectat în ordine inversă
                    for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                    {
                        // Obține rândul selectat
                        DataGridViewRow selectedRow = dataGridView1.SelectedRows[i];

                    if (selectedRow.Cells[0].Value != null) {

                        adminBussiness.DeleteBussiness(Convert.ToInt32(selectedRow.Cells[0].Value));
                    }

                        // Șterge rândul din DataGridView
                        dataGridView1.Rows.Remove(selectedRow);
                    }
                AfiseazaBussinesses(adminBussiness.GetBussiness(out nrBussiness));
            }



        }

        private void bsnButton_Click(object sender, EventArgs e)
        {

        }

        private void emplButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formEmpl = new MainEmployeePage();
            formEmpl.Closed += (s, args) => this.Close();
            formEmpl.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainBussinessesForm_Load(object sender, EventArgs e)
        {

        }
    }

}
