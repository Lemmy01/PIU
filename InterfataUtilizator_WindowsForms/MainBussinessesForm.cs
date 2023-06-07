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

        private Label lblHeaderNume;
        private Label lblHeaderAdress;
        private Label lblHeaderCity;
        private Label lblHeaderPhone;

        private Label lblId;

        private Label[] lblsId;
        private Label[] lblsNume;
        private Label[] lblsAddress;
        private Label[] lblsPhoneNumber;
        private Label[] lblsCityName;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;
        private const int OFFSET_X = 300;

        public MainBussinessesForm()
        {
            adminBussiness = new AdministrareBussiness_fisierText(numeFisier1);
            adminBussiness.GetBussiness(out nrBussiness);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Bussiness> bussinesses = adminBussiness.GetBussiness(out nrBussiness);

            AfiseazaEmployees(bussinesses);
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

        private void AfiseazaEmployees(List<Bussiness> bussinesses)
        {

            //adaugare control de tip Label pentru 'id';
            lblId = new Label();
            lblId.Width = LATIME_CONTROL;
            lblId.Text = "Id";
            lblId.Left = OFFSET_X - DIMENSIUNE_PAS_X;
            lblId.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblId);

            //adaugare control de tip Label pentru 'Nume';
            lblHeaderNume = new Label();
            lblHeaderNume.Width = LATIME_CONTROL;
            lblHeaderNume.Text = "Nume";
            lblHeaderNume.Left = OFFSET_X + 0;
            lblHeaderNume.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblHeaderNume);

            //adaugare control de tip Label pentru 'Adress';
            lblHeaderAdress = new Label();
            lblHeaderAdress.Width = LATIME_CONTROL;
            lblHeaderAdress.Text = "Adress";
            lblHeaderAdress.Left = OFFSET_X + DIMENSIUNE_PAS_X;
            lblHeaderAdress.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblHeaderAdress);

            //adaugare control de tip Label pentru 'Phone Number';
            lblHeaderPhone = new Label();
            lblHeaderPhone.Width = LATIME_CONTROL;
            lblHeaderPhone.Text = "Phone Number";
            lblHeaderPhone.Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
            lblHeaderPhone.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblHeaderPhone);

            //adaugare control de tip Label pentru 'City Name';
            lblHeaderCity = new Label();
            lblHeaderCity.Width = LATIME_CONTROL;
            lblHeaderCity.Text = "City Name";
            lblHeaderCity.Left = OFFSET_X + 3 * DIMENSIUNE_PAS_X;
            lblHeaderCity.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblHeaderCity);


            int nrBussiness = bussinesses.Count;
            lblsId = new Label[nrBussiness];
            lblsNume = new Label[nrBussiness];
            lblsAddress = new Label[nrBussiness];
            lblsPhoneNumber = new Label[nrBussiness];
            lblsCityName = new Label[nrBussiness];       
            int i = 0;
            foreach (Bussiness bussiness in bussinesses)
            {

                lblsId[i] = new Label();
                lblsId[i].Width = LATIME_CONTROL;
                lblsId[i].Text = bussiness.id.ToString();
                lblsId[i].Left = OFFSET_X + -DIMENSIUNE_PAS_X;
                lblsId[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsId[i]);

                lblsNume[i] = new Label();
                lblsNume[i].Width = LATIME_CONTROL;
                lblsNume[i].Text = bussiness.name;
                lblsNume[i].Left = OFFSET_X + 0;
                lblsNume[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsNume[i]);

                lblsAddress[i] = new Label();
                lblsAddress[i].Width = LATIME_CONTROL;
                lblsAddress[i].Text = bussiness.address;
                lblsAddress[i].Left = OFFSET_X + DIMENSIUNE_PAS_X;
                lblsAddress[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsAddress[i]);

                lblsPhoneNumber[i] = new Label();
                lblsPhoneNumber[i].Width = LATIME_CONTROL;
                lblsPhoneNumber[i].Text = bussiness.phoneNumber.ToString();
                lblsPhoneNumber[i].Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
                lblsPhoneNumber[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsPhoneNumber[i]);

                lblsCityName[i] = new Label();
                lblsCityName[i].Width = LATIME_CONTROL;
                lblsCityName[i].Text = bussiness.cityName;
                lblsCityName[i].Left = OFFSET_X + 3 * DIMENSIUNE_PAS_X;
                lblsCityName[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsCityName[i]);

                i++;
            }
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
            AfiseazaEmployees(bussinesses);

        }

        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            using (DeleteBussinessForm frmDest = new DeleteBussinessForm(adminBussiness))
            {
                var dr = frmDest.ShowDialog(this);
                if (dr == DialogResult.OK)
                {


                    Controls.Clear();

                    InitializeComponent();

                    List<Bussiness> employees = adminBussiness.GetBussiness(out nrBussiness);

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

        private void emplButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formEmpl = new MainEmployeePage();
            formEmpl.Closed += (s, args) => this.Close();
            formEmpl.Show();
        }
    }

}
