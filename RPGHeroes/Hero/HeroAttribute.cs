using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Hero
{
    public class HeroAttribute
    {
        /* Through public get-ers but private set-ers, we can allow other code (Hero.cs)
        * to read the received values while restricting its ability to modify them */
        public int strength { get; private set; }
        public int dexterity { get; private set; }
        public int intelligence { get; private set; }

        // Declaring private variables used for increasing attributes
        private int incStrength;
        private int incDexterity;
        private int incIntelligence;
           
        // Ctor
        public HeroAttribute(int strength, int dexterity, int intelligence,
            int incStrength, int incDexterity, int incIntelligence)
        {
            this.strength = strength;
            this.dexterity = dexterity;
            this.intelligence = intelligence;

            this.incStrength = incStrength;
            this.incDexterity = incDexterity;
            this.incIntelligence = incIntelligence;
        }

        public void IncreaseAttributes()
        {
            strength += incStrength;
            dexterity += incDexterity;
            intelligence += incIntelligence;
        }
    }
}