﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            JuniorSoftwareEngineer JuniorSoftwareEngg = new JuniorSoftwareEngineer();

            bool isEligible = LoanEligibiltycalculator.IsEmployeeLoanEligible(JuniorSoftwareEngg);



        }
    }
}
