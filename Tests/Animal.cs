using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public interface ISoundable
    {
        string MakeSound(); //no se implementa nunca en la interfaz
    }

    public class Animal
    {
        public virtual string MakeSound()
        {
            return "Something";
        }
    }

    public class Bird : ISoundable //En las interfaces se puede heredar mas de una separadas por coma
    {
        public string MakeSound()
        {
            return "Pio";
        }
    }

    public class Dog : Animal //en las clases solo se puede heredar de una
    {
        public override string MakeSound()
        {
            return "Guau!";
        }
    }

    public class Cat : Animal
    {
        //public override string MakeSound()
        //{
        //    return "Miau!";
        //}
    }
    
}
