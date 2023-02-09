using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Item.Equipment
{
    public class Weapons
    {
        protected enum weaponType
        {
            Axes,
            Bows,
            Daggers,
            Hammers,
            Staves,
            Swords,
            Wands
        }

        protected int weaponDamage;
    }
}
