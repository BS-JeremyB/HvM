using HeroesVsMonsters.Actions;
using HeroesVsMonsters.Characters;
using HeroesVsMonsters.Characters.Heroes;
using HeroesVsMonsters.Characters.Monsters;
using System.Media;

namespace HeroesVsMonsters.Gameplay
{
    public delegate void DelLog(int logXPos, int logYPos, string msg);

    public static class Fight
    {
        public static event DelLog ELog;

        public static void IsFighting(this Character c1, Character c2, int logXPos, int logYPos)
        {
            SoundPlayer audioStab = new SoundPlayer();
            audioStab.SoundLocation = @"C:\Users\BStorm\Documents\ressources\Desktop\HeroesVsMonsters\HeroesVsMonsters\Sound\stab.wav";
            SoundPlayer audioFire = new SoundPlayer();
            audioFire.SoundLocation = @"C:\Users\BStorm\Documents\ressources\Desktop\HeroesVsMonsters\HeroesVsMonsters\Sound\fireattack.wav";
            SoundPlayer audioHeroAttack = new SoundPlayer();
            audioHeroAttack.SoundLocation = @"C:\Users\BStorm\Documents\ressources\Desktop\HeroesVsMonsters\HeroesVsMonsters\Sound\heroattack.wav";

            int damage = Modifier.GetModifier(c1.For) + DiceRoller.Roll(4,1);
            if(ELog is not null)
            {
                if(c1 is Hero)
                {
                    audioHeroAttack.Play();
                    Console.ForegroundColor = ConsoleColor.Green;
                    ELog(logXPos, logYPos, $"{(c1 as Hero).Name}(V: {(c1 as Hero).Pv}) inflige {damage} points de dégats {(c2 as Monster).ReferenceCombat}(V: {(c2 as Monster).Pv})");
                }
                else
                {
                    if(c1 is Whelp)
                    {
                        audioFire.Play();
                    }
                    else
                    {
                        audioStab.Play();
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    ELog(logXPos, logYPos, $"{(c1 as Monster).Race}(V: {(c1 as Monster).Pv}) inflige {damage} points de dégats a {(c2 as Hero).Name}(V: {(c2 as Hero).Pv})");

                }
            }
            c2.TakeDamage(damage);
        }

    }
}
