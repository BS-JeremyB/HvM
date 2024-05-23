using System.Media;

namespace HeroesVsMonsters.Gameplay
{
    public static class Intro
    {
        public static void GetIntro()
        {

            SoundPlayer audioLogo = new SoundPlayer();
            audioLogo.SoundLocation = @"C:\Users\BStorm\Documents\ressources\Desktop\HeroesVsMonsters\HeroesVsMonsters\Sound\intro.wav";
            SoundPlayer audioIntro = new SoundPlayer();
            audioIntro.SoundLocation = @"C:\Users\BStorm\Documents\ressources\Desktop\HeroesVsMonsters\HeroesVsMonsters\Sound\music.wav";

            audioLogo.Play();
            Console.WriteLine($"                █████   ███████████████ ███████████     ███████   ██████████  █████████                 \r\n               ░░███   ░░███░░███░░░░░█░░███░░░░░███  ███░░░░░███░░███░░░░░█ ███░░░░░███                \r\n                ░███    ░███ ░███  █ ░  ░███    ░███ ███     ░░███░███  █ ░ ░███    ░░░                 \r\n                ░███████████ ░██████    ░██████████ ░███      ░███░██████   ░░█████████                 \r\n                ░███░░░░░███ ░███░░█    ░███░░░░░███░███      ░███░███░░█    ░░░░░░░░███                \r\n                ░███    ░███ ░███ ░   █ ░███    ░███░░███     ███ ░███ ░   █ ███    ░███                \r\n                █████   ███████████████ █████   █████░░░███████░  ██████████░░█████████                 \r\n               ░░░░░   ░░░░░░░░░░░░░░░ ░░░░░   ░░░░░   ░░░░░░░   ░░░░░░░░░░  ░░░░░░░░░                  \r\n                                        █████   █████ █████████                                         \r\n                                       ░░███   ░░███ ███░░░░░███                                        \r\n                                        ░███    ░███░███    ░░░                                         \r\n                                        ░███    ░███░░█████████                                         \r\n                                        ░░███   ███  ░░░░░░░░███                                        \r\n                                         ░░░█████░   ███    ░███                                        \r\n                                           ░░███    ░░█████████                                         \r\n                                            ░░░      ░░░░░░░░░                                          \r\n ██████   ██████   ███████   ██████   █████  █████████  ███████████ ██████████ ███████████    █████████ \r\n░░██████ ██████  ███░░░░░███░░██████ ░░███  ███░░░░░███░█░░░███░░░█░░███░░░░░█░░███░░░░░███  ███░░░░░███\r\n ░███░█████░███ ███     ░░███░███░███ ░███ ░███    ░░░ ░   ░███  ░  ░███  █ ░  ░███    ░███ ░███    ░░░ \r\n ░███░░███ ░███░███      ░███░███░░███░███ ░░█████████     ░███     ░██████    ░██████████  ░░█████████ \r\n ░███ ░░░  ░███░███      ░███░███ ░░██████  ░░░░░░░░███    ░███     ░███░░█    ░███░░░░░███  ░░░░░░░░███\r\n ░███      ░███░░███     ███ ░███  ░░█████  ███    ░███    ░███     ░███ ░   █ ░███    ░███  ███    ░███\r\n █████     █████░░░███████░  █████  ░░█████░░█████████     █████    ██████████ █████   █████░░█████████ \r\n░░░░░     ░░░░░   ░░░░░░░   ░░░░░    ░░░░░  ░░░░░░░░░     ░░░░░    ░░░░░░░░░░ ░░░░░   ░░░░░  ░░░░░░░░░  ");
            Console.ReadLine();
            audioLogo.Stop();

            Console.Clear();
            audioIntro.PlayLooping();
            Console.WriteLine($"Bienvenue dans la forêt enchantée de Shorewood, située dans le pays de Stormwall. \r\nDans cette forêt, un combat féroce a lieu entre les héros et les monstres. \r\nNotre tâche est de redonner vie à cette forêt et de ramener la prosperité dans ce pays.\r\n\r\nDans ce monde, il y a deux familles de personnages : les héros (Humains ou Nains) et les monstres (Loups, Orques ou Dragonnets). \r\nChaque personnage a des caractéristiques différentes, telles que l'Endurance (End), la Force (For) et les Points de Vie (PV). \r\nCes caractéristiques sont déterminées lors de la création du personnage, en utilisant un combinaison de lancers de dés.\r\n\r\nLes héros et les monstres de Shorewood se battent constamment pour la domination, en utilisant leurs capacités et caractéristiques uniques pour vaincre leurs ennemis. \r\nC'est à vous, Héro de ce monde, de décider de l'issue de ces combats et de façonner le destin de la forêt. \r\n");
            Console.Write("Appuyer sur une touche pour continuer");
            Console.ReadLine();
            audioIntro.Stop();

            //do
            //{
            //Console.Clear();

            //Console.WriteLine($"1. Guerrier Nain : Ce guerrier robuste et endurant est membre de la race des nains. \r\nAvec un bonus de +2 en endurance, il est capable de résister à de grandes blessures et de continuer à se battre avec détermination. \r\nSa petite taille et sa force surprenante le rendent redoutable au combat au corps à corps.");
            //Console.WriteLine($"\n2. Guerrier Humain : Ce guerrier agile et fort est membre de la race humaine. \r\nAvec un bonus de +1 en force et +1 en endurance, il est capable de frapper avec puissance et de résister à de lourdes blessures. \r\nSa capacité à utiliser une grande variété d'armes et de tactiques le rend polyvalent sur le champ de bataille.   ");
            //Console.Write("\n\nFaites votre selection \n" +
            //    "(1) pour créer un Guerrier Nain\n" +
            //    "(2) pour créer un Guerrier Humain\n\n");
            //Console.Write(" Votre selection : ");


            //} while (!int.TryParse(Console.ReadLine(), out choice ) || (choice != 1 && choice != 2));
            //Console.Clear();

            //return choice;
        }
    }
}
