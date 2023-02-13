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
        protected Dictionary<itemSlot, heroEquipment> heroEquippedItems;
        public string HeroName { get => heroName; set => heroName = value; }
        public int HeroLevel { get => heroLevel; set => heroLevel = value; }
        public Dictionary<itemSlot, heroEquipment> HeroEquippedItems { get => heroEquippedItems; set => heroEquippedItems = value; }

        protected List<weaponType> validWeaponTypes = new List<weaponType>();
        protected List<armorType> validArmorTypes = new List<armorType>();

        protected HeroAttribute heroAttributes;

        public Hero(string name)
        {
            this.heroName = name;
            heroLevel = 1;
            heroEquippedItems = new();
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
            if (heroEquippedItems.ContainsKey(slot))
            {
                heroEquippedItems.Remove(slot);
                heroEquippedItems.Add(slot, weapon);
            }
            else
            {
                heroEquippedItems.Add(slot, weapon);
            }
        }
        public void EquipArmor(itemSlot slot, heroEquipment armor)
        {
            if (heroEquippedItems.ContainsKey(slot))
            {
                heroEquippedItems.Remove(slot);
                heroEquippedItems.Add(slot, armor);
            }
            else
            {
                heroEquippedItems.Add(slot, armor);
            }
        }
        public void CalculateDamage()
        {

        }
        public void CalculateTotalAttributes()
        {
           
        }

        /*public string DisplayHeroInfo(string info)
        {

        }*/
    }
}
