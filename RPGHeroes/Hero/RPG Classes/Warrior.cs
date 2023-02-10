using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Hero.RPG_Classes
{
    public class Warrior : Hero
    {
        public Warrior(string name) : base(name)
        {
            heroAttributes = new(strength: 5, dexterity: 2, intelligence: 1, incStrength: 3, incDexterity: 2, incIntelligence: 1);

            validWeaponTypes.Add("Axes");
            validWeaponTypes.Add("Hammers");
            validWeaponTypes.Add("Swords");

            validArmorTypes.Add("Plate");
        }
    }
}
