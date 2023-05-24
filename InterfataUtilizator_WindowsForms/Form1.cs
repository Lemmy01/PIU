using LibarieModele;

using NivelStocareDate;

using System;
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
    public partial class Form1 : Form
    {
        string numeFisier1 = "EmployeeFile";
        AdministrareEmployee_fisierText adminEmployee;
        int nrEmployee = 0;

        private TextBox surnameTextBox;
        private TextBox nameTextBox;
        private TextBox cnpTextBox;
        private TextBox businessIdTextBox;
        private RadioButton maleRadioButton;
        private RadioButton femaleRadioButton;
        private RadioButton femaleBox;
        private TextBox roleTextBox;


        private Label lblHeaderNume;
        private Label lblHeaderPrenume;
        private Label lblHeaderGen;
        private Label lblHeaderRol;
        private Label lblHeaderCNP;
        private Label lblHeaderBussiness;

        private Label[] lblsNume;
        private Label[] lblsPrenume;
        private Label[] lblsRol;
        private Label[] lblsCNP;
        private Label[] lblsGen;
        private Label[] lblsBussiness;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;
        private const int OFFSET_X = 600;
        public Form1()
        {
            adminEmployee = new AdministrareEmployee_fisierText(numeFisier1);
            InitializeComponent();
        }

        private void ClearControls()
        {
            // Elimină toate controalele din colecția Controls
            Controls.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Employee> employees = adminEmployee.GetEmployees(out nrEmployee);

            AfiseazaEmployees(employees);
        }

        private void AfiseazaEmployees(List<Employee> employees)
        {
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
            lblsNume = new Label[nrEmployees];
            lblsPrenume = new Label[nrEmployees];
            lblsRol = new Label[nrEmployees];
            lblsCNP= new Label[nrEmployees];
            lblsGen = new Label[nrEmployees];
            lblsBussiness = new Label[nrEmployees];
             int i = 0;
            foreach (Employee employee in employees)
            {
      
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
                lblsRol[i].Text = employee.role;
                lblsRol[i].Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
                lblsRol[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsRol[i]);

                lblsGen[i] = new Label();
                lblsGen[i].Width = LATIME_CONTROL;
                lblsGen[i].Text = employee.role;
                lblsGen[i].Left = OFFSET_X + 3 * DIMENSIUNE_PAS_X;
                lblsGen[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsGen[i]);

                lblsCNP[i] = new Label();
                lblsCNP[i].Width = LATIME_CONTROL;
                lblsCNP[i].Text = employee.role;
                lblsCNP[i].Left = OFFSET_X + 4 * DIMENSIUNE_PAS_X;
                lblsCNP[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsCNP[i]);

                lblsBussiness[i] = new Label();
                lblsBussiness[i].Width = LATIME_CONTROL;
                lblsBussiness[i].Text = employee.role;
                lblsBussiness[i].Left = OFFSET_X + 5 * DIMENSIUNE_PAS_X;
                lblsBussiness[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsBussiness[i]);

                i++;
            }
        }

        private void AddEmployeeControls()
        {
            // Eticheta și caseta de text pentru Nume
            Label nameLabel = new Label();
            nameLabel.Text = "Nume:";
            nameLabel.Location = new Point(50, 50);
            Controls.Add(nameLabel);

             nameTextBox = new TextBox();
            nameTextBox.Location = new Point(150, 50);
            Controls.Add(nameTextBox);

            // Eticheta și caseta de text pentru Prenume
            Label surnameLabel = new Label();
            surnameLabel.Text = "Prenume:";
            surnameLabel.Location = new Point(50, 80);
            Controls.Add(surnameLabel);

             surnameTextBox = new TextBox();
            surnameTextBox.Location = new Point(150, 80);
            Controls.Add(surnameTextBox);

            // Eticheta și caseta de text pentru CNP
            Label cnpLabel = new Label();
            cnpLabel.Text = "CNP:";
            cnpLabel.Location = new Point(50, 110);
            Controls.Add(cnpLabel);

            cnpTextBox = new TextBox();
            cnpTextBox.Location = new Point(150, 110);
            Controls.Add(cnpTextBox);

            // Eticheta și caseta de text pentru Rol
            Label roleLabel = new Label();
            roleLabel.Text = "Rol:";
            roleLabel.Location = new Point(50, 140);
            Controls.Add(roleLabel);

             roleTextBox = new TextBox();
            roleTextBox.Location = new Point(150, 140);
            Controls.Add(roleTextBox);

            // Eticheta și caseta de selectare pentru Gen
            Label genderLabel = new Label();
            genderLabel.Text = "Gen:";
            genderLabel.Location = new Point(50, 170);
            Controls.Add(genderLabel);

            maleRadioButton = new RadioButton();
            maleRadioButton.Text = "Masculin";
            maleRadioButton.Location = new Point(150, 170);
            maleRadioButton.Checked = true; // Bifăm inițial radiobutton-ul pentru genul masculin
            Controls.Add(maleRadioButton);

            // Radiobutton pentru Genul Feminin
             femaleRadioButton = new RadioButton();
            femaleRadioButton.Text = "Feminin";
            femaleRadioButton.Location = new Point(300, 170);
            Controls.Add(femaleRadioButton);

            // Eticheta și caseta de text pentru ID Business
            Label businessIdLabel = new Label();
            businessIdLabel.Text = "ID Business:";
            businessIdLabel.Location = new Point(50, 200);
            Controls.Add(businessIdLabel);

             businessIdTextBox = new TextBox();
            businessIdTextBox.Location = new Point(150, 200);
            Controls.Add(businessIdTextBox);

            Button saveButton = new Button();
            saveButton.Text = "Salvează";
            saveButton.Location = new Point(150, 230);
            saveButton.Click += SaveButton_Click; // Asocierea evenimentului Click al butonului cu o funcție de tratare
            Controls.Add(saveButton);
        }

        private void SaveEmployee()
        {
            // Obține valorile din controalele specifice
            string nume = nameTextBox.Text;
            string prenume = surnameTextBox.Text;
            string cnp = cnpTextBox.Text;
            string rol = roleTextBox.Text;
            string gen;
            string idBusiness = businessIdTextBox.Text;

            if (maleRadioButton.Checked) {
                gen = maleRadioButton.Text;
            }
            else
            {
                gen = femaleRadioButton.Text;
            }
            // Crează un obiect de tip Employee și setează proprietățile corespunzătoare
            Employee employee = new Employee(Convert.ToInt32(cnp),nume,prenume,gen, nrEmployee, rol,Convert.ToInt32(idBusiness));
            nrEmployee++;

            adminEmployee.AddEmployee(employee);
            // Salvează obiectul Employee într-un loc specific sau utilizează obiectul cum dorești
            // Exemplu: employee.SaveToDatabase();
        }

        private void AddEmplButton_Click(object sender, EventArgs e)
        {
            ClearControls();

            AddEmployeeControls();

        }


        private void viewEmplButton_Click(object sender, EventArgs e)
        {
            List<Employee> studenti = adminEmployee.GetEmployees(out nrEmployee);
            AfiseazaEmployees(studenti);


        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Codul pentru salvarea angajatului
            SaveEmployee();
            ClearControls();
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
