using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibarieModele
{
    public class Person

    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private const int CNP = 0;
        private const int NAME = 1;
        private const int SURNAME = 2;
        private const int GENDER = 3;
        private int cnp { get; set; }
        private string name { get; set; }
        private string surname { get; set; }
        private string gender { get; set; }
        public Person()
        {
            this.cnp = 0;
            name = surname = gender = string.Empty;
        }

        public Person(int cnp,string name,string surname,string gender){
            this.cnp = cnp;
            this.name = name;
            this.surname = surname;
            this.gender = gender;
           }

        public Person(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            cnp = Convert.ToInt32(dateFisier[CNP]);
            name = dateFisier[NAME];
            surname = dateFisier[SURNAME];
            gender = dateFisier[GENDER];
        }

        public virtual string Info()
        {
            string info = string.Format("Id:{0} Nume:{1} Prenume: {2},Gender: {3}",
                cnp.ToString(),
                (name ?? " NECUNOSCUT "),
                (surname ?? " NECUNOSCUT "),
                (gender ??"NECUNOSCUT"));

            return info;
        }
        public virtual string ConversieLaSir_PentruFisier()
        {
            string obiectStudentPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                cnp.ToString(),
                (name ?? " NECUNOSCUT "),
                (surname ?? " NECUNOSCUT "),
                (gender ?? "NECUNOSCUT"));

            return obiectStudentPentruFisier;
        }
    }
}
