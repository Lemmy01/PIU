using System;
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
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private int employeeId { get; set; }
        private string role { get; set; }

        public Employee():base() {
            employeeId = 0;
            role = string.Empty;
        }
        public Employee(int cnp, string name, string surname, string gender, int employeeId, string role) :base(cnp,name,surname,gender){
            this.employeeId = employeeId;
            this.role = role;
        }
        public Employee(string linieFisier) : base(linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            employeeId = Convert.ToInt32(dateFisier[ID]);
            role = dateFisier[ROLE];
        }

        public override string ConversieLaSir_PentruFisier()
        {
            string baseString = base.ConversieLaSir_PentruFisier();
            string objForFile = string.Format(
                "{2}{0}{1}{3}{0}",
                SEPARATOR_PRINCIPAL_FISIER,baseString,employeeId,role
                );
            return objForFile;
        }

        public override string Info()
        {
            string baseInfo= base.Info();
            string info = string.Format("IdAngajat:{1} ,{0} ,Role:{2}",
               baseInfo.ToString(),
               (employeeId.ToString() ?? " NECUNOSCUT "),
               (role ?? " NECUNOSCUT "));

            return info;

        }

        public void SetIdEmployee(int idEmployee)
        {
            this.employeeId = idEmployee;
        }
    }


}
