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

        public List<Employee> GetEmployees(out int nrEmployee)
        {
            List<Employee> employees = new List<Employee>();

            
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrEmployee = 0;


                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Employee employee = new Employee(linieFisier);
                    employees.Add(employee);
                }
            }

            nrEmployee= employees.Count;
            return employees;
        }
        public void ClearFile(string fileName)
        {
            File.WriteAllText(fileName, string.Empty);
        }

        public void DeleteEmployee(int employeeId)
        {
            int nrEmployee;
            List<Employee> employees = GetEmployees(out nrEmployee);

            ClearFile(numeFisier);

                foreach (Employee employee in employees)
            {
                if(employee.employeeId == employeeId)
                {
                    employees.Remove(employee);
                    break;
                }
            }
            foreach (Employee employee in employees) {

                if (employee.employeeId > employeeId)
                {
                    employee.employeeId--;
                    
                }
                AddEmployee(employee);
            }
        }

    }

}   

