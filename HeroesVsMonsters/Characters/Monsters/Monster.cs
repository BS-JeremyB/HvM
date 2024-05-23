namespace HeroesVsMonsters.Characters.Monsters
{
    public class Monster : Character
    {
        public Monster(int yPos, int xPos, string race, string referenceCombat, int frc, int end, int pv) : base(yPos, xPos, frc, end, pv)
        {
            Race = race;
            ReferenceCombat = referenceCombat;
        }

        private string _Race;
        private string _ReferenceCombat;

        public string Race { get; set; }
        public string ReferenceCombat { get; set; }
    }
}
