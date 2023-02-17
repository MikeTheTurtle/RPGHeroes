using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Custom_Exceptions
{
    public class MyCustomException : Exception
    {
        public MyCustomException()
        {

        }

        public MyCustomException(string message) : base(message)
        {

        }

        public override string Message => "Custom error";
    }
}
