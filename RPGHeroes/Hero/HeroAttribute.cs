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

        // Ctor
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