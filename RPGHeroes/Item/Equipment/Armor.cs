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
        protected HeroAttribute armorAttributes;

        protected armorType armorType;
        public armorType ArmorType { get => armorType; set => armorType = value; }

        public Armor(string name, int reqLevel, itemSlot slot, armorType type, HeroAttribute attributes)
        {
            itemName = name;
            requiredLevel = reqLevel;
            itemSlot = slot;
            armorType = type;
            armorAttributes = new(attributes.Strength, attributes.Dexterity, attributes.Intelligence,
                attributes.IncStrength, attributes.IncDexterity, attributes.IncIntelligence);
        }
    }
}
