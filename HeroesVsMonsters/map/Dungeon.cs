namespace HeroesVsMonsters.map
{
    public static class Dungeon
    {
        public static object[,] GetMap()
        {
            object[,] board = new object[15, 15];
            Console.WriteLine("\n   ┌───────────────────────────────────────────────────────────┐");
            for (int row = 0; row < 15; row++)
            {
                Console.Write("   |");
                for (int column = 0; column < 15; column++)
                {
                        Console.Write("   |");
                }
                Console.WriteLine();
                if (row < 14)
                {
                    Console.WriteLine("   ├───├───├───├───├───├───├───├───├───├───├───├───├───├───├───┤");
                }
                else
                {
                    Console.WriteLine("   └───────────────────────────────────────────────────────────┘");

                }
            }
            return board;
        }   
    }
}
