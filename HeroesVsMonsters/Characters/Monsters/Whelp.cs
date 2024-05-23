namespace HeroesVsMonsters.Characters.Monsters
{
    public class Whelp : Monster
    {
        public Whelp(int yPos, int xPos, int gold,int pelt, string race = "le Dragonnet", string referenceCombat = "au Dragonnet", int frc = 0, int end = 1, int pv = 0) : base(yPos, xPos, race, referenceCombat, frc, end, pv)
        {
            Gold = gold;
            Pelt = pelt;
        }


        public int Gold { get; set; }
        public int Pelt { get; set; }


    }
}

