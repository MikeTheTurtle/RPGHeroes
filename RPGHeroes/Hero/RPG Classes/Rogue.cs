using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Hero.RPG_Classes
{
    public class Rogue : Hero
    {
        public Rogue(string name) : base(name)
        {
            attributes = new(strength: 2, dexterity: 6, intelligence: 1, incStrength: 1, incDexterity: 4, incIntelligence: 1);
        }
    }
}
