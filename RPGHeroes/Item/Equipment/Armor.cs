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

        protected ArmorType armorType;
        public HeroAttribute ArmorAttributes { get => armorAttributes; set => armorAttributes = value; }
        public ArmorType ArmorType { get => armorType; set => armorType = value; }

        //Setting up all we need to know for equipping armor
        public Armor(string name, int reqLevel, ItemSlot slot, ArmorType type, HeroAttribute attributes)
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
