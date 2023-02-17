using RPGHeroes.Custom_Exceptions;
using RPGHeroes.Hero.RPG_Classes;
using RPGHeroes.Item.Equipment;
using System;

var hero = new Mage("Alice");
Weapons weapon = new Weapons("I BLAST HAIHAI", 1, WeaponType.Staves, 15);
Armor armor = new Armor("PROTEC", 1, ItemSlot.Head, ArmorType.Cloth, new(1, 1, 1, 0, 0, 0));

hero.EquipWeapon(weapon);
hero.EquipArmor(armor);