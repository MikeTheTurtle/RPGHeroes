using RPGHeroes.Hero;
using RPGHeroes.Hero.RPG_Classes;
using RPGHeroes.Item.Equipment;

namespace RPGHeroesTest.HeroTests.RPGClassesTests
{
    public class RogueTests
    {
        [Fact]
        public void When_CreatingNewRogue_Expect_CorrectName()
        {
            //Arrange
            string expectedName = "Tyson";
            var hero = new Rogue(expectedName);

            //Act
            string actualName = hero.HeroName;

            //Assert
            Assert.Equal(expectedName, actualName);
        }

        [Fact]
        public void When_CreatingNewRogue_Expect_CorrectLevel()
        {
            //Arrange
            var hero = new Rogue("Tyson");
            int expectedLevel = 1;

            //Act
            int actualLevel = hero.HeroLevel;

            //Assert
            Assert.Equal(expectedLevel, actualLevel);
        }

        [Fact]
        public void When_CreatingNewRogue_Expect_CorrectAttributes()
        {
            //Arrange
            var hero = new Rogue("Tyson");
            HeroAttribute expectedAttributes = new(2, 6, 1, 1, 4, 1);

            //Act
            HeroAttribute actualAttributes = hero.HeroLevelAttributes;

            //Assert
            Assert.Equivalent(expectedAttributes, actualAttributes);
        }

        [Fact]
        public void When_GainingOneLevel_Expect_CorrectAttributeIncreases()
        {
            //Arrange
            var hero = new Rogue("Tyson");
            HeroAttribute levelOneAttributes = hero.HeroLevelAttributes;
            HeroAttribute expectedLevelTwoAttributes = new(levelOneAttributes.Strength + 1, levelOneAttributes.Dexterity + 4, levelOneAttributes.Intelligence + 1, 1, 4, 1);

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
            var hero = new Rogue("Tyson");
            Weapons weapon = new Weapons("I STAB SISI", 1, WeaponType.Daggers, 15);
            int expectedRequiredLevel = 1;

            //Act
            hero.EquipWeapon(weapon);
            int actualRequiredLevel = hero.HeroEquippedWeapon.RequiredLevel;

            //Assert
            Assert.Equal(expectedRequiredLevel, actualRequiredLevel);
        }

        [Fact]
        public void When_EquippingDaggers_Expect_CorrectWeaponType()
        {
            //Arrange
            var hero = new Rogue("Tyson");
            Weapons weapon = new Weapons("I STAB SISI", 1, WeaponType.Daggers, 15);
            WeaponType expectedEquippableWeaponType = WeaponType.Daggers;

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
            var hero = new Rogue("Tyson");
            Weapons weapon = new Weapons("I SMASH YESYES", 1, WeaponType.Swords, 15);
            WeaponType expectedEquippableWeaponType = WeaponType.Swords;

            //Act
            hero.EquipWeapon(weapon);
            WeaponType actualEquippedWeaponType = hero.HeroEquippedWeapon.WeaponType;

            //Assert
            Assert.Equal(expectedEquippableWeaponType, actualEquippedWeaponType);
        }

        [Fact]
        public void When_EquippingLeather_Expect_CorrectArmorType()
        {
            //Arrange
            var hero = new Rogue("Tyson");
            Armor armor = new Armor("WHO NEEDS ACTUAL ARMOR", 1, ItemSlot.Chest, ArmorType.Leather, new(1, 1, 1, 0, 0, 0));
            ArmorType expectedEquippableArmorType = ArmorType.Leather;

            //Act
            hero.EquipArmor(armor);
            ArmorType actualEquippedArmorType = hero.HeroEquippedArmor[ItemSlot.Chest].ArmorType;

            //Assert
            Assert.Equal(expectedEquippableArmorType, actualEquippedArmorType);
        }

        [Fact]
        public void When_EquippingMail_Expect_CorrectArmorType()
        {
            //Arrange
            var hero = new Rogue("Tyson");
            Armor armor = new Armor("GETTING WARMER", 1, ItemSlot.Chest, ArmorType.Mail, new(1, 1, 1, 0, 0, 0));
            ArmorType expectedEquippableArmorType = ArmorType.Mail;

            //Act
            hero.EquipArmor(armor);
            ArmorType actualEquippedArmorType = hero.HeroEquippedArmor[ItemSlot.Chest].ArmorType;

            //Assert
            Assert.Equal(expectedEquippableArmorType, actualEquippedArmorType);
        }

        [Fact]
        public void When_CalculatingTotalAttributesWithoutArmor_Expect_CorrectAttributes()
        {
            //Arrange
            var hero = new Rogue("Tyson");
            HeroAttribute expectedAttributes = new(2, 6, 1, 1, 4, 1);

            //Act
            HeroAttribute actualAttributes = hero.CalculateTotalAttributes();

            //Assert
            Assert.Equivalent(expectedAttributes, actualAttributes);
        }

        [Fact]
        public void When_CalculatingTotalAttributesWithOneArmorPiece_Expect_CorrectAttributes()
        {
            //Arrange
            var hero = new Rogue("Tyson");
            Armor head = new Armor("Monki Hear", 1, ItemSlot.Head, ArmorType.Leather, new(1, 1, 1, 0, 0, 0));
            HeroAttribute expectedAttributes = new(3, 7, 2, 1, 4, 1);

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
            var hero = new Rogue("Tyson");
            Armor head = new Armor("Monki Hear", 1, ItemSlot.Head, ArmorType.Leather, new(1, 1, 1, 0, 0, 0));
            Armor chest = new Armor("Monki See", 1, ItemSlot.Chest, ArmorType.Leather, new(1, 1, 1, 0, 0, 0));
            HeroAttribute expectedAttributes = new(4, 8, 3, 1, 4, 1);

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
            var hero = new Rogue("Tyson");
            Armor head = new Armor("Monki Hear", 1, ItemSlot.Head, ArmorType.Leather, new(1, 1, 1, 0, 0, 0));
            Armor headTwo = new Armor("Monki See", 1, ItemSlot.Head, ArmorType.Leather, new(3, 3, 3, 0, 0, 0));
            HeroAttribute expectedAttributes = new(5, 9, 4, 1, 4, 1);

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
            var hero = new Rogue("Tyson");
            double expectedNoWeaponDamage = 1.06;

            //Act
            double actualNoWeaponDamage = hero.CalculateDamage();

            //Assert
            Assert.Equal(expectedNoWeaponDamage, actualNoWeaponDamage);
        }

        [Fact]
        public void When_CalculatingLevelOneDamageWithWeapon_Expect_CorrectDamage()
        {
            //Arrange
            var hero = new Rogue("Tyson");
            Weapons weapon = new Weapons("I STAB SISI", 1, WeaponType.Daggers, 2);
            double expectedWeaponDamage = 2.12;

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
            var hero = new Rogue("Tyson");
            Weapons weapon = new Weapons("I STAB SISI", 1, WeaponType.Daggers, 2);
            Weapons weaponTwo = new Weapons("I STABIER SISISI", 1, WeaponType.Daggers, 3);
            double expectedNoWeaponDamage = 3.18;

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
            var hero = new Rogue("Tyson");
            Weapons weapon = new Weapons("I STAB SISI", 1, WeaponType.Daggers, 2);
            Armor head = new Armor("Monki Hear", 1, ItemSlot.Head, ArmorType.Leather, new(1, 2, 1, 0, 0, 0));
            Armor chest = new Armor("Monki See", 1, ItemSlot.Chest, ArmorType.Leather, new(1, 1, 1, 0, 0, 0));
            Armor legs = new Armor("Monki Do", 1, ItemSlot.Legs, ArmorType.Leather, new(1, 1, 1, 0, 0, 0));
            double expectedNoWeaponDamage = 2.2;

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
        public void When_DisplayingRogueInformation_Expect_CorrectInfo()
        {
            //Arrange
            var hero = new Rogue("Tyson");
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