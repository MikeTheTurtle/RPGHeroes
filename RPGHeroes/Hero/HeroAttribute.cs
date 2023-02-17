using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Hero
{
    public class HeroAttribute
    {
        /* Through public get-ers but private set-ers, we can allow other code to
        * read the received values while restricting its ability to modify them */
        public int Strength { get; private set; }
        public int Dexterity { get; private set; }
        public int Intelligence { get; private set; }

        public int IncStrength { get; private set; }
        public int IncDexterity { get; private set; }
        public int IncIntelligence { get; private set; }

        // Ok. Hear me out. I DID plan on making equippable armor that allow for _bonus_ permanent increases in stats
        // when leveling up. However, a weekful of sickness and interviews (horrid combination btw, cannot really
        // recommend) made these parameters live on and by this point (Friday the 17th, 18:47:56, to be precise) I
        // honestly cannot find it in me to make this work, or make this prettier. So, uh, I'll take the hit Sean.
        // Just, please be gentle. Just a little.
        public HeroAttribute(int strength, int dexterity, int intelligence,
            int incStrength, int incDexterity, int incIntelligence)
        {
            this.Strength = strength;
            this.Dexterity = dexterity;
            this.Intelligence = intelligence;

            this.IncStrength = incStrength;
            this.IncDexterity = incDexterity;
            this.IncIntelligence = incIntelligence;
        }

        public void IncreaseAttributes()
        {
            Strength += IncStrength;
            Dexterity += IncDexterity;
            Intelligence += IncIntelligence;
        }
    }
}