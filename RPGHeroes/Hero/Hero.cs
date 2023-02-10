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
  

        protected Dictionary<itemSlot, heroEquipmentType> equippedItems = new();
        protected List<weaponType> validWeaponTypes = new List<weaponType>();
        protected List<armorType> validArmorTypes = new List<armorType>();

        public Hero(string name)
        {
            this.heroName = name;
            heroLevel = 1;
        }
        public int LevelUp(int level)
        {
            level++;
            heroAttributes.IncreaseAttributes();
            return level;
        }
        public void EquipWeapon(heroEquipmentType weapon)
        {
            equippedItems.Add(itemSlot.Weapon, heroEquipmentType.Weapon);
        }
        public void EquipArmor(heroEquipmentType armor)
        {
            equippedItems.Add(itemSlot.Head, heroEquipmentType.Head);
            equippedItems.Add(itemSlot.Chest, heroEquipmentType.Chest);
            equippedItems.Add(itemSlot.Legs, heroEquipmentType.Legs);
        }
        public void CalculateDamage()
        {

        }
        public void CalculateAttributes()
        {

        }

        /*public string DisplayHeroInfo(string info)
        {

        }*/
    }
}
