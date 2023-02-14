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

        protected itemSlot slot = itemSlot.Weapon;

        protected weaponType weaponType;
        public int WeaponDamage { get => weaponDamage; set => weaponDamage = value; }
        public weaponType WeaponType { get => weaponType; set => weaponType = value; }
        
        public Weapons(string name, int reqLevel, weaponType type, int wpnDamage)
        {
            itemName = name;
            requiredLevel = reqLevel;
            weaponType = type;
            weaponDamage = wpnDamage;
        }
    }
}
