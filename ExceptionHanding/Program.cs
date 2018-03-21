using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHanding
{
    class Program
    {
        static void Main(string[] args)
        {
           try
            {
                Process(10, 0);
            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
        public static void Process(int a, int b)
        {
            try
            {
                Calculation.Divide(10, 0);
            }
            catch (DivideByZeroException exp)
            {
                throw;
            }
            catch (Exception exp)
            {
                throw;
            }
        }
        
    }
}
