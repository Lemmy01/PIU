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

using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace InterfataUtilizator_WindowsForms
{
    public partial class CheckBusinesses : Form
    {
        AdministrareBussiness_fisierText adminBusinesses;
        private string numeFisier= "BussinessesFile";
        public CheckBusinesses()
        {   
            InitializeComponent();
            adminBusinesses = new AdministrareBussiness_fisierText(numeFisier);
            AfiseazaListaCompleta();
        }

       
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckBusinesses_Load(object sender, EventArgs e)
        {

        }
        private void AfiseazaListaCompleta()
        {
            listBusinesses.Items.Clear();
            int nrBussinesses;
            List<Bussiness> bussiness = adminBusinesses.GetBussiness(out nrBussinesses);
            foreach (Bussiness b in bussiness)
            {
                listBusinesses.Items.Add(string.Format("{0} {1}", b.id,b.name));
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
