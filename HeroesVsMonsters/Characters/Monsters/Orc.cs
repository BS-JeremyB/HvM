namespace HeroesVsMonsters.Characters.Monsters
{
    public class Orc : Monster
    {
        public Orc(int yPos, int xPos,int gold, string race = "l'Orc", string referenceCombat = "à l'Orc") : base(yPos, xPos, race, referenceCombat, 1, 0,0)
        {
          Gold = gold;
        }


        public int Gold { get;  set; }

    }
}
