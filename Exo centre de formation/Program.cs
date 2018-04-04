using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_centre_de_formation
{
    class Program
    {
        static void Main(string[] args)
        {
            Participant part = new Participant();

            Formation form = new Formation();

            part.AddFormations(form, form, form, form, form);

            Console.WriteLine(part.Formations.Count);
            Console.WriteLine(form.Participants.Count);
            Console.ReadKey();
        }
    }
}
