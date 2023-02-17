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
        protected string heroClass;
        protected int heroLevel;
        protected HeroAttribute heroLevelAttributes;
        protected int heroDamagingAttribute;

        protected Weapons heroEquippedWeapon;
        protected Dictionary<ItemSlot, Armor> heroEquippedArmor;
        protected List<WeaponType> validWeaponTypes = new List<WeaponType>();
        protected List<ArmorType> validArmorTypes = new List<ArmorType>();

        protected string heroDetails;

        public string HeroName { get => heroName; set => heroName = value; }
        public string HeroClass { get => heroClass; set => heroClass = value; }
        public int HeroLevel { get => heroLevel; set => heroLevel = value; }
        public HeroAttribute HeroLevelAttributes { get => heroLevelAttributes; set => heroLevelAttributes = value; }
        public int HeroDamagingAttribute { get => heroDamagingAttribute; set => heroDamagingAttribute = value; }
        public Weapons HeroEquippedWeapon { get => heroEquippedWeapon; set => heroEquippedWeapon = value; }
        public Dictionary<ItemSlot, Armor> HeroEquippedArmor { get => heroEquippedArmor; set => heroEquippedArmor = value; }
        public List<WeaponType> ValidWeaponTypes { get => validWeaponTypes; set => validWeaponTypes = value; }
        public List<ArmorType> ValidArmorTypes { get => validArmorTypes; set => validArmorTypes = value; }
        public string HeroDetails { get => heroDetails; set => heroDetails = value; }

        public Hero(string name)
        {
            this.heroName = name;
            heroLevel = 1;
            heroEquippedArmor = new();
        }

        public virtual void LevelUp()
        {
            heroLevel++;
            HeroLevelAttributes.IncreaseAttributes();
        }

        public virtual void EquipWeapon(Weapons weapon)
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

        public virtual void EquipArmor(Armor armor)
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

        public abstract double CalculateDamage();

        public abstract HeroAttribute CalculateTotalAttributes();

        public virtual string DisplayHeroDetails()
        {
            StringBuilder heroDetails = new StringBuilder();

            heroDetails.Append("Hero Name: " + heroName + "\n");
            heroDetails.Append("Hero Class: " + heroClass + "\n");
            heroDetails.Append("Hero Level: " + heroLevel + "\n");
            heroDetails.Append("Total Strength: " + CalculateTotalAttributes().Strength + "\n");
            heroDetails.Append("Total Dexterity: " + CalculateTotalAttributes().Dexterity + "\n");
            heroDetails.Append("Total Intelligence: " + CalculateTotalAttributes().Intelligence + "\n");
            heroDetails.Append("Weapon Damage: " + CalculateDamage());

            return heroDetails.ToString();
        }
    }
}
