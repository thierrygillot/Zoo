using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria_polymorphisme
{
    class Margeritha
    {
        public double QuantiteFromage { get; set; }
        public double QuantiteSauceTomate { get; set; }
        public double QuantitePate { get; set; }
    }

    class Hawai : Margeritha {
        public double QuantiteJambon { get; set; }
        public double QuantiteAnanas { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Margeritha marg = new Margeritha();

            Hawai hawai = new Hawai();
            hawai.QuantiteJambon = 7;
            Console.WriteLine(hawai.QuantiteJambon);
            Margeritha hawaiTransformee = hawai;
            

            Hawai newHawai = (Hawai)hawaiTransformee;
            Console.WriteLine(newHawai.QuantiteJambon);

            Hawai h2 = (Hawai)marg;


        }
    }
}
