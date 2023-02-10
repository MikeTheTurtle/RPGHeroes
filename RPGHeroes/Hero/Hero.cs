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
        protected enum equipmentType
        {
            Weapon,
            Head,
            Chest,
            Legs
        }

        protected Dictionary<equipmentType, string> equippedItems = new();
        protected List<string> validWeaponTypes = new List<string>();
        protected List<string> validArmorTypes = new List<string>();

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
        public void EquipWeapon(string weapon)
        {
            equippedItems.Add(equipmentType.Weapon, weapon);
        }
        public void EquipArmor(string armor)
        {
            equippedItems.Add(equipmentType.Head, armor);
            equippedItems.Add(equipmentType.Chest, armor);
            equippedItems.Add(equipmentType.Legs, armor);
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
