using RPGHeroes.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Hero
{
   public abstract class Hero
    {
        protected string heroName;
        protected int heroLevel;
        public string HeroName { get => heroName; set => heroName = value; }
        public int Level { get => heroLevel; set => heroLevel = value; }

        protected HeroAttribute heroAttributes;
  
        protected Dictionary<itemSlot, heroEquipment> equippedItems;
        public Dictionary<itemSlot, heroEquipment> EquippedItems { get => equippedItems; set => equippedItems = value; }

        protected List<weaponType> validWeaponTypes = new List<weaponType>();
        protected List<armorType> validArmorTypes = new List<armorType>();

        public Hero(string name)
        {
            this.heroName = name;
            heroLevel = 1;

            equippedItems = new();
        }
        public void LevelUp(int amountOfLevels)
        {
            heroLevel += amountOfLevels;

            for (int i = 0; i < amountOfLevels; i++)
            {
                heroAttributes.IncreaseAttributes();
            }
        }
        public void EquipWeapon(itemSlot slot, heroEquipment weapon)
        {
            equippedItems.Add(slot, weapon);
        }
        public void EquipArmor(itemSlot slot, heroEquipment armor)
        {
            if (equippedItems.ContainsKey(slot))
            {
                equippedItems.Remove(slot);
                equippedItems.Add(slot, armor);
            }
            else
            {
                equippedItems.Add(slot, armor);
            }
        }
        public void CalculateDamage()
        {

        }
        public void CalculateTotalAttributes()
        {
            heroAttributes = new(heroAttributes.Strength, heroAttributes.Dexterity, heroAttributes.Intelligence,
                heroAttributes.IncStrength, heroAttributes.IncDexterity, heroAttributes.IncIntelligence);
            Console.WriteLine(heroAttributes.Intelligence);
        }

        /*public string DisplayHeroInfo(string info)
        {

        }*/
    }
}
