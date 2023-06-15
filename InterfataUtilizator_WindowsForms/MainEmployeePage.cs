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
using System.Xml;

namespace InterfataUtilizator_WindowsForms
{
    public partial class MainEmployeePage : Form
    {
        string numeFisier1 = "EmployeeFile";
        AdministrareEmployee_fisierText adminEmployee;
        int nrEmployee = 0;

        private const string columnId = "Id";
        private const string columnNume = "Nume";
        private const string columnPrenume = "Prenume";
        private const string columnGen = "Gen";
        private const string columnRol = "Rol";
        private const string columnCNP = "CNP";
        private const string columnBussiness = "Bussiness";

  

        ArrayList slujbeSelectate = new ArrayList();
        public MainEmployeePage()
        {
            adminEmployee = new AdministrareEmployee_fisierText(numeFisier1);
            adminEmployee.GetEmployees(out nrEmployee);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Employee> employees = adminEmployee.GetEmployees(out nrEmployee);

            AfiseazaEmployees(employees);
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

        private void AfiseazaEmployees(List<Employee> employees)
        {

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add(columnId);
            dataTable.Columns.Add(columnNume);
            dataTable.Columns.Add(columnPrenume);
            dataTable.Columns.Add(columnGen);
            dataTable.Columns.Add(columnRol);
            dataTable.Columns.Add(columnCNP);
            dataTable.Columns.Add(columnBussiness);

            foreach (var employee in employees)
            {
                // Obține obiectul DataTable asociat controlului DataGridView


                // Adaugă un nou rând în DataTable
                DataRow newRow = dataTable.NewRow();
                newRow[columnId] = employee.employeeId;
                newRow[columnNume] = employee.name;
                newRow[columnPrenume] = employee.surname;
                newRow[columnGen] = employee.gender;
                newRow[columnRol] = employee.RoleAsString;
                newRow[columnCNP] = employee.cnp;
                newRow[columnBussiness] = employee.businessId;
                // Adaugă rândul nou în DataTable
                dataTable.Rows.Add(newRow);

                // Actualizează DataSource pentru a reflecta modificările în DataGridView

            }
            dataGridView1.DataSource = dataTable;
        }


        private void AddEmplButton_Click(object sender, EventArgs e)
        {
            using (AddEmployeeForm frmDest = new AddEmployeeForm(adminEmployee,nrEmployee))
            {
                var dr = frmDest.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    adminEmployee.GetEmployees(out nrEmployee);
                    frmDest.Close();
                }
            }

        }
        

        private void viewEmplButton_Click(object sender, EventArgs e)
        {
            List<Employee> studenti = adminEmployee.GetEmployees(out nrEmployee);
            AfiseazaEmployees(studenti);

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Verifică dacă există cel puțin un rând selectat
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Parcurge fiecare rând selectat în ordine inversă
                for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                {
                    // Obține rândul selectat
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[i];

                    if (selectedRow.Cells[0].Value != null)
                    {

                        adminEmployee.DeleteEmployee(Convert.ToInt32(selectedRow.Cells[0].Value));
                    }

                    // Șterge rândul din DataGridView
                    dataGridView1.Rows.Remove(selectedRow);
                }
                AfiseazaEmployees(adminEmployee.GetEmployees(out nrEmployee));
            }

 


        }

        private void bsnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formBussiness = new MainBussinessesForm();
            formBussiness.Closed += (s, args) => this.Close();
            formBussiness.Show();
        }

        private void MainEmployeePage_Load(object sender, EventArgs e)
        {

        }

        private void buttonPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
