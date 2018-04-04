using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_centre_de_formation
{
    class Participant : Personne
    {
        public List<Formation> Formations { get; set; }

        public Participant()
        {
            Formations = new List<Formation>();
        }

        public Participant(string nom, string prenom)
            : base(nom, prenom)
        {
            Formations = new List<Formation>();
        }

        public void AddFormations(params Formation[] formations)
        {
            foreach (Formation form in formations)
            {
                Formations.Add(form);
                // Nous devons maintenant faire le lien de l'autre coté 
                form.Participants.Add(this);
                // Attention, si vous appelez ici la méthode "AddParticipants", vous aurez
                // une boucle infinie. Une condition sera alors nécessaire afin de l'éviter
            }
        }
    }
}
