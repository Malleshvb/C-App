using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTraining
{
    public enum EmployeeType
    {
        JSE
            ,SE
            ,ProjectManager
    }
    public abstract class Employee
    {
        private int id;
        private string name;
        EmployeeType employeeType;
        int baseSalary;

        public int EmployeeId
        {
            get
            {
                return id;
            }
            set
            {
                if (value > 0)
                {
                    id = value;
                }
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
            }
        }

        public EmployeeType EmployeeType
        {
            get
            {
                return employeeType;
            }
            protected set
            {
                employeeType = value;
            }
        }
        public int BaseSalary
        {
            get
            {
                return baseSalary;

            }
            protected set
            {
                baseSalary = value;

            }
        }

        public abstract int CalculateSalary();
        
        

    }

}
