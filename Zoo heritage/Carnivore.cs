using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_heritage
{
    abstract class Carnivore : Animal
    {
        public Carnivore(string nom, int age)
            : base(nom, age) { }

        public override void Manger()
        {
            Console.WriteLine("Miam miam de la viande");
        }       
    }

    abstract class Herbivore : Animal
    {
        public Herbivore(string nom, int age)
            : base(nom, age) { }

        public override void Manger()
        {
            Console.WriteLine("Miam miam de l'herbe");
        }
    }
}
