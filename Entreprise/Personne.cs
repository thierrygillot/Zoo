using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entreprise
{
    abstract class Personne
    {
        // PROPERTIES
        public string Nom { get; set; }
        public string Prenom { get; set; }

        // CONSTRUCTORS
        public Personne(string nom, string prenom)
        {
            Console.WriteLine("ICI constructeur de personne");
            Nom = nom;
            Prenom = prenom;
        }
        // METHODS
        public virtual void SePresenter() {
            Console.WriteLine("Je m'appelle " + Nom + " " + Prenom);
        }

        public abstract void Rouler();
    }
}
