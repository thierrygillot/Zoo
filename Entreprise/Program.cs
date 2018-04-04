using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entreprise
{
    class Program
    {
        static void Main(string[] args)
        {
            Client cli = new Client("00458684", "Marl", "Bob");
            cli.SePresenter();
            cli.Rouler();
        }
    }
}
