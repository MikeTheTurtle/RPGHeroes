using RPGHeroes.Custom_Exceptions;
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
        //Nothing public!
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

        //Make sure we can get hero varíable values without mutating them
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

        //Initialize heroes, all of them start with their given name, at level 1 and with no equipment by default
        public Hero(string name)
        {
            this.heroName = name;
            heroLevel = 1;
            heroEquippedArmor = new();
        }

        public virtual void LevelUp()
        {
            heroLevel++;

            //Attribute increments happen in the individual subclasses
            HeroLevelAttributes.IncreaseAttributes();
        }

        //Simple logic to make sure items are equippable, throwing custom exes if they're not
        public virtual void EquipWeapon(Weapons weapon)
        {
            if (weapon.RequiredLevel > heroLevel)
            {
                try
                {
                    throw new TooLowLevelException();
                }
                catch (TooLowLevelException ex)
                {
                    Console.WriteLine("Custom exception: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Generic exception: " + ex.Message);
                }
            }
            else if (!validWeaponTypes.Contains(weapon.WeaponType))
            {
                try
                {
                    throw new WrongWeaponType();
                }
                catch (WrongWeaponType ex)
                {
                    Console.WriteLine("Custom exception: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Generic exception: " + ex.Message);
                }
            }
            else
            {
                heroEquippedWeapon = weapon;
            }
        }

        //Same as with weapons
        public virtual void EquipArmor(Armor armor)
        {
            if (armor.RequiredLevel > heroLevel)
            {
                try
                {
                    throw new TooLowLevelException();
                }
                catch (TooLowLevelException ex)
                {
                    Console.WriteLine("Custom exception: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Generic exception: " + ex.Message);
                }
            }
            else if (!validArmorTypes.Contains(armor.ArmorType))
            {
                try
                {
                    throw new WrongArmorType();
                }
                catch (WrongArmorType ex)
                {
                    Console.WriteLine("Custom exception: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Generic exception: " + ex.Message);
                }
            }
            else
            {
                heroEquippedArmor.Remove(armor.ItemSlot);
                heroEquippedArmor.Add(armor.ItemSlot, armor);
            }

            CalculateTotalAttributes();
        }

        //The following two functions are abstract to be overridden in the subclasses, to allow for easier
        // workings with which stat is the main damaging one
        public abstract double CalculateDamage();

        public abstract HeroAttribute CalculateTotalAttributes();

        //String builder used to display simple hero info
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
