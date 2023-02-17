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
        protected ItemSlot itemSlot;
        public string ItemName { get => itemName; set => itemName = value; }
        public int RequiredLevel { get => requiredLevel; set => requiredLevel = value; }
        public ItemSlot ItemSlot { get => itemSlot; set => itemSlot = value; }
    }
}
