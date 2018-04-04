using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexor
{
    class Program
    {
        static void Main(string[] args)
        {
            Rue r = new Rue();
            Personne p1 = new Personne()
            {
                Prenom = "Julio",
                Nom = "Iglesias"
            };
            Personne p2 = new Personne()
            {
                Prenom = "Enrique",
                Nom = "AimeLesGlaces"
            };
            Personne p3 = new Personne()
            {
                Prenom = "Eros",
                Nom = "RamasseTesOutils"
            };
            Personne p4 = new Personne()
            {
                Prenom = "Eros",
                Nom = "AimeLesGlaces"
            };

            r.AddPersonToStreet(p1, p2, p3, p1,p4);

            //p4 ==> NOPE Duplicate Key... alternative?

            Console.ReadKey();
            Personne pr = r["Toto"];
            Personne pr2 = new Indexor.Personne();
            r.PeopleInTheStreet.TryGetValue("Totot", out pr2);
            if(pr!=null)
            Console.WriteLine($"{pr.Prenom} {pr.Nom} à été récupéré dans la rue...");
            else Console.WriteLine("Personne non trouvée");
            Console.ReadKey();
        }
    }

    class Rue
    {
        public Dictionary<string,Personne> PeopleInTheStreet { get; set; }
        public Personne this[string Name]
        {
            get
            {
                Personne p = new Personne();
                PeopleInTheStreet.TryGetValue(Name, out p);
                return p;
            }
        }

        public void AddPersonToStreet(params Personne[] persons)
        {
            foreach (Personne added in persons)
            {
                if (PeopleInTheStreet==null) PeopleInTheStreet = new Dictionary<string, Personne>();
                Personne p = new Personne();
                PeopleInTheStreet.TryGetValue(added.Nom, out p);
                if (p == null)
                {
                    PeopleInTheStreet.Add(added.Nom, added);
                    Console.WriteLine($"{added.Prenom} {added.Nom} a été placé dans la rue wesh!");
                }
                else Console.WriteLine($"{added.Prenom} {added.Nom} est déja dans la rue wesh!");
            }
        }
    }

    class Personne
    {
        public string Prenom { get; set; }
        public string Nom { get; set; }
    }
}
