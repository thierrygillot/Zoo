using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_heritage
{
    class Loup : Carnivore
    {
        public Loup(string nom, int age)
            : base(nom, age) { }

        public override void Crier()
        {
            base.Crier();
            Console.WriteLine("hurle");
        }
    }

    class Lion : Carnivore
    {
        public Lion(string nom, int age)
            : base(nom, age) { }

        public override void Crier()
        {
            Console.WriteLine(Nom + " rugit");
        }
    }

    class Vache : Herbivore
    {
        public Vache(string nom, int age)
            : base(nom, age) { }

        public override void Crier()
        {
            Console.WriteLine(Nom + " meugle");
        }
    }

    class Cheval : Herbivore
    {
        public Cheval(string nom, int age)
            : base(nom, age) { }

        public override void Crier()
        {
            Console.WriteLine(Nom + " hénit");
        }
    }
}
