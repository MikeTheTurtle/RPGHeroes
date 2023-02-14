using RPGHeroes.Hero.RPG_Classes;
using RPGHeroes.Item.Equipment;

var mage = new Mage ("Monkey");

var weapon = new Weapons("Baboon Club", 5, weaponType.Staves, 2);
var weapon2 = new Weapons("Baboon Slab", 5, weaponType.Staves, 2);

var armor = new Armor("Clonk's Bonk", 5, itemSlot.Head, armorType.Cloth, new(1, 1, 1, 0, 0, 0));
var armor2 = new Armor("Clank's Bank", 2, itemSlot.Chest, armorType.Cloth, new(1, 1, 1, 0, 0, 0));
var armor3 = new Armor("Clink's Bink", 2, itemSlot.Legs, armorType.Cloth, new(1, 1, 1, 0, 0, 0));

mage.LevelUp(2);
mage.LevelUp(2);

mage.EquipWeapon(weapon);
mage.EquipWeapon(weapon2);
mage.EquipArmor(armor);
mage.EquipArmor(armor2);
mage.EquipArmor(armor3);

mage.CalculateTotalAttributes();