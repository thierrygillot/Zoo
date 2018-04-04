using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animalerie.Utils;

namespace Animalerie.Models
{
    abstract class Animal
    {
        public Sexes Sexe { get; set; }
        public string Nom { get; set; }
        public int Age { get; set; }
        public DateTime DateArrive { get; set; }
        public double Taille { get; set; }
        public double Poids { get; set; }
        public int RisqueDeces { get; set; }
        public bool IsDead { get; private set; }
        public bool IsNewDead { get; set; }
        protected string Cri { get; set; }

        private static Random rnd = new Random();
        public abstract string Crier();
        public bool? CheckIfIsDead()
        {
            if (!IsDead)
            {
                int roulette = rnd.Next(0, 1001);
                if (roulette <= RisqueDeces)
                    return IsNewDead = IsDead = true;
                else return IsDead;
            }
            else return null;
        }
        public override string ToString()
        {
            return $"{Nom} est un {this.GetType().Name}, agé de {Age} an(s), arrivé à l'animalerie le {DateArrive.ToString("dd/MM/yyyy")}";
        }
    }
}
