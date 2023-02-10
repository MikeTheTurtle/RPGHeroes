using RPGHeroes.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Item.Equipment
{
    public class Armor : Item
    {
        protected enum armorType
        {
            Cloth,
            Leather,
            Mail,
            Plate
        }

        protected HeroAttribute armorAttributes;
    }
}
