using HeroesVsMonsters.Characters;
using HeroesVsMonsters.Characters.Heroes;
using HeroesVsMonsters.Characters.Monsters;

namespace HeroesVsMonsters.Actions
{
    public static class Creation
    {
        public static Hero CreationHero()
        {
            int hero;
            do
            {
                Console.Clear();

                Console.WriteLine($"1. Guerrier Nain : Ce guerrier robuste et endurant est membre de la race des nains. \r\nAvec un bonus de +2 en endurance, il est capable de résister à de grandes blessures et de continuer à se battre avec détermination. \r\nSa petite taille et sa force surprenante le rendent redoutable au combat au corps à corps.");
                Console.WriteLine($"\n2. Guerrier Humain : Ce guerrier agile et fort est membre de la race humaine. \r\nAvec un bonus de +1 en force et +1 en endurance, il est capable de frapper avec puissance et de résister à de lourdes blessures. \r\nSa capacité à utiliser une grande variété d'armes et de tactiques le rend polyvalent sur le champ de bataille.   ");
                Console.Write("\n\nFaites votre selection \n" +
                    "(1) pour créer un Guerrier Nain\n" +
                    "(2) pour créer un Guerrier Humain\n\n");
                Console.Write(" Votre selection : ");


            } while (!int.TryParse(Console.ReadLine(), out hero) || (hero != 1 && hero != 2));

            Console.Clear();

            if (hero == 1)
            {
                Console.Write("Votre Guerrier Nain s'appel  : ");
                Dwarf player = new Dwarf(7,0,0,0,Console.ReadLine(),3);
                Console.Clear();
                return player;
                
            }
            else
            {
                Console.Write("Votre Guerrier Humain s'appel  : ");
                Human player = new Human(7, 0, 0, 0, Console.ReadLine(), 3);
                Console.Clear();
                return player;
                
            }
        }

        public static List<Monster> CreationMonsters()
        {

            List<Monster> monsters = new List<Monster>();

            Orc orc1 = new Orc(0,0,DiceRoller.Roll(6,4));
            Orc orc2 = new Orc(0, 0, DiceRoller.Roll(6, 4));
            Orc orc3 = new Orc(0, 0, DiceRoller.Roll(6, 4)); ;
            Orc orc4 = new Orc(0, 0, DiceRoller.Roll(6, 4));

            Wolf wolf1 = new Wolf(0,0,DiceRoller.Roll(4, 1));
            Wolf wolf2 = new Wolf(0, 0, DiceRoller.Roll(4, 1));
            Wolf wolf3 = new Wolf(0, 0, DiceRoller.Roll(4, 1));

            Whelp whelp1 = new Whelp(0,0,DiceRoller.Roll(6, 4), DiceRoller.Roll(4, 1));
            Whelp whelp2 = new Whelp(0, 0, DiceRoller.Roll(6, 4), DiceRoller.Roll(4, 1));
            Whelp whelp3 = new Whelp(0, 0, DiceRoller.Roll(6, 4), DiceRoller.Roll(4, 1));

            monsters.Add(orc1);
            monsters.Add(orc2);
            monsters.Add(orc3);
            monsters.Add(orc4);
            monsters.Add(wolf1);
            monsters.Add(wolf2);
            monsters.Add(wolf3);
            monsters.Add(whelp1);
            monsters.Add(whelp2);
            monsters.Add(whelp3);

            return monsters;
        }
    }
}
