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

        private Label lblHeaderNume;
        private Label lblHeaderPrenume;
        private Label lblHeaderGen;
        private Label lblHeaderRol;
        private Label lblHeaderCNP;
        private Label lblHeaderBussiness;
        private Label lblId;

        private Label[] lblsId;
        private Label[] lblsNume;
        private Label[] lblsPrenume;
        private Label[] lblsRol;
        private Label[] lblsCNP;
        private Label[] lblsGen;
        private Label[] lblsBussiness;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;
        private const int OFFSET_X = 300;

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

            //adaugare control de tip Label pentru 'id';
            lblId = new Label();
            lblId.Width = LATIME_CONTROL;
            lblId.Text = "Id";
            lblId.Left = OFFSET_X -DIMENSIUNE_PAS_X;
            lblId.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblId);

            //adaugare control de tip Label pentru 'Nume';
            lblHeaderNume = new Label();
            lblHeaderNume.Width = LATIME_CONTROL;
            lblHeaderNume.Text = "Nume";
            lblHeaderNume.Left = OFFSET_X + 0;
            lblHeaderNume.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblHeaderNume);

            //adaugare control de tip Label pentru 'Prenume';
            lblHeaderPrenume = new Label();
            lblHeaderPrenume.Width = LATIME_CONTROL;
            lblHeaderPrenume.Text = "Prenume";
            lblHeaderPrenume.Left = OFFSET_X + DIMENSIUNE_PAS_X;
            lblHeaderPrenume.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblHeaderPrenume);

            //adaugare control de tip Label pentru 'Rol';
            lblHeaderRol = new Label();
            lblHeaderRol.Width = LATIME_CONTROL;
            lblHeaderRol.Text = "Rol";
            lblHeaderRol.Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
            lblHeaderRol.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblHeaderRol);

            //adaugare control de tip Label pentru 'Gen';
            lblHeaderGen = new Label();
            lblHeaderGen.Width = LATIME_CONTROL;
            lblHeaderGen.Text = "Gen";
            lblHeaderGen.Left = OFFSET_X + 3 * DIMENSIUNE_PAS_X;
            lblHeaderGen.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblHeaderGen);

            //adaugare control de tip Label pentru 'CNP';
            lblHeaderCNP = new Label();
            lblHeaderCNP.Width = LATIME_CONTROL;
            lblHeaderCNP.Text = "CNP";
            lblHeaderCNP.Left = OFFSET_X + 4 * DIMENSIUNE_PAS_X;
            lblHeaderCNP.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblHeaderCNP);

            //adaugare control de tip Label pentru 'Bussiness';
            lblHeaderBussiness = new Label();
            lblHeaderBussiness.Width = LATIME_CONTROL;
            lblHeaderBussiness.Text = "Bussiness";
            lblHeaderBussiness.Left = OFFSET_X + 5 * DIMENSIUNE_PAS_X;
            lblHeaderBussiness.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblHeaderBussiness);

            int nrEmployees = employees.Count;
            lblsId = new Label[nrEmployees];
            lblsNume = new Label[nrEmployees];
            lblsPrenume = new Label[nrEmployees];
            lblsRol = new Label[nrEmployees];
            lblsCNP = new Label[nrEmployees];
            lblsGen = new Label[nrEmployees];
            lblsBussiness = new Label[nrEmployees];
             int i = 0;
            foreach (Employee employee in employees)
            {

                lblsId[i] = new Label();
                lblsId[i].Width = LATIME_CONTROL;
                lblsId[i].Text = employee.employeeId.ToString();
                lblsId[i].Left = OFFSET_X + -DIMENSIUNE_PAS_X;
                lblsId[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsId[i]);

                lblsNume[i] = new Label();
                lblsNume[i].Width = LATIME_CONTROL;
                lblsNume[i].Text = employee.name;
                lblsNume[i].Left = OFFSET_X + 0;
                lblsNume[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsNume[i]);

                lblsPrenume[i] = new Label();
                lblsPrenume[i].Width = LATIME_CONTROL;
                lblsPrenume[i].Text = employee.surname;
                lblsPrenume[i].Left = OFFSET_X + DIMENSIUNE_PAS_X;
                lblsPrenume[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsPrenume[i]);

                lblsRol[i] = new Label();
                lblsRol[i].Width = LATIME_CONTROL;
                lblsRol[i].Text = employee.RoleAsString;
                lblsRol[i].Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
                lblsRol[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsRol[i]);    

                lblsGen[i] = new Label();
                lblsGen[i].Width = LATIME_CONTROL;
                lblsGen[i].Text = employee.gender;
                lblsGen[i].Left = OFFSET_X + 3 * DIMENSIUNE_PAS_X;
                lblsGen[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsGen[i]);

                lblsCNP[i] = new Label();
                lblsCNP[i].Width = LATIME_CONTROL;
                lblsCNP[i].Text = employee.cnp.ToString();
                lblsCNP[i].Left = OFFSET_X + 4 * DIMENSIUNE_PAS_X;
                lblsCNP[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsCNP[i]);

                lblsBussiness[i] = new Label();
                lblsBussiness[i].Width = LATIME_CONTROL;
                lblsBussiness[i].Text = employee.businessId.ToString();
                lblsBussiness[i].Left = OFFSET_X + 5 * DIMENSIUNE_PAS_X;
                lblsBussiness[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsBussiness[i]);

                i++;
            }
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
            using (DeleteEmployeeForm frmDest = new DeleteEmployeeForm(adminEmployee))
            {
                var dr = frmDest.ShowDialog(this);
                if (dr == DialogResult.OK)
                {


                    Controls.Clear();

                    InitializeComponent();

                    List<Employee> employees = adminEmployee.GetEmployees(out nrEmployee);

                    AfiseazaEmployees(employees);
                    frmDest.Close();
                }
            }

        }

        private void bsnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formBussiness = new MainBussinessesForm();
            formBussiness.Closed += (s, args) => this.Close();
            formBussiness.Show();
        }
    }
}
