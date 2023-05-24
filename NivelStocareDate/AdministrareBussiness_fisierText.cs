using LibarieModele;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelStocareDate
{
    public class AdministrareBussiness_fisierText
    {

        private string numeFisier;
        private const int NR_MAX_ANGAJATI = 50;
        public AdministrareBussiness_fisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddBussiness(Bussiness business)
        {
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(business.ConversieLaSir_PentruFisier());
            }
        }

        public Bussiness[] GetBussiness(out int nrBussiness)
        {
            Bussiness[] bussiness = new Bussiness[NR_MAX_ANGAJATI];


            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrBussiness = 0;


                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    bussiness[nrBussiness++] = new Bussiness(linieFisier);
                }
            }


            return bussiness;
        }
    }
}
