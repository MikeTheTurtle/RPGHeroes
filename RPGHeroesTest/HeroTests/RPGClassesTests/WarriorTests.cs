using RPGHeroes.Hero;
using RPGHeroes.Hero.RPG_Classes;
using RPGHeroes.Item.Equipment;

namespace RPGHeroesTest.HeroTests.RPGClassesTests
{
    public class WarriorTests
    {
        [Fact]
        public void When_CreatingNewWarrior_Expect_CorrectName()
        {
            //Arrange
            string expectedName = "Maddie";
            var hero = new Warrior(expectedName);

            //Act
            string actualName = hero.HeroName;

            //Assert
            Assert.Equal(expectedName, actualName);
        }

        [Fact]
        public void When_CreatingNewWarrior_Expect_CorrectLevel()
        {
            //Arrange
            var hero = new Warrior("Maddie");
            int expectedLevel = 1;

            //Act
            int actualLevel = hero.HeroLevel;

            //Assert
            Assert.Equal(expectedLevel, actualLevel);
        }

        [Fact]
        public void When_CreatingNewWarrior_Expect_CorrectAttributes()
        {
            //Arrange
            var hero = new Warrior("Maddie");
            HeroAttribute expectedAttributes = new(5, 2, 1, 3, 2, 1);

            //Act
            HeroAttribute actualAttributes = hero.HeroLevelAttributes;

            //Assert
            Assert.Equivalent(expectedAttributes, actualAttributes);
        }

        [Fact]
        public void When_GainingOneLevel_Expect_CorrectAttributeIncreases()
        {
            //Arrange
            var hero = new Warrior("Maddie");
            HeroAttribute levelOneAttributes = hero.HeroLevelAttributes;
            HeroAttribute expectedLevelTwoAttributes = new(levelOneAttributes.Strength + 3, levelOneAttributes.Dexterity + 2, levelOneAttributes.Intelligence + 1, 3, 2, 1);

            //Act
            hero.LevelUp();
            HeroAttribute actualLevelTwoAttributes = hero.HeroLevelAttributes;

            //Assert
            Assert.Equivalent(expectedLevelTwoAttributes, actualLevelTwoAttributes);
        }

        [Fact]
        public void When_EquippingWeapon_Expect_CorrectLevelRequirement()
        {
            //Arrange
            var hero = new Warrior("Maddie");
            Weapons weapon = new Weapons("I SMASH YESYES", 1, WeaponType.Axes, 15);
            int expectedRequiredLevel = 1;

            //Act
            hero.EquipWeapon(weapon);
            int actualRequiredLevel = hero.HeroEquippedWeapon.RequiredLevel;

            //Assert
            Assert.Equal(expectedRequiredLevel, actualRequiredLevel);
        }

        [Fact]
        public void When_EquippingAxe_Expect_CorrectWeaponType()
        {
            //Arrange
            var hero = new Warrior("Maddie");
            Weapons weapon = new Weapons("I SMASH YESYES", 1, WeaponType.Axes, 15);
            WeaponType expectedEquippableWeaponType = WeaponType.Axes;

            //Act
            hero.EquipWeapon(weapon);
            WeaponType actualEquippedWeaponType = hero.HeroEquippedWeapon.WeaponType;

            //Assert
            Assert.Equal(expectedEquippableWeaponType, actualEquippedWeaponType);
        }

        [Fact]
        public void When_EquippingHammers_Expect_CorrectWeaponType()
        {
            //Arrange
            var hero = new Warrior("Maddie");
            Weapons weapon = new Weapons("I SMASH YESYES", 1, WeaponType.Hammers, 15);
            WeaponType expectedEquippableWeaponType = WeaponType.Hammers;

            //Act
            hero.EquipWeapon(weapon);
            WeaponType actualEquippedWeaponType = hero.HeroEquippedWeapon.WeaponType;

            //Assert
            Assert.Equal(expectedEquippableWeaponType, actualEquippedWeaponType);
        }

        [Fact]
        public void When_EquippingSwords_Expect_CorrectWeaponType()
        {
            //Arrange
            var hero = new Warrior("Maddie");
            Weapons weapon = new Weapons("I SMASH YESYES", 1, WeaponType.Swords, 15);
            WeaponType expectedEquippableWeaponType = WeaponType.Swords;

            //Act
            hero.EquipWeapon(weapon);
            WeaponType actualEquippedWeaponType = hero.HeroEquippedWeapon.WeaponType;

            //Assert
            Assert.Equal(expectedEquippableWeaponType, actualEquippedWeaponType);
        }

        [Fact]
        public void When_EquippingPlate_Expect_CorrectArmorType()
        {
            //Arrange
            var hero = new Warrior("Maddie");
            Armor armor = new Armor("NOW WE'RE TALKING!!!", 1, ItemSlot.Head, ArmorType.Plate, new(1, 1, 1, 0, 0, 0));
            ArmorType expectedEquippableArmorType = ArmorType.Plate;

            //Act
            hero.EquipArmor(armor);
            ArmorType actualEquippedArmorType = hero.HeroEquippedArmor[ItemSlot.Head].ArmorType;

            //Assert
            Assert.Equal(expectedEquippableArmorType, actualEquippedArmorType);
        }

        [Fact]
        public void When_CalculatingTotalAttributesWithoutArmor_Expect_CorrectAttributes()
        {
            //Arrange
            var hero = new Warrior("Maddie");
            HeroAttribute expectedAttributes = new(5, 2, 1, 3, 2, 1);

            //Act
            HeroAttribute actualAttributes = hero.CalculateTotalAttributes();

            //Assert
            Assert.Equivalent(expectedAttributes, actualAttributes);
        }

        [Fact]
        public void When_CalculatingTotalAttributesWithOneArmorPiece_Expect_CorrectAttributes()
        {
            //Arrange
            var hero = new Warrior("Maddie");
            Armor head = new Armor("Monki Hear", 1, ItemSlot.Head, ArmorType.Plate, new(1, 1, 1, 0, 0, 0));
            HeroAttribute expectedAttributes = new(6, 3, 2, 3, 2, 1);

            //Act
            hero.EquipArmor(head);
            HeroAttribute actualAttributes = hero.CalculateTotalAttributes();

            //Assert
            Assert.Equivalent(expectedAttributes, actualAttributes);
        }

        [Fact]
        public void When_CalculatingTotalAttributesWithTwoArmorPieces_Expect_CorrectAttributes()
        {
            //Arrange
            var hero = new Warrior("Maddie");
            Armor head = new Armor("Monki Hear", 1, ItemSlot.Head, ArmorType.Plate, new(1, 1, 1, 0, 0, 0));
            Armor chest = new Armor("Monki See", 1, ItemSlot.Chest, ArmorType.Plate, new(1, 1, 1, 0, 0, 0));
            HeroAttribute expectedAttributes = new(7, 4, 3, 3, 2, 1);

            //Act
            hero.EquipArmor(head);
            hero.EquipArmor(chest);
            HeroAttribute actualAttributes = hero.CalculateTotalAttributes();

            //Assert
            Assert.Equivalent(expectedAttributes, actualAttributes);
        }

        [Fact]
        public void When_CalculatingTotalAttributesWithReplacedArmorPiece_Expect_CorrectAttributes()
        {
            //Arrange
            var hero = new Warrior("Maddie");
            Armor head = new Armor("Monki Hear", 1, ItemSlot.Head, ArmorType.Plate, new(1, 1, 1, 0, 0, 0));
            Armor headTwo = new Armor("Monki See", 1, ItemSlot.Head, ArmorType.Plate, new(3, 3, 3, 0, 0, 0));
            HeroAttribute expectedAttributes = new(8, 5, 4, 3, 2, 1);

            //Act
            hero.EquipArmor(head);
            hero.EquipArmor(headTwo);
            HeroAttribute actualAttributes = hero.CalculateTotalAttributes();

            //Assert
            Assert.Equivalent(expectedAttributes, actualAttributes);
        }

        [Fact]
        public void When_CalculatingLevelOneDamageWithoutWeapon_Expect_CorrectDamage()
        {
            //Arrange
            var hero = new Warrior("Maddie");
            double expectedNoWeaponDamage = 1.05;

            //Act
            double actualNoWeaponDamage = hero.CalculateDamage();

            //Assert
            Assert.Equal(expectedNoWeaponDamage, actualNoWeaponDamage);
        }

        [Fact]
        public void When_CalculatingLevelOneDamageWithWeapon_Expect_CorrectDamage()
        {
            //Arrange
            var hero = new Warrior("Maddie");
            Weapons weapon = new Weapons("I SMASH YESYES", 1, WeaponType.Axes, 2);
            double expectedWeaponDamage = 2.1;

            //Act
            hero.EquipWeapon(weapon);
            double actualWeaponDamage = hero.CalculateDamage();

            //Assert
            Assert.Equal(expectedWeaponDamage, actualWeaponDamage);
        }

        [Fact]
        public void When_CalculatingLevelOneDamageWithReplacedWeapon_Expect_CorrectDamage()
        {
            //Arrange
            var hero = new Warrior("Maddie");
            Weapons weapon = new Weapons("I SMASH YESYES", 1, WeaponType.Axes, 2);
            Weapons weaponTwo = new Weapons("I SMASHIER YESYESYES", 1, WeaponType.Axes, 4);
            double expectedNoWeaponDamage = 4.2;

            //Act
            hero.EquipWeapon(weapon);
            hero.EquipWeapon(weaponTwo);
            double actualNoWeaponDamage = hero.CalculateDamage();

            //Assert
            Assert.Equal(expectedNoWeaponDamage, actualNoWeaponDamage);
        }

        [Fact]
        public void When_CalculatingLevelOneDamageWithWeaponAndArmor_Expect_CorrectDamage()
        {
            //Arrange
            var hero = new Warrior("Maddie");
            Weapons weapon = new Weapons("I SMASH YESYES", 1, WeaponType.Axes, 2);
            Armor head = new Armor("Monki Hear", 1, ItemSlot.Head, ArmorType.Plate, new(1, 1, 1, 0, 0, 0));
            Armor chest = new Armor("Monki See", 1, ItemSlot.Chest, ArmorType.Plate, new(1, 1, 1, 0, 0, 0));
            Armor legs = new Armor("Monki Do", 1, ItemSlot.Legs, ArmorType.Plate, new(1, 1, 1, 0, 0, 0));
            double expectedNoWeaponDamage = 2.16;

            //Act
            hero.EquipWeapon(weapon);
            hero.EquipArmor(head);
            hero.EquipArmor(chest);
            hero.EquipArmor(legs);
            double actualNoWeaponDamage = hero.CalculateDamage();

            //Assert
            Assert.Equal(expectedNoWeaponDamage, actualNoWeaponDamage);
        }

        [Fact]
        public void When_DisplayingWarriorInformation_Expect_CorrectInfo()
        {
            //Arrange
            var hero = new Warrior("Maddie");
            string expectedState = "Hero Name: " + hero.HeroName + "\n"
                + "Hero Class: " + hero.HeroClass + "\n"
                + "Hero Level: " + hero.HeroLevel + "\n"
                + "Total Strength: " + hero.CalculateTotalAttributes().Strength + "\n"
                + "Total Dexterity: " + hero.CalculateTotalAttributes().Dexterity + "\n"
                + "Total Intelligence: " + hero.CalculateTotalAttributes().Intelligence + "\n"
                + "Weapon Damage: " + hero.CalculateDamage();

            //Act
            string actualName = hero.DisplayHeroDetails();

            //Assert
            Assert.Equal(expectedState, actualName);
        }
    }
}