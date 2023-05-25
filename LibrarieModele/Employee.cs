using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibarieModele
{
    public class Employee:Person
    {
        private const int ID = 0;
        private const int ROLE = 5;
        private const int BUSINESSID = 6;
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';
        

        public int employeeId { get; set; }
        public ArrayList role = new ArrayList();

        public int businessId { get; set; }

        public string RoleAsString
        {
            get
            {
                return string.Join(SEPARATOR_SECUNDAR_FISIER.ToString(), role.ToArray());
            }
        }

        public Employee():base() {
            employeeId = 0;
           
        }
        public Employee(int cnp, string name, string surname, string gender, int employeeId, int businessId) : base(cnp, name, surname, gender)
        {
            this.employeeId = employeeId;
         
            this.businessId = businessId;
        }
        public Employee(string linieFisier) : base(linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            employeeId = Convert.ToInt32(dateFisier[ID]);

            businessId = Convert.ToInt32(dateFisier[BUSINESSID]);

            role = new ArrayList();
            role.AddRange(dateFisier[ROLE].Split(SEPARATOR_SECUNDAR_FISIER));
        }

        public override string ConversieLaSir_PentruFisier()
        {
            string baseString = base.ConversieLaSir_PentruFisier();
            string objForFile = string.Format(
                "{2}{0}{1}{3}{0}{4}{0}",
                SEPARATOR_PRINCIPAL_FISIER,baseString,employeeId, RoleAsString, businessId
                );
            return objForFile;
        }

        public override string Info()
        {
            string baseInfo= base.Info();
            string info = string.Format("IdAngajat:{1} ,{0} ,Role:{2} , Business: {3}",
               baseInfo.ToString(),
               (employeeId.ToString() ?? " NECUNOSCUT "),
               (RoleAsString ?? " NECUNOSCUT "),
               (businessId.ToString() ?? "NECUNOSCUT"));

            return info;

        }


    }


}
