using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Hero
{
    public class HeroAttribute
    {
        // Declaring private variables for the attributes
        private int strength;
        private int dexterity;
        private int intelligence;

        /* Through public get-ers but private set-ers, we can allow other code (Hero.cs)
         * to read the received values while restricting its ability to modify them */
        public int Strength { get => strength; private set => strength = value; }
        public int Dexterity { get => dexterity; private set => dexterity = value; }
        public int Intelligence { get => intelligence; private set => intelligence = value; }

        public void IncreaseAttributes()
        {

        }
    }
}
