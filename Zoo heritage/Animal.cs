using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_heritage
{
    abstract class Animal
    {
        public string Nom { get; set; }
        public int Age { get; set; }

        public Animal()
        {
        }

        public Animal(string nom, int age)
        {
            Nom = nom;
            Age = age;
        }

        public virtual void Crier()
        {
            Console.Write(Nom + " ");
        }

        public abstract void Manger();
    }
}
