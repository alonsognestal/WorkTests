using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Program
    {
        /*static void Main(string[] args)
        {
            var cat = new Cat();
            var dog = new Dog();

            WriteAnimalSound(cat);

            Console.ReadLine();
            
        }*/

        static void Main(string[] args)
        {
            
            Calculator calculator = new Calculator(3,1);
           /* int calculatorResultSum = calculator.Sum();

            int staticResult = StaticCalculator.StaticSum(3, 5);

            int calculatorResultMultiplicator = calculator.Multiplicator();

            int staticResultMultiplicator = StaticCalculator.StaticMultiplicator(3, 2);*/

            float calculatorResultDivision = calculator.Division();

            Console.WriteLine(calculatorResultDivision.TwoDecimals()); //Para que siempre muestre dos decimales

            Console.ReadLine();
        }
        public static void WriteAnimalSound(Animal animal)
        {
            Console.WriteLine(animal.MakeSound());
        }
    }
}
