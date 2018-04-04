using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animalerie.Utils;

namespace Animalerie.Models
{
    class Piou : Animal
    {
        public Plumes CouleurPlumes { get; set; }
        public EspaceDeVie Espace { get; set; }

        public Piou()
        {
            RisqueDeces = 30;
            Cri = "Cui cui cuisiiiine Dooovyyy";
        }

        public override string Crier()
        {
            return Cri;
        }
    }
}
