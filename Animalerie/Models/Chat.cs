using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animalerie.Utils;

namespace Animalerie.Models
{
    class Chat : Animal
    {
        public YesNo GriffesCoupees { get; set; }
        public Poils Poils { get; set; }
        public Caractere Caractere { get; set; }

        public Chat()
        {
            RisqueDeces = 5;
            Cri = "Miaouuuu Rrrrrrrrrrroooonnronronronnnn";
        }

        public override string Crier()
        {
            return Cri;
        }
    }
}
