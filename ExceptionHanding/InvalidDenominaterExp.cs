using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHanding
{
    public class InvalidDenominaterExp:ApplicationException
    {
        public InvalidDenominaterExp() : base()
        {

        }
        public InvalidDenominaterExp(string message) : base(message) { }

        public InvalidDenominaterExp(string message, Exception innerException): base (message, innerException) { }
        
        public InvalidDenominaterExp(int denominator,string message) : base(message) { } 
    }
}
