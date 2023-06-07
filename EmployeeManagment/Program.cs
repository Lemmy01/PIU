using LibarieModele;

using NivelStocareDate;

using System;
using System.Collections.Generic;

namespace EmployeeManagment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeFisier1 = "EmployeeFile";
            string numeFisier2 = "BussinessFile";
            Employee employee = new Employee();
            int nrEmployee = 0;
            int nrBussiness = 0;
            AdministrareEmployee_fisierText administrareEmployee_FisierText = new AdministrareEmployee_fisierText(numeFisier1);
            AdministrareBussiness_fisierText administrareBussiness_FisierText = new AdministrareBussiness_fisierText(numeFisier2);
            
            if (args.Length == 0) {
            administrareEmployee_FisierText.GetEmployees(out nrEmployee);
            administrareBussiness_FisierText.GetBussiness(out nrBussiness);

            Console.Write("Linia de comanda nu contine argumente\n");
            
            Console.WriteLine("Introdu CNP angajatului  : ");
            int cnp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introdu numele angajatului : ");
            string nume = Console.ReadLine();

            Console.WriteLine("Introdu prenumele angajatului : ");
            string prenume = Console.ReadLine();

            Console.WriteLine("Introdu sex-ul angajatului (Masculin sau Feminin) : ");
            string gender = Console.ReadLine();

            Console.WriteLine("Introdu rolul angajatului : ");
            string role = Console.ReadLine();


            employee = new Employee(cnp, nume, prenume, gender, nrEmployee, nrBussiness);
            nrEmployee++;

            Console.WriteLine(employee.Info());

            administrareEmployee_FisierText.AddEmployee(employee);



            List<Employee> employees = administrareEmployee_FisierText.GetEmployees(out nrEmployee);
                Console.WriteLine("Afisare din Fisier:\n");
            afisare(employees, nrEmployee);
            Console.ReadKey();
        }


        else
            {
                // afisarea numarului de argumente
                Console.WriteLine("Numarul de argumente este: {0}", args.Length);
                // afisarea argumentelor liniei de comanda
                foreach (string param in args)
                {
                    List<Employee> employees = administrareEmployee_FisierText.GetEmployees(out nrEmployee);
                    afisare(employees, nrEmployee);
                    Console.ReadKey();
                }    
                
            }
        }
        public static void afisare(List<Employee> list,int nrEmployee)
        {
            for ( int i =0;i<nrEmployee;i++)
            {
                Console.WriteLine(list[i].Info());
            }
        }
    }


  
}
