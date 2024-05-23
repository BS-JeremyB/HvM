using HeroesVsMonsters.Actions;
using HeroesVsMonsters.Characters.Heroes;
using HeroesVsMonsters.Characters.Monsters;
using HeroesVsMonsters.Gameplay;
using HeroesVsMonsters.map;
using System.Media;

Console.SetWindowSize(160, 40);

object[,] board;
List<Monster> monsters;
Hero player;
SoundPlayer audioIntro = new SoundPlayer();



Intro.GetIntro();
audioIntro.PlayLooping();

player = Creation.CreationHero();
monsters = Creation.CreationMonsters();

board = Dungeon.GetMap();
board = Spawn.GetMonsterSpawn(board, monsters);


audioIntro.Stop();
Game.InGame(player, board);
