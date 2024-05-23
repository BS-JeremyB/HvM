using HeroesVsMonsters.Characters;
using HeroesVsMonsters.Characters.Heroes;
using HeroesVsMonsters.Characters.Monsters;
using System.Media;
using VisioForge.Libs.NAudio.Wave;

namespace HeroesVsMonsters.Gameplay
{

    public static class Movement
    {

        public static Monster Screenplay(object[,] board, Hero player)
        {

            SoundPlayer audioAmbience = new SoundPlayer();
            audioAmbience.SoundLocation = @"C:\Users\BStorm\Documents\ressources\Desktop\HeroesVsMonsters\HeroesVsMonsters\Sound\ambience.wav";
            SoundPlayer audioStep = new SoundPlayer();
            audioStep.SoundLocation = @"C:\Users\BStorm\Documents\ressources\Desktop\HeroesVsMonsters\HeroesVsMonsters\Sound\snow-step-1-81064.wav";

            bool continuer = true;
            int xPosModifier = (player.Xpos * 4) + 4;
            int yPosModifier = (player.Ypos * 2) + 2;

            ConsoleKeyInfo movement;

            board[player.Ypos, player.Xpos] = player;

            Console.ResetColor();

            Console.SetCursorPosition(xPosModifier, yPosModifier);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" H ");

            while (continuer)
            {

                //Console.ResetColor();


                movement = Console.ReadKey(true);

                switch (movement.Key)
                {
                    case ConsoleKey.UpArrow:
                        //Console.WriteLine("En Haut");
                        if (player.Ypos - 1 >= 0 && board[player.Ypos - 1, player.Xpos] == null)
                        {
                            board[player.Ypos, player.Xpos] = null;
                            player.Ypos--;
                            board[player.Ypos, player.Xpos] = player;
                            audioStep.Play();
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        //Console.WriteLine("En Bas");
                        if (player.Ypos + 1 <= 14 && board[player.Ypos + 1, player.Xpos] == null)
                        {
                            board[player.Ypos, player.Xpos] = null;
                            player.Ypos++;
                            board[player.Ypos, player.Xpos] = player;
                            audioStep.Play();
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        //Console.WriteLine("A Gauche");
                        if (player.Xpos - 1 >= 0 && board[player.Ypos, player.Xpos - 1] == null)
                        {
                            board[player.Ypos, player.Xpos] = null;
                            player.Xpos--;
                            board[player.Ypos, player.Xpos] = player;
                            audioStep.Play();
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        //Console.WriteLine("A Droite");
                        if (player.Xpos + 1 <= 14 && board[player.Ypos, player.Xpos + 1] == null)
                        {
                            board[player.Ypos, player.Xpos] = null;
                            player.Xpos++;
                            board[player.Ypos, player.Xpos] = player;
                            audioStep.Play();
                        }
                        break;
                    case ConsoleKey.Escape:
                        continuer = false;
                        break;
                    default:
                        Console.WriteLine("Vous devez vous deplacer avec les fleches");
                        break;
                }
                Console.SetCursorPosition(xPosModifier, yPosModifier);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("   ");

                xPosModifier = (player.Xpos * 4) + 4;
                yPosModifier = (player.Ypos * 2) + 2;

                Console.SetCursorPosition(xPosModifier, yPosModifier);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write(" H ");

                if (player.Ypos != 0 && player.Ypos != 14)
                {

                    if (board[player.Ypos + 1, player.Xpos] != null && (board[player.Ypos + 1, player.Xpos] as Monster).Pv > 0)
                    {

                        return (board[player.Ypos + 1, player.Xpos] as Monster);
                    }
                    else if (board[player.Ypos - 1, player.Xpos] != null && (board[player.Ypos - 1, player.Xpos] as Monster).Pv > 0)
                    {

                        return (board[player.Ypos - 1, player.Xpos] as Monster);

                    }
                }
                if(player.Xpos != 0 && player.Xpos != 14)
                {

                    if (board[player.Ypos, player.Xpos + 1] != null && (board[player.Ypos, player.Xpos + 1] as Monster).Pv > 0)
                    {

                        return (board[player.Ypos, player.Xpos + 1] as Monster);
                    }
                    else if (board[player.Ypos, player.Xpos - 1] != null && (board[player.Ypos, player.Xpos - 1] as Monster).Pv > 0)
                    {

                        return (board[player.Ypos, player.Xpos - 1] as Monster);
                    }
                }

            }
            throw new Exception();
        }
    }
}
