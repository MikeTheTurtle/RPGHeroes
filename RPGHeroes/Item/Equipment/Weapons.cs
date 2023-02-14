using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Item.Equipment
{
    public class Weapons : Item
    {
        protected int weaponDamage;

        protected weaponType weaponType;
        public weaponType WeaponType { get => weaponType; set => weaponType = value; }
    }
}
