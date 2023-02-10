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

        protected HeroAttribute armorAttribute;

        public Armor(string name, int level, itemSlot slot, HeroAttribute attributes)
        {
            itemName = name;
            requiredLevel = level;
            itemSlot = slot;
            armorAttribute = attributes;
        }
    }
}
