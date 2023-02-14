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
        protected HeroAttribute heroAttributes;

        protected Dictionary<itemSlot, heroEquipment> heroEquippedItems;
        protected List<weaponType> validWeaponTypes = new List<weaponType>();
        protected List<armorType> validArmorTypes = new List<armorType>();

        private weaponType[] arrayOfWeaponTypes;
        private armorType[] arrayOfArmorTypes;

        private bool equippableItemsDefined = false;

        public string HeroName { get => heroName; set => heroName = value; }
        public int HeroLevel { get => heroLevel; set => heroLevel = value; }
        public Dictionary<itemSlot, heroEquipment> HeroEquippedItems { get => heroEquippedItems; set => heroEquippedItems = value; }

        public Hero(string name)
        {
            this.heroName = name;
            heroLevel = 1;
            heroEquippedItems = new();
        }

        public void DefineEquippableItems()
        {
            for (int i = 0; i < validWeaponTypes.Count; i++)
            {
                arrayOfWeaponTypes = validWeaponTypes.ToArray();
            }

            for (int i = 0; i < validArmorTypes.Count; i++)
            {
                arrayOfArmorTypes = validArmorTypes.ToArray();
            }
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
            if (!equippableItemsDefined)
            {
                DefineEquippableItems();
                equippableItemsDefined = true;
            }

            for (int i = 0; i <= validWeaponTypes.Count; i++)
            {
                if (!validWeaponTypes.Contains(arrayOfWeaponTypes.ElementAt(i)))
                {
                    {
                        Console.WriteLine("Cannot equip items of this weapon type!");
                    }
                }
                else if (1 == 3)
                {
                    Console.WriteLine("Too low level to equip this item!");
                }
                else
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

                Console.WriteLine(heroEquippedItems.Count());
            }
        }
        public void EquipArmor(itemSlot slot, heroEquipment armor)
        {
            if (!equippableItemsDefined)
            {
                DefineEquippableItems();
                equippableItemsDefined = true;
            }

            for (int i = 0; i < validArmorTypes.Count; i++)
            {
                if (validArmorTypes.Contains(arrayOfArmorTypes.ElementAt(i)) == true)
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
                else if (1 == 3)
                {
                    Console.WriteLine("Too low level to equip this item!");
                }
                else
                {
                    Console.WriteLine("Cannot equip armor of this type!");
                }
                Console.WriteLine(heroEquippedItems.Count());
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
