using HeroesVsMonsters.Actions;
using HeroesVsMonsters.Characters.Heroes;
using HeroesVsMonsters.Gameplay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters.Characters
{
    public delegate void DelLoot(Character c);
    public class Character 
    {

        public Character(int yPos, int xPos, int frc, int end, int pv)
        {
            For = frc + DiceRoller.Roll(6, 4);
            End = end + DiceRoller.Roll(6, 4);
            Pv = End + Modifier.GetModifier(End);
            Ypos = yPos;
            Xpos = xPos;
        }

        private int _Pv;
        private int _For;
        private int _End;
        private int _Ypos;
        private int _Xpos;

        public int Ypos { get; set; }
        public int Xpos { get; set; }
        public int Pv 
        {
            get { return _Pv; }
            private set { _Pv = value; }
        }   
        public int For
        {
            get { return _For; }
            private set { _For = value; }
        }
        public int End
        {
            get { return _End; }
            private set { _End = value; }
        }

        public event DelLoot OnDeath;

        public void TakeDamage(int damage)
        {
            Pv -= damage;
            if (Pv <= 0)
            {
                OnDeath(this);
            }
        }
        
        public void HealthRestoration(int originPv)
        {
            Pv = originPv;
        }
    }
}

