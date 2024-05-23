namespace HeroesVsMonsters.Characters.Heroes
{
    public class Hero : Character
    {
        public Hero(int yPos, int xPos, int gold, int pelt, string name, int life, int frc, int end, int pv) : base(yPos, xPos, frc, end, pv)
        {
            Gold = gold;
            Pelt = pelt;
            Name = name;
            Life = life;
        }

        public int Gold { get; set; }
        public int Pelt { get; set; }
        public string Name { get; set; }
        public int Life { get; set; }
    }
}
