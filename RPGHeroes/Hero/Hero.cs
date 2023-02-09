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
        protected string name;
        protected int level;
        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }

        protected HeroAttribute attributes;
        protected enum equipmentType
        {
            Weapon,
            Head,
            Chest,
            Legs
        }

        protected Dictionary<equipmentType, string> equipment = new();
        protected List<string> validWeaponTypes = new List<string>();
        protected List<string> validArmorTypes = new List<string>();

        public Hero(string name)
        {
            this.name = name;
            level = 1;
        }
        public int LevelUp(int level)
        {
            level++;
            return level;
        }
        public void EquipWeapon(string weapon)
        {
            equipment.Add(equipmentType.Weapon, weapon);
        }
        public void EquipArmor(string armor)
        {
            equipment.Add(equipmentType.Head, armor);
            equipment.Add(equipmentType.Chest, armor);
            equipment.Add(equipmentType.Legs, armor);
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
