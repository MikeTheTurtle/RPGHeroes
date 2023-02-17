using RPGHeroes.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Item.Equipment
{
    public class Weapons : Item
    {
        protected int weaponDamage;

        protected ItemSlot slot = ItemSlot.Weapon;

        protected WeaponType weaponType;
        public int WeaponDamage { get => weaponDamage; set => weaponDamage = value; }
        public WeaponType WeaponType { get => weaponType; set => weaponType = value; }
        
        //Setting up all we need to know for equipping weapons. Unlike armor, we don't parse in ItemSlot since it always
        // automatically should default to, well, the weapon slot.
        public Weapons(string name, int reqLevel, WeaponType type, int wpnDamage)
        {
            itemName = name;
            requiredLevel = reqLevel;
            weaponType = type;
            weaponDamage = wpnDamage;
        }
    }
}
