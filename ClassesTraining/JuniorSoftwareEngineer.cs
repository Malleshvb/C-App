using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTraining
{
    public class JuniorSoftwareEngineer:Employee
    {
        public JuniorSoftwareEngineer()
        {
            base.EmployeeType = EmployeeType.JSE;
            base.BaseSalary = 1000;
        }
        public override int CalculateSalary()
        {
            int ta = 1000;
            int hra = 3000;
            int totalSalary = BaseSalary + ta + hra;

            return totalSalary;
        }
    }
}
