using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animaux = new List<Animal>();

            Loup loup = new Loup("Loulou", 12);
            Lion lion = new Lion("Lili", 17);
            Vache vache = new Vache("Vava", 8);
            Cheval cheval = new Cheval("Cheche", 10);

            animaux.Add(loup);
            animaux.Add(lion);
            animaux.Add(vache);
            animaux.Add(cheval);

            foreach (Animal animal in animaux)
            {
                if (animal is Carnivore)
                {
                    Carnivore c = (Carnivore)animal;
                    Console.WriteLine("ICI UN CARNIVORE");
                }

                if (animal.GetType() == typeof(Herbivore))
                {
                    Console.WriteLine("ICI UN Herbivore");
                }
                animal.Crier();
                animal.Manger();
            }



        }
    }
}
