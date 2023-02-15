using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Hero.RPG_Classes
{
    public class Mage : Hero
    {
        public Mage(string name) : base(name)
        {
            heroLevelAttributes = new(strength: 1, dexterity: 1, intelligence: 8, incStrength: 1, incDexterity: 1, incIntelligence: 5);
            damagingAttribute = heroLevelAttributes.Intelligence;

            validWeaponTypes.Add(weaponType.Staves);
            validWeaponTypes.Add(weaponType.Wands);

            validArmorTypes.Add(armorType.Cloth);
        }
    }
}