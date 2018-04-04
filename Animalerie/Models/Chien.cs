using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animalerie.Utils;

namespace Animalerie.Models
{
    class Chien : Animal
    {
        public YesNo EstDresse { get; set; }
        public Color Collier { get; set; }
        public string Race { get; set; }

        public Chien()
        {
            Cri = "Wouf Wouf Wouf!!!";
            RisqueDeces = 999;
        }

        public override string Crier()
        {
            return Cri;
        }
    }
}
