using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_centre_de_formation
{
    class Formation
    {
        public string Intitule { get; set; }
        public int Periode { get; set; } // le nombre de jours

        public Formateur Formateur { get; set; }
        public List<Participant> Participants { get; set; } // mettre un dictionary pour gérer les cotes, c'est le plus simple

        // gérer les notes
        public Dictionary<Participant, double> ParticipantsWNote { get; set; }

        public Formation()
        {
            Participants = new List<Participant>();
            ParticipantsWNote = new Dictionary<Participant, double>();
        }

        public Formation(string intitule, int periode):this()
        {
            Intitule = intitule;
            Periode = periode;
        }

        public Formation(string intitule, int periode, Formateur formateur):this()
        {
            Intitule = intitule;
            Periode = periode;
            Formateur = formateur;
        }

        public void AddParticipants(params Participant[] participants)
        {
            foreach (Participant part in participants)
            {
                Participants.Add(part);
                // Nous devons maintenant faire le lien de l'autre coté
                part.Formations.Add(this);
                // Attention, si vous appelez ici la méthode "AddFormations", vous aurez
                // une boucle infinie. Une condition sera alors nécessaire afin de l'éviter

            }
        }

        //Pour info : Itérer sur un KeyValuePair<K,V>
        public void IterateOverDictionary()
        {
            foreach(double entry in ParticipantsWNote.Values)
            {

            }
        }
    }
}
