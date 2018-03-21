using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHanding
{
    public class Calculation
    {
        public static int Divide(int a, int b)
        {
            int retValue = 0;
            if (b > a)
                throw new Exception("The value should be grater than a");

            retValue = a / b;
            return retValue;
        }
    }
}
