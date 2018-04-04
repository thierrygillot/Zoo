using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entreprise
{
    class Client : Personne
    {
        public string NumCli { get; set; }

        public Client(string numCli, string nom, string prenom)
            : base(nom, prenom)
        {
            Console.WriteLine("ICI constructeur de client");
            NumCli = numCli;
        }

        public override void SePresenter()
        {
            Console.WriteLine("numéro : " + NumCli);
        }

        public override void Rouler()
        {
            Console.WriteLine("Vroum vroum, je suis en voiture");
        }
    }
}
