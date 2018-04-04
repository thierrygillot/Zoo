using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Vache
    {
        public string nom;
        private int age;

        public double Poids { get; set; }
        private string race;

        public string Race
        {
            get { return race; }
            set
            {
                if (value != "")
                {
                    race = value;
                }
            }
        }
       
        public Vache() { }

        public Vache(string nom, int age) {
            this.nom = nom;
            SetAge(age);
        }

        public void Crier() {
            Console.WriteLine(nom + " fait le cri de la vache");
        }

        public int Crier(Vache vache) {
            Console.WriteLine(nom + " crie sur " + vache.nom);
            return 0;
        }

        public void SetAge(int age)
        {
            if (age >= 0)
            {
                this.age = age;
            }       
        }

        public int GetAge()
        {
            return this.age;
        }
        public static double operator +(Vache vache1,
           Vache vache2)
        {
            return vache1.Poids + vache2.Poids;
        }
        public override string ToString()
        {
            //return "Nom : " + nom + " | age : " + age;
                
            StringBuilder sb = new StringBuilder("Nom : ");
            sb.Append(nom);
            sb.Append(" | age : ");
            sb.Append(age);
            return sb.ToString();
        }
    }
}
