using LibarieModele;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NivelStocareDate
{
    public class AdministrareEmployee_fisierText
    {
        private string numeFisier;
        private const int NR_MAX_ANGAJATI = 50;
        public AdministrareEmployee_fisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddEmployee(Employee employee)
        {
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(employee.ConversieLaSir_PentruFisier());
            }
        }

        public Employee[] GetEmployees(out int nrEmployee)
        {
            Employee[] employee = new Employee[NR_MAX_ANGAJATI];

            
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrEmployee = 0;


                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    employee[nrEmployee++] = new Employee(linieFisier);
                }
            }

            return employee;
        }
    }

}   

