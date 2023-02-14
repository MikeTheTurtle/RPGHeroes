using RPGHeroes.Hero.RPG_Classes;
using RPGHeroes.Item.Equipment;

var mage = new Mage ("Monkey");

var armor = new Armor("Clonk's Bonk", 2, itemSlot.Chest, armorType.Leather, new(1, 1, 1, 0, 0, 0));

var armor2 = new Armor("Clank's Bank", 2, itemSlot.Chest, armorType.Cloth, new(1, 1, 1, 0, 0, 0));

var armor3 = new Armor("Clink's Bink", 2, itemSlot.Legs, armorType.Cloth, new(1, 1, 1, 0, 0, 0));

mage.LevelUp(2);
mage.CalculateTotalAttributes();

mage.EquipArmor(armor.ItemSlot, heroEquipment.Chest);
mage.EquipArmor(armor2.ItemSlot, heroEquipment.Chest);
mage.EquipArmor(armor3.ItemSlot, heroEquipment.Legs);