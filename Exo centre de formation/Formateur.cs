using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_centre_de_formation
{
    class Formateur : Personne
    {
        // Ici, le formateur ne connait pas les formations qu'il donne
        public string NomEntreprise { get; set; }

        public Formateur()
        {

        }

        public Formateur(string nom, string prenom, string nomEntreprise)
            : base(nom, prenom)
        {
            NomEntreprise = nomEntreprise;
        }

    }
}
