using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Custom_Exceptions
{
    public class WrongArmorType : Exception
    {
        public WrongArmorType()
        {

        }

        public WrongArmorType(string message) : base(message)
        {

        }

        public override string Message => "Cannot equip armor of this type!";
    }
}