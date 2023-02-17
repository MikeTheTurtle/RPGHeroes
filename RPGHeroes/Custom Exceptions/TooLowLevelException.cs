using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Custom_Exceptions
{
    public class TooLowLevelException : Exception
    {
        public TooLowLevelException()
        {

        }

        public TooLowLevelException(string message) : base(message)
        {

        }

        public override string Message => "Too low level to equip this item!";
    }
}