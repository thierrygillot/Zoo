using Animalerie.Models;
using Animalerie.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Animalerie.Utils.Tools;

namespace Animalerie.Core
{
    class Animalerie
    {
        private List<Animal> list { get; set; }
        private static int x = 5;
        private static int y = 5;
        public Animalerie()
        {
            list = new List<Animal>();
            Start();
        }
        private void Init()
        {
            Animated(5, y++, 5, $"╔════════════════════════════╗");
            Animated(5, y++, 5, $"║  Bienvenue à l'Animalerie  ║");
            Animated(5, y++, 5, $"╚════════════════════════════╝");
            Continue(5, y, 5);
        }
        private ConsoleKey Menu(bool byPass=false)
        {
            Console.Clear();
            x = 5;
            y = 5;

            Animated(x, y++, 5, $"╔════════════════════════════╗");
            Animated(x, y++, 5, $"║         M  E  N  U         ║");
            Animated(x, y++, 5, $"╠════════════════════════════╣");
            Animated(x, y++, 5, $"║ 1. Encoder un animal       ║");
            Animated(x, y++, 5, $"║ 2. Afficher les animaux    ║");
            Animated(x, y++, 5, $"║ 3. Faire passer le temps   ║");
            Animated(x, y++, 5, $"║ 4. Faire les comptes       ║");
            Animated(x, y++, 5, $"║ 5. Quitter                 ║");
            Animated(x, y++, 5, $"╚════════════════════════════╝");

            if (!byPass)
            {
                Animated(x, y++, 5, "Faites un choix : ");
                ConsoleKey response = Console.ReadKey().Key;
                return response;
            }

            return ConsoleKey.A;
        }
        private ConsoleKey SubMenu()
        {
            x = 35;
            y = 8;

            Animated(x, y++, 5, $"╔════════════════════════════╗");
            Animated(x, y++, 5, $"║      Encoder un Animal     ║");
            Animated(x, y++, 5, $"╠════════════════════════════╣");
            Animated(x, y++, 5, $"║ 1. Encoder un Chien        ║");
            Animated(x, y++, 5, $"║ 2. Encoder un Chat         ║");
            Animated(x, y++, 5, $"║ 3. Encoder un Oiseau       ║");
            Animated(x, y++, 5, $"║ 4. Retour                  ║");
            Animated(x, y++, 5, $"╚════════════════════════════╝");
            Animated(x, y++, 5, "Faites un choix : ");

            ConsoleKey response = Console.ReadKey().Key;
            return response;
        }
        private void Start()
        {
            ConsoleKey choice = ConsoleKey.A;
            Init();
            do
            {
                choice = Menu();
                switch (choice)
                {
                    case ConsoleKey.NumPad1:
                        do
                        {
                            choice = SubMenu();
                            switch(choice)
                            {
                                case ConsoleKey.NumPad1:
                                    list.Add(EncoderChien());
                                    Menu(true);
                                break;
                                case ConsoleKey.NumPad2:
                                    list.Add(EncoderChat());
                                    Menu(true);
                                    break;
                                case ConsoleKey.NumPad3:
                                    list.Add(EncoderOiseau());
                                    Menu(true);
                                    break; 
                                case ConsoleKey.NumPad4:
                                    RemoveSquare(x, Console.BufferWidth, 0, ++y, "Press a Key to Continue");
                                    break;
                                default:
                                    Animated(x, y++, 5, "Choix Incorrect!");
                                    RemoveSquare(x,Console.BufferWidth, 0, ++y, "Press a Key to Continue");
                                 break;

                            }
                        } while (choice != ConsoleKey.NumPad4);
                        break;
                    case ConsoleKey.NumPad2: AfficherLesAnimaux(); break;
                    case ConsoleKey.NumPad3: FairePasserLeTemps(); break;
                    case ConsoleKey.NumPad4: FaireLesComptes(); break;
                    case ConsoleKey.NumPad5:
                        Animated(x, y++, 5, "A la prochaine...");
                        Continue(x, y, 5);
                        break;
                    default:
                        Animated(x, y++, 5, "Choix Incorrect!");
                        Continue(x, y, 5);
                        break;
                }
            } while (choice != ConsoleKey.NumPad5);
        }
        private void FaireLesComptes()
        {
            Console.Clear();
            x = 5;
            y = 5;

            Animated(x, y++, 5, $"╔════════════════════════════╗");
            Animated(x, y++, 5, $"║     Faisons les Comptes    ║");
            Animated(x, y++, 5, $"╠════════════════════════════╣");
            Animated(x, y++, 5, $"║ Nombre de Chiens: {list.Where(x => x is Chien && !x.IsDead).Count().ToString("D2")}       ║");
            Animated(x, y++, 5, $"║ Nombre de Chats:  {list.Where(x => x is Chat && !x.IsDead).Count().ToString("D2")}       ║");
            Animated(x, y++, 5, $"║ Nombre de Pious:  {list.Where(x => x is Piou && !x.IsDead).Count().ToString("D2")}       ║");
            Animated(x, y++, 5, $"╚════════════════════════════╝");
            Continue(x, y, 5);
        }
        private void FairePasserLeTemps()
        {
            Console.Clear();
            x = 5;
            y = 5;

            Animated(x, y++, 5, $"╔═══════════════════╗");
            Animated(x, y++, 5, $"║ Le temps passe... ║");
            Animated(x, y++, 5, $"╚═══════════════════╝");

            Animated(x, y++, 5, "-------------------------------");
            List<Animal> unDead = list.Where(x => !x.IsDead).ToList();
            if (unDead.Count > 0)
            {
                foreach (Animal a in unDead)
                {
                    a.CheckIfIsDead();
                }

                List<Animal> Dead = unDead.Where(x => x.IsNewDead).ToList();

                if (Dead.Count > 0)
                {
                    foreach (Animal a in Dead)
                    {
                        a.IsNewDead = false;
                        Animated(x, y++, 5, $"{a.Nom} is dead during the night...RIP");
                    }
                }
                else Animated(x, y++, 5, "Joy and Love!! Everybody's alive!!!");
            }
            else Animated(x, y++, 5, "Nothing to display baby!");
            Animated(x, y++, 5, "-------------------------------");
            Continue(x, y, 5);
        }
        private void AfficherLesAnimaux()
        {
            Console.Clear();
            x = 5;
            y = 5;

            Animated(x, y++, 5, $"╔══════════════════════════════════╗");
            Animated(x, y++, 5, $"║ Affichage des forces en présence ║");
            Animated(x, y++, 5, $"╚══════════════════════════════════╝");

            Animated(x, y++, 5, "-------------------------------");
            List<Animal> alives = list.Where(x => !x.IsDead).ToList();
            if (alives.Count > 0)
            {
                foreach (Animal a in list)
                {
                    Animated(x, y++, 5, a.ToString());
                }
            }
            else Animated(x, y++, 5, "Nothing to display baby!");
            Animated(x, y++, 5, "-------------------------------");
            Continue(x, y, 5);
        }
        private void EncoderAnimalData(Animal a)
        {
            Console.Clear();
            x = 5;
            y = 5;

            string type = a.GetType().Name;

            Animated(x, y++, 5, $"╔═══════════════════════╗");
            Animated(x, y++, 5, $"║ Encodage d'un {type.PadLeft(5)}   ║");
            Animated(x, y++, 5, $"╚═══════════════════════╝");
            a.Nom = ReadString(x, y++, 5, $"Quel est le nom du petit {type} : ");
            a.Sexe = (Sexes)Enum.Parse(typeof(Sexes), EnumToMenu(x, ref y, 5, $"Sexe du petit {type.PadLeft(5)}", typeof(Sexes)).ToString());
            a.Poids = ReadNumber(x,y++,5, $"Quel est le poids du petit {type} : ");
            a.Taille = ReadNumber(x, y++, 5, $"Quel est la taille du petit {type} : ");
            a.Age = (int)ReadNumber(x, y++, 5, $"Quel est l'age du petit {type} : ");
            a.DateArrive = DateTime.Now;
        }
        private Animal EncoderChien()
        {
            Chien a = new Chien();
            EncoderAnimalData(a);
            a.Collier = (Color)Enum.Parse(typeof(Color), EnumToMenu(x, ref y, 5, $"Collier de {a.Nom}", typeof(Color)).ToString());
            a.EstDresse = (YesNo)Enum.Parse(typeof(YesNo), EnumToMenu(x, ref y, 5, $"Est ce que {a.Nom} est dressé", typeof(YesNo)).ToString());
            a.Race = ReadString(x, y++, 5, $"De quelle race est {a.Nom} : ");
            Animated(x, y++, 5, $"Regardez comme {a.Nom} est heureux...{a.Crier()}");
            Continue(x, y, 5);
            return a;
        }
        private Animal EncoderChat()
        {
            Chat a = new Chat();
            EncoderAnimalData(a);
            a.Poils = (Poils)Enum.Parse(typeof(Poils), EnumToMenu(x, ref y, 5, $"Pelage de {a.Nom}", typeof(Poils)).ToString());
            a.GriffesCoupees = (YesNo)Enum.Parse(typeof(YesNo), EnumToMenu(x, ref y, 5, $"Est ce que {a.Nom.PadLeft(10)} a coupé ses griffes", typeof(YesNo)).ToString());
            a.Caractere = (Caractere)Enum.Parse(typeof(Caractere), EnumToMenu(x, ref y, 5, $"Qu'est ce qui défini {a.Nom}", typeof(Caractere)).ToString());
            Animated(x, y++, 5, $"Regardez comme {a.Nom} est heureux...{a.Crier()}");
            Continue(x, y, 5);
            return a;
        }
        private Animal EncoderOiseau()
        {
            Piou a = new Piou();
            EncoderAnimalData(a);
            a.Espace = (EspaceDeVie)Enum.Parse(typeof(EspaceDeVie), EnumToMenu(x, ref y, 5, $"Où doit vivre {a.Nom}", typeof(EspaceDeVie)).ToString());
            a.CouleurPlumes = (Plumes)Enum.Parse(typeof(Plumes), EnumToMenu(x, ref y, 5, $"Couleur des plumes de {a.Nom}", typeof(Plumes)).ToString());
            Animated(x, y++, 5, $"Regardez comme {a.Nom} est heureux...{a.Crier()}");
            Continue(x, y, 5);
            return a;
        }
    }
}
