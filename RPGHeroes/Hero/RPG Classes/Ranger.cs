using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Hero.RPG_Classes
{
    public class Ranger : Hero
    {
        public Ranger(string name) : base(name)
        {
            heroAttributes = new(strength: 1, dexterity: 7, intelligence: 1, incStrength: 1, incDexterity: 5, incIntelligence: 1);

            validWeaponTypes.Add(weaponType.Bows);

            validArmorTypes.Add(armorType.Leather);
            validArmorTypes.Add(armorType.Mail);
        }
    }
}
