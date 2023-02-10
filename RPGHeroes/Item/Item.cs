using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Item
{
    public abstract class Item
    {
        protected string itemName;
        protected int requiredLevel;

        protected itemSlot slot;
    }
}
