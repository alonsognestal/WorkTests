using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public static class StaticCalculator
    {
        public static int StaticSum(int operator1, int operator2)
        {
            return (operator1 + operator2);
        }
        public static int StaticMultiplicator(int operator1, int operator2)
        {
            return (operator1 * operator2);
        }
    }

    public class Calculator
    {
        private int operator1 { get; set; }
        private int operator2 { get; set; }

        public Calculator(int value1, int value2)
        {
            operator1 = value1;
            operator2 = value2;
        }

        public int Sum()
        {
            return operator1 + operator2;
        }
        public int Multiplicator()
        {
            return operator1 * operator2;
        }

        public float Division()
        {
            try
            {
                return (float)operator1 / (float)operator2;
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("What the fuck");
                return 0;
            }
            
        }

        
    }
    public static class Extensions
    {
        public static string TwoDecimals(this float number)
        {
            return (number.ToString("0.00"));
        }
    }
}
