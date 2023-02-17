using RPGHeroes.Item.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Hero.RPG_Classes
{
    public class Mage : Hero
    {
        public Mage(string name) : base(name)
        {
            heroClass = "Mage";
            HeroLevelAttributes = new(strength: 1, dexterity: 1, intelligence: 8, incStrength: 1, incDexterity: 1, incIntelligence: 5);
            HeroDamagingAttribute = HeroLevelAttributes.Intelligence;

            validWeaponTypes.Add(WeaponType.Staves);
            validWeaponTypes.Add(WeaponType.Wands);
            validArmorTypes.Add(ArmorType.Cloth);
        }

        public override double CalculateDamage()
        {
            double heroDamage = 0;

            if (heroEquippedWeapon == null)
            {
                heroDamage = 1 * (1 + (double)HeroDamagingAttribute / 100);
            }
            else
            {
                heroDamage = heroEquippedWeapon.WeaponDamage * (1 + (double)HeroDamagingAttribute / 100);
            }

            return heroDamage;
        }

        public override HeroAttribute CalculateTotalAttributes()
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

            HeroAttribute totalAttributes = new(totalStrength, totalDexterity, totalIntelligence,
                HeroLevelAttributes.IncStrength, HeroLevelAttributes.IncDexterity, HeroLevelAttributes.IncIntelligence);
            HeroDamagingAttribute = totalAttributes.Intelligence;

            return totalAttributes;
        }
    }
}