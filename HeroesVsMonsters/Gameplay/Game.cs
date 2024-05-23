using HeroesVsMonsters.Characters;
using HeroesVsMonsters.Characters.Heroes;
using HeroesVsMonsters.Characters.Monsters;
using System.Media;

namespace HeroesVsMonsters.Gameplay
{
    public static class Game
    {

        public static void InGame(Hero player, object[,] board)

        {
            Monster monster;
            int deadEnemy = 0;
            int xPos;
            int yPos;

            SoundPlayer audioVictory = new SoundPlayer();
            audioVictory.SoundLocation = @"C:\Users\BStorm\Documents\ressources\Desktop\HeroesVsMonsters\HeroesVsMonsters\Sound\intro.wav";
            SoundPlayer audioDeath = new SoundPlayer();
            audioDeath.SoundLocation = @"C:\Users\BStorm\Documents\ressources\Desktop\HeroesVsMonsters\HeroesVsMonsters\Sound\defeat.wav";
            SoundPlayer audioIntro = new SoundPlayer();
            audioIntro.SoundLocation = @"C:\Users\BStorm\Documents\ressources\Desktop\HeroesVsMonsters\HeroesVsMonsters\Sound\music.wav";
            SoundPlayer audioOrcEncounter = new SoundPlayer();
            audioOrcEncounter.SoundLocation = @"C:\Users\BStorm\Documents\ressources\Desktop\HeroesVsMonsters\HeroesVsMonsters\Sound\orcencounter.wav";
            SoundPlayer audioWolfEncounter = new SoundPlayer();
            audioWolfEncounter.SoundLocation = @"C:\Users\BStorm\Documents\ressources\Desktop\HeroesVsMonsters\HeroesVsMonsters\Sound\wolfencounter.wav";
            SoundPlayer audioDragonEncounter = new SoundPlayer();
            audioDragonEncounter.SoundLocation = @"C:\Users\BStorm\Documents\ressources\Desktop\HeroesVsMonsters\HeroesVsMonsters\Sound\dragonencounter.wav";





            while (player.Life > 0 && deadEnemy < 10)
            {
                Console.ResetColor();
                int logXPos = 65;
                int logYPos = 2;
                Console.SetCursorPosition(logXPos, logYPos++);
                Console.WriteLine($"{player.Name} | {player.Life} ♥ ");
                Console.SetCursorPosition(logXPos, logYPos++);
                Console.WriteLine($"Stats : Force {player.For} | Endurance {player.End} | Vie {player.Pv}");

                Console.SetCursorPosition(logXPos, logYPos++);
                Console.WriteLine($"Iventaire : Or {player.Gold} | Peau {player.Pelt}");


                monster = Movement.Screenplay(board, player);

                Console.ResetColor();
                Console.SetCursorPosition(logXPos, logYPos += 2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{monster.Race} : Force {monster.For} | Endurance {monster.End} | Vie {monster.Pv}");

                xPos = (monster.Xpos * 4) + 4;
                yPos = (monster.Ypos * 2) + 2;
                Console.SetCursorPosition(xPos, yPos);
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Red;
                if (monster is Wolf)
                {
                    Console.Write($" L ");
                    audioWolfEncounter.Play();
                }
                else if (monster is Orc)
                {
                    Console.Write($" O ");
                    audioOrcEncounter.Play();
                }
                else
                {
                    Console.Write($" D ");
                    audioDragonEncounter.Play();
                }
                Thread.Sleep(4000);



                Console.ResetColor();
                logYPos++;

                int originPv = player.Pv;

                Fight.ELog += Log;
                player.OnDeath += OnCharacterDeath;
                monster.OnDeath += OnCharacterDeath;

                while (player.Pv > 0 && monster.Pv > 0)
                {

                    monster.IsFighting(player, logXPos, logYPos += 2);
                    if (player.Pv <= 0)
                    {
                        Console.SetCursorPosition(logXPos, logYPos += 2);
                        Console.WriteLine($"{monster.Race} à vaincu {player.Name} !");
                        player.Life--;
                        Console.SetCursorPosition(logXPos, logYPos += 2);
                        Console.ReadLine();

                        xPos = (player.Xpos * 4) + 4;
                        yPos = (player.Ypos * 2) + 2;
                        Console.SetCursorPosition(xPos, yPos);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("   ");

                        Console.ResetColor();

                        for (int i = 6; i <= logYPos; i++)
                        {
                            Console.SetCursorPosition(logXPos, i);
                            Console.Write(new String(' ', 95));
                        }
                        board[player.Ypos, player.Xpos] = null;
                        player.Ypos = 7;
                        player.Xpos = 0;
                    }
                    else
                    {
                        Thread.Sleep(2000);
                        player.IsFighting(monster, logXPos, logYPos += 2);
                        Thread.Sleep(2000);
                    }
                    if (monster.Pv <= 0)
                    {
                        Console.SetCursorPosition(logXPos, logYPos += 2);
                        Console.WriteLine($"{player.Name} à vaincu {monster.Race}");
                        xPos = (monster.Xpos * 4) + 4;
                        yPos = (monster.Ypos * 2) + 2;
                        Console.SetCursorPosition(xPos, yPos);
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        if (monster is Wolf)
                        {
                            Console.Write($" L ");
                            Console.SetCursorPosition(logXPos, logYPos += 2);
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"{player.Name} loot sur {monster.Race} {(monster as Wolf).Pelt} Peau(x)");
                        }
                        else if (monster is Orc)
                        {
                            Console.Write($" O ");
                            Console.SetCursorPosition(logXPos, logYPos += 2);
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"{player.Name} loot sur {monster.Race} {(monster as Orc).Gold} Piece(s) d'or");
                        }
                        else
                        {
                            Console.Write($" D ");
                            Console.SetCursorPosition(logXPos, logYPos += 2);
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"{player.Name} loot sur {monster.Race} {(monster as Whelp).Pelt} Peau(x) & {(monster as Whelp).Gold} Piece(s) d'or");
                        }
                        logYPos += 2;
                        Console.SetCursorPosition(logXPos, logYPos++);

                        Console.ReadLine();
                        Console.ResetColor();
                        for (int i = 6; i <= logYPos; i++)
                        {
                            Console.SetCursorPosition(logXPos, i);
                            Console.Write(new String(' ', 95));
                        }
                        deadEnemy++;
                    }

                }

                player.HealthRestoration(originPv);

            }

            Console.Clear();


            if (player.Life > 0)
            {
                audioVictory.Play();
                Console.WriteLine($"\n\n██╗   ██╗██╗ ██████╗████████╗ ██████╗ ██████╗ ██╗   ██╗\r\n██║   ██║██║██╔════╝╚══██╔══╝██╔═══██╗██╔══██╗╚██╗ ██╔╝\r\n██║   ██║██║██║        ██║   ██║   ██║██████╔╝ ╚████╔╝ \r\n╚██╗ ██╔╝██║██║        ██║   ██║   ██║██╔══██╗  ╚██╔╝  \r\n ╚████╔╝ ██║╚██████╗   ██║   ╚██████╔╝██║  ██║   ██║   \r\n  ╚═══╝  ╚═╝ ╚═════╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝   ╚═╝   \r\n                                                       ");
                Console.ReadLine();
            }

            void OnCharacterDeath(Character c)
            {
                if (c is Monster)
                {
                    if (c is Wolf)
                    {
                        player.Pelt += (c as Wolf).Pelt;
                    }
                    else if (c is Orc)
                    {
                        player.Gold += (c as Orc).Gold;
                    }
                    else if (c is Whelp)
                    {
                        player.Gold += (c as Whelp).Gold;
                        player.Pelt += (c as Whelp).Pelt;
                    }
                }
                else if (player.Life == 1)
                {
                    audioDeath.Play();
                    Console.Clear();
                    Console.WriteLine($"\n\n ██████╗  █████╗ ███╗   ███╗███████╗     ██████╗ ██╗   ██╗███████╗██████╗ \r\n██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔═══██╗██║   ██║██╔════╝██╔══██╗\r\n██║  ███╗███████║██╔████╔██║█████╗      ██║   ██║██║   ██║█████╗  ██████╔╝\r\n██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██║   ██║╚██╗ ██╔╝██╔══╝  ██╔══██╗\r\n╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ╚██████╔╝ ╚████╔╝ ███████╗██║  ██║\r\n ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝     ╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═╝\r\n                                                                          ");
                    Console.ReadLine();
                }


            }

            static void Log(int logXPos, int logYPos, string msg)
            {
                Console.SetCursorPosition(logXPos, logYPos++);
                Console.WriteLine($"{msg}");
            }

        }

    }
}
