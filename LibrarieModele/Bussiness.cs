using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibarieModele

{
    public class Bussiness
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private const int ADDRESS = 0;
        private const int NAME = 1;
        private const int PHONE = 2;
        private const int CITY = 3;

        private string address { get; set; }
        private string name { get; set; }

        private string phoneNumber { get; set; }

        private string cityName { get; set; }

        private List<string> employeeIds { get; set; }

        public void addID(string id)
        {
            employeeIds.Add(id);
        }

        public Bussiness()
        {
            address =  name = phoneNumber = cityName = string.Empty;
            employeeIds = new List<string>();
        }

        public Bussiness(string name, string phoneNumber, string cityName, string address)
        {
            this.phoneNumber = phoneNumber;
            this.name = name;
            this.cityName = cityName;
            this.address = address;
        }

        public Bussiness(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            address =dateFisier[ADDRESS];
            name = dateFisier[NAME];
            phoneNumber = dateFisier[PHONE];
            cityName = dateFisier[CITY];
        }


        public string ConversieLaSir_PentruFisier()
        {
            string obiectStudentPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                address,
                (name ?? " NECUNOSCUT "),
                (phoneNumber ?? " NECUNOSCUT "),
                (cityName ?? "NECUNOSCUT"));

            return obiectStudentPentruFisier;
        }
    }
}
