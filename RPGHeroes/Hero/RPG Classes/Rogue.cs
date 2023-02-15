﻿using RPGHeroes.Item.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Hero.RPG_Classes
{
    public class Rogue : Hero
    {
        public Rogue(string name) : base(name)
        {
            heroLevelAttributes = new(strength: 2, dexterity: 6, intelligence: 1, incStrength: 1, incDexterity: 4, incIntelligence: 1);
            DamagingAttribute = HeroLevelAttributes.Dexterity;

            validWeaponTypes.Add(weaponType.Daggers);
            validWeaponTypes.Add(weaponType.Swords);

            validArmorTypes.Add(armorType.Leather);
            validArmorTypes.Add(armorType.Mail);
        }

        public override void CalculateDamage()
        {
            double heroDamage = 0;

            if (heroEquippedWeapon == null)
            {
                heroDamage = 1 * (1 + (double)DamagingAttribute / 100);
            }
            else
            {
                heroDamage = heroEquippedWeapon.WeaponDamage * (1 + (double)DamagingAttribute / 100);
            }

            Console.WriteLine(heroDamage);
        }
        public override void CalculateTotalAttributes()
        {
            int totalStrength = HeroLevelAttributes.Strength;
            int totalDexterity = HeroLevelAttributes.Dexterity;
            int totalIntelligence = HeroLevelAttributes.Intelligence;

            Armor[] currentArmor = heroEquippedArmor.Values.ToArray();

            for (int i = 0; i < currentArmor.Length; i++)
            {
                totalStrength += currentArmor.ElementAt(i).ArmorAttributes.Strength;
                totalDexterity += currentArmor.ElementAt(i).ArmorAttributes.Dexterity;
                totalIntelligence += currentArmor.ElementAt(i).ArmorAttributes.Intelligence;
            }

            HeroAttribute totalAttributes = new(totalStrength, totalDexterity, totalIntelligence, 0, 0, 0);

            DamagingAttribute = totalAttributes.Dexterity;

            Console.WriteLine(totalAttributes.Strength);
            Console.WriteLine(totalAttributes.Dexterity);
            Console.WriteLine(totalAttributes.Intelligence);
        }
    }
}