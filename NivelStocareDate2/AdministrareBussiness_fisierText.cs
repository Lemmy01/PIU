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
       private string numeFisier1 = "EmployeeFile";
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

        public List<Bussiness> GetBussiness(out int nrBussiness)
        {
            List<Bussiness> bussinesses = new List<Bussiness>();


            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrBussiness = 0;


                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                  bussinesses.Add(new Bussiness(linieFisier));
                }
            }
            nrBussiness = bussinesses.Count;

            return bussinesses;
        }
        public void ClearFile(string fileName)
        {
            File.WriteAllText(fileName, string.Empty);
        }

        public void DeleteBussiness(int bussinessId)
        {
            int nrBussinesses;
            List<Bussiness> bussinesses = GetBussiness(out nrBussinesses);
            AdministrareEmployee_fisierText admin =new AdministrareEmployee_fisierText(numeFisier1);

            ClearFile(numeFisier);

            foreach (Bussiness bussiness in bussinesses)
            {
                if (bussiness.id == bussinessId)
                {
                    admin.DeleteEmployeeByBussinessId(bussiness.id);
                    bussinesses.Remove(bussiness);
                    break;
                }
            }
            foreach (Bussiness bussiness in bussinesses)
            {

                if (bussiness.id > bussinessId)
                {
                   admin.UpdateEmployeeId(bussiness.id, --bussiness.id);
                  

                }
                AddBussiness(bussiness);
            }
        }

    }
}
