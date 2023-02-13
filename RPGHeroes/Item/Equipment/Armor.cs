using RPGHeroes.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Item.Equipment
{
    public class Armor : Item
    {
        protected armorType armorType;

        protected HeroAttribute armorAttributes;

        public Armor(string name, int level, itemSlot slot, HeroAttribute attributes)
        {
            itemName = name;
            requiredLevel = level;
            itemSlot = slot;
            armorAttributes = new(attributes.Strength, attributes.Dexterity, attributes.Intelligence,
                attributes.IncStrength, attributes.IncDexterity, attributes.IncIntelligence);
        }
    }
}
