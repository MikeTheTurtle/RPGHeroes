using RPGHeroes.Hero;
using RPGHeroes.Hero.RPG_Classes;
using RPGHeroes.Item.Equipment;

var mage = new Mage ("Monkey");

var weapon = new Weapons("Baboon Club", 3, weaponType.Staves, 2);

var armor = new Armor("Monki Hear", 3, itemSlot.Head, armorType.Cloth, new(1, 1, 1, 0, 0, 0));
var armor2 = new Armor("Monki See", 2, itemSlot.Chest, armorType.Cloth, new(1, 1, 1, 0, 0, 0));
var armor3 = new Armor("Monki Do", 2, itemSlot.Legs, armorType.Cloth, new(1, 1, 1, 0, 0, 0));

mage.LevelUp();
mage.LevelUp();

mage.EquipWeapon(weapon);
mage.EquipArmor(armor);
mage.EquipArmor(armor2);
mage.EquipArmor(armor3);

mage.CalculateDamage();