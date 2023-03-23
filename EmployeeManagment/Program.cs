using LibarieModele;

using NivelStocareDate;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeFisier = "EmployeeFile";
            Employee employee = new Employee();
            int nrEmployee = 0;
            AdministrareEmployee_fisierText administrareEmployee_FisierText = new AdministrareEmployee_fisierText(numeFisier);

            Console.WriteLine("Introdu CNP angajatului  : ");
            int cnp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introdu numele angajatului : ");
            string nume = Console.ReadLine();

            Console.WriteLine("Introdu prenumele angajatului : ");
            string prenume = Console.ReadLine();

            Console.WriteLine("Introdu sex-ul angajatului (Masculin sau Feminin) : ");
            string gender = Console.ReadLine();

            Console.WriteLine("Introdu id angajatului(int)s : ");
            int id =Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Introdu rolul angajatului : ");
            string role = Console.ReadLine();


            employee = new Employee(cnp, nume, prenume,gender,id,role);
            nrEmployee++;
           
            Console.WriteLine(employee.Info());

            administrareEmployee_FisierText.AddEmployee(employee);

            Employee[] employees = administrareEmployee_FisierText.GetEmployees(out nrEmployee);

            afisare(employees,nrEmployee);
            Console.ReadKey();

        }
        public static void afisare(Employee[] list,int nrEmployee)
        {
            for ( int i =0;i<nrEmployee;i++)
            {
                Console.WriteLine(list[i].Info());
            }
        }
    }


  
}
