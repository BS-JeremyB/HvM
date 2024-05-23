namespace HeroesVsMonsters.Actions
{
    public static class DiceRoller
    {

        public static int Roll(int side, int tryNbr)
        {
            List<int> rolls = new List<int>();
            Random rand = new Random();

            for(int i = 0; i < tryNbr; i++)
            {
                rolls.Add(rand.Next(1, side));
            }

            
            if (tryNbr == 1)
            {
                return rolls[0];
            }

            return rolls.OrderByDescending(x => x).Take(tryNbr-1).Sum();
        }

    }
}
