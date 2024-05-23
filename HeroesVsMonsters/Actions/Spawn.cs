using HeroesVsMonsters.Characters;
using HeroesVsMonsters.Characters.Monsters;

namespace HeroesVsMonsters.Actions
{
    public static class Spawn
    {
        public static object[,] GetMonsterSpawn(object[,] board, List<Monster> monsters)
        {
            Random rand = new Random();
            bool NotFree;

            foreach (Character m in monsters)
            {
                do
                {

                    NotFree = false;
                    int row = rand.Next(1, board.GetLength(0) - 2);
                    int col = rand.Next(1, board.GetLength(1) - 2);

                    int limitRowTop = row - 2;
                    int limitRowBottom = row + 3;
                    int limitColLeft = col - 2;
                    int limitColRight = col + 3;


                    if (row == 1)
                    {
                        limitRowTop = row - 1;
                    }
                    else if (row == 13)
                    {
                        limitRowBottom = row + 2;
                    }
                    if (col == 1)
                    {
                        limitColLeft = col - 1;
                    }
                    else if (col == 13)
                    {
                        limitColRight = col + 2;
                    }

                    for (int i = limitRowTop; i < limitRowBottom && !NotFree; i++)
                    {
                        for (int j = limitColLeft; j < limitColRight && !NotFree; j++)
                        {
                            if (board[i, j] != null)
                            {
                                NotFree = true;
                            }
                        }
                    }

                    if (!NotFree )
                    {
                        board[row, col] = m;
                        m.Xpos = col;
                        m.Ypos = row;
                        
                    }
                } while (NotFree);
            }
            return board;
        }
    }
}
