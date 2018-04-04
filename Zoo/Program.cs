using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{



    class Program
    {
        static void Main(string[] args)
        {
            Vache vache = new Vache();

            vache.SetAge(15);
            Console.WriteLine(vache.GetAge());
            vache.SetAge(-1);
            Console.WriteLine(vache.GetAge());
            vache.Race = "Normande";
            Console.WriteLine(vache.Race);
            vache.Poids = 150;
            vache.nom = "Belinda";
            Vache vache2 = new Vache("Bernadette", 3);
            vache2.Poids = 200;

            double totalViande = vache.Poids + vache2.Poids;

            Console.WriteLine(vache2);

            vache2.Crier();

            vache2.Crier(vache);
            

            Zoo zoo = new Zoo();

            zoo.vaches.Add(vache);
            zoo.vaches.Add(new Vache("Kiri", 20));
            zoo.vaches.Add(vache2);
            

            for (int i =0; i < zoo.vaches.Count; i++)
            {
                //Console.WriteLine(elemVache.ToString());
                Vache elemVache = zoo.vaches[i];
                if (elemVache.GetAge() >= 10)
                {
                    zoo.vaches.Remove(elemVache);
                    i--;
                }
            }

            foreach (Vache item in zoo.vaches)
            {
                Console.WriteLine(item);
            }

            int age = vache.GetAge();
            age = 7;
            Console.WriteLine(vache.GetAge());

            Vache copieVache = vache;
            copieVache.SetAge(25);
            Console.WriteLine(vache.GetAge());
        }
    }
}
