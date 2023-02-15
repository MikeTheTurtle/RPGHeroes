using RPGHeroes.Item;
using RPGHeroes.Item.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Hero
{
   public abstract class Hero
    {
        protected string heroName;
        protected int heroLevel;
        protected HeroAttribute heroLevelAttributes;
        protected int damagingAttribute;

        protected Weapons heroEquippedWeapon;
        protected Dictionary<itemSlot, Armor> heroEquippedArmor;
        protected List<weaponType> validWeaponTypes = new List<weaponType>();
        protected List<armorType> validArmorTypes = new List<armorType>();

        public string HeroName { get => heroName; set => heroName = value; }
        public int HeroLevel { get => heroLevel; set => heroLevel = value; }
        public HeroAttribute HeroLevelAttributes { get => heroLevelAttributes; set => heroLevelAttributes = value; }
        public int DamagingAttribute { get => damagingAttribute; set => damagingAttribute = value; }

        public Hero(string name)
        {
            this.heroName = name;
            HeroLevel = 1;
            heroEquippedArmor = new();
        }
        public void LevelUp()
        {
            HeroLevel++;
            HeroLevelAttributes.IncreaseAttributes();
        }
        public void EquipWeapon(Weapons weapon)
        {
            if (weapon.RequiredLevel > heroLevel)
            {
                Console.WriteLine("Too low level to equip this weapon!");
            }
            else if (!validWeaponTypes.Contains(weapon.WeaponType))
            {
                Console.WriteLine("Cannot equip weapons of this type!");
            }
            else
            {
                heroEquippedWeapon = weapon;
                Console.WriteLine("Weapon equipped!");
            }
        }
        public void EquipArmor(Armor armor)
        {
            if (armor.RequiredLevel > heroLevel)
            {
                Console.WriteLine("Too low level to equip this armor!");
            }
            else if (!validArmorTypes.Contains(armor.ArmorType))
            {
                Console.WriteLine("Cannot equip armor of this type!");
            }
            else
            {
                heroEquippedArmor.Remove(armor.ItemSlot);
                heroEquippedArmor.Add(armor.ItemSlot, armor);
            }

            CalculateTotalAttributes();
        }
        public abstract void CalculateDamage();
        public abstract void CalculateTotalAttributes();

        public string DisplayHeroInfo(string info)
        {
            return info;
        }
    }
}
