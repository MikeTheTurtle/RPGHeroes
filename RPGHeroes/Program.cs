using RPGHeroes.Hero;
using RPGHeroes.Hero.RPG_Classes;
using RPGHeroes.Item.Equipment;

var taynos = new Rogue("Taynos");

var tayWpn = new Weapons("UngaBoo", 1, WeaponType.Daggers, 2);
var tayArm1 = new Armor("Monki Hear", 1, ItemSlot.Head, ArmorType.Mail, new(1, 2, 1, 0, 0, 0));
var tayArm2 = new Armor("Monki See", 1, ItemSlot.Chest, ArmorType.Mail, new(1, 1, 1, 0, 0, 0));
var tayArm3 = new Armor("Monki Do", 1, ItemSlot.Legs, ArmorType.Mail, new(1, 1, 1, 0, 0, 0));

taynos.EquipWeapon(tayWpn);
taynos.EquipArmor(tayArm1);
taynos.EquipArmor(tayArm2);
taynos.EquipArmor(tayArm3);

taynos.HeroDetails = taynos.DisplayHeroDetails();
Console.WriteLine(taynos.HeroDetails);