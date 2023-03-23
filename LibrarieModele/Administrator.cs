using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibarieModele
{
    public class Administrator : Employee
    {
        public Administrator(string linieFisier) : base(linieFisier)
        {
        }

        public Administrator(int cnp, string name, string surname, string gender, int employeeId, string category) : base(cnp, name, surname, gender, employeeId, category)
        {
        }
    }
}
