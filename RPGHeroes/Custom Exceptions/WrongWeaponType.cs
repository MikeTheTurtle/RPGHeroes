using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Custom_Exceptions
{
    public class WrongWeaponType : Exception
    {
        public WrongWeaponType()
        {

        }

        public WrongWeaponType(string message) : base(message)
        {

        }

        public override string Message => "Cannot equip weapons of this type";
    }
}