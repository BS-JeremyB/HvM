namespace HeroesVsMonsters.Characters.Monsters
{
    public class Wolf : Monster
    {

        public Wolf(int yPos, int xPos, int pelt, string race = "le Loup", string referenceCombat = "au Loup", int frc = 0, int end = 0, int pv = 0) : base(yPos, xPos, race, referenceCombat, frc, end, pv)
        {
            Pelt = pelt;
        }


        public int Pelt { get; set; }


    }

}
