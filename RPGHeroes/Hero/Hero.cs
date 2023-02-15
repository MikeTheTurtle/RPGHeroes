using RPGHeroes.Damage_State_Machine;
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
        //public int HeroLevel { get => heroLevel; set => heroLevel = value; }
        public int DamagingAttribute { get => damagingAttribute; set => damagingAttribute = value; }

        public Hero(string name)
        {
            this.heroName = name;
            heroLevel = 1;
            heroEquippedArmor = new();
        }
        public void LevelUp()
        {
            heroLevel++;
            heroLevelAttributes.IncreaseAttributes();
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
        public void CalculateDamage()
        {
            double heroDamage = 0;

            if (heroEquippedWeapon == null)
            {
                heroDamage = 1 * (1 + (double)damagingAttribute / 100);
            }
            else
            {
                heroDamage = heroEquippedWeapon.WeaponDamage * (1 + (double)damagingAttribute / 100);
            }
            Console.WriteLine(heroDamage);
        }
        public void CalculateTotalAttributes()
        {
            int totalStrength = 0;
            int totalDexterity = 0;
            int totalIntelligence = 0;

            Armor[] currentArmor = heroEquippedArmor.Values.ToArray();

            for (int i = 0; i < currentArmor.Length; i++)
            {
                totalStrength += currentArmor.ElementAt(i).ArmorAttributes.Strength;
                totalDexterity += currentArmor.ElementAt(i).ArmorAttributes.Dexterity;
                totalIntelligence += currentArmor.ElementAt(i).ArmorAttributes.Intelligence;
            }

            totalStrength += heroLevelAttributes.Strength;
            totalDexterity += heroLevelAttributes.Dexterity;
            totalIntelligence += heroLevelAttributes.Intelligence;

            HeroAttribute totalAttributes = new(totalStrength, totalDexterity, totalIntelligence, 0, 0, 0);

            Console.WriteLine(totalAttributes.Strength);
            Console.WriteLine(totalAttributes.Dexterity);
            Console.WriteLine(totalAttributes.Intelligence);
        }

        /*public string DisplayHeroInfo(string info)
        {

        }*/
    }
}
