using RPGHeroes.Hero;
using RPGHeroes.Hero.RPG_Classes;
using RPGHeroes.Item.Equipment;

namespace RPGHeroesTest.HeroTests.RPGClassesTests
{
    public class RangerTests
    {
        [Fact]
        public void When_CreatingNewRanger_Expect_CorrectName()
        {
            //Arrange
            string expectedName = "Valgar";
            var hero = new Ranger(expectedName);

            //Act
            string actualName = hero.HeroName;

            //Assert
            Assert.Equal(expectedName, actualName);
        }

        [Fact]
        public void When_CreatingNewRanger_Expect_CorrectLevel()
        {
            //Arrange
            var hero = new Ranger("Valgar");
            int expectedLevel = 1;

            //Act
            int actualLevel = hero.HeroLevel;

            //Assert
            Assert.Equal(expectedLevel, actualLevel);
        }

        [Fact]
        public void When_CreatingNewRanger_Expect_CorrectAttributes()
        {
            //Arrange
            var hero = new Ranger("Valgar");
            HeroAttribute expectedAttributes = new(1, 7, 1, 1, 5, 1);

            //Act
            HeroAttribute actualAttributes = hero.HeroLevelAttributes;

            //Assert
            Assert.Equivalent(expectedAttributes, actualAttributes);
        }

        [Fact]
        public void When_GainingOneLevel_Expect_CorrectAttributeIncreases()
        {
            //Arrange
            var hero = new Ranger("Val");
            HeroAttribute levelOneAttributes = hero.HeroLevelAttributes;
            HeroAttribute expectedLevelTwoAttributes = new(levelOneAttributes.Strength + 1, levelOneAttributes.Dexterity + 5, levelOneAttributes.Intelligence + 1, 1, 5, 1);

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
            var hero = new Ranger("Val");
            Weapons weapon = new Weapons("I SHOOT JAJA", 1, WeaponType.Bows, 15);
            int expectedRequiredLevel = 1;

            //Act
            hero.EquipWeapon(weapon);
            int actualRequiredLevel = hero.HeroEquippedWeapon.RequiredLevel;

            //Assert
            Assert.Equal(expectedRequiredLevel, actualRequiredLevel);
        }

        [Fact]
        public void When_EquippingBows_Expect_CorrectWeaponType()
        {
            //Arrange
            var hero = new Ranger("Val");
            Weapons weapon = new Weapons("I SHOOT JAJA", 1, WeaponType.Bows, 15);
            WeaponType expectedEquippableWeaponType = WeaponType.Bows;

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
            var hero = new Ranger("Val");
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
            var hero = new Ranger("Val");
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
            var hero = new Ranger("Val");
            HeroAttribute expectedAttributes = new(1, 7, 1, 1, 5, 1);

            //Act
            HeroAttribute actualAttributes = hero.CalculateTotalAttributes();

            //Assert
            Assert.Equivalent(expectedAttributes, actualAttributes);
        }

        [Fact]
        public void When_CalculatingTotalAttributesWithOneArmorPiece_Expect_CorrectAttributes()
        {
            //Arrange
            var hero = new Ranger("Val");
            Armor head = new Armor("Monki Hear", 1, ItemSlot.Head, ArmorType.Mail, new(1, 1, 1, 0, 0, 0));
            HeroAttribute expectedAttributes = new(2, 8, 2, 1, 5, 1);

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
            var hero = new Ranger("Val");
            Armor head = new Armor("Monki Hear", 1, ItemSlot.Head, ArmorType.Mail, new(1, 1, 1, 0, 0, 0));
            Armor chest = new Armor("Monki See", 1, ItemSlot.Chest, ArmorType.Mail, new(1, 1, 1, 0, 0, 0));
            HeroAttribute expectedAttributes = new(3, 9, 3, 1, 5, 1);

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
            var hero = new Ranger("Val");
            Armor head = new Armor("Monki Hear", 1, ItemSlot.Head, ArmorType.Mail, new(1, 1, 1, 0, 0, 0));
            Armor headTwo = new Armor("Monki See", 1, ItemSlot.Head, ArmorType.Mail, new(3, 3, 3, 0, 0, 0));
            HeroAttribute expectedAttributes = new(4, 10, 4, 1, 5, 1);

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
            var hero = new Ranger("Val");
            double expectedNoWeaponDamage = 1.07;

            //Act
            double actualNoWeaponDamage = hero.CalculateDamage();

            //Assert
            Assert.Equal(expectedNoWeaponDamage, actualNoWeaponDamage);
        }


        [Fact]
        public void When_CalculatingLevelOneDamageWithWeapon_Expect_CorrectDamage()
        {
            //Arrange
            var hero = new Ranger("Val");
            Weapons weapon = new Weapons("I SHOOT JAJA", 1, WeaponType.Bows, 2);
            double expectedWeaponDamage = 2.14;

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
            var hero = new Ranger("Val");
            Weapons weapon = new Weapons("I SHOOT JAJA", 1, WeaponType.Bows, 2);
            Weapons weaponTwo = new Weapons("I SHOOTIER JAJAJA", 1, WeaponType.Bows, 3);
            double expectedNoWeaponDamage = 3.21;

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
            var hero = new Ranger("Val");
            Weapons weapon = new Weapons("I SHOOT JAJA", 1, WeaponType.Bows, 2);
            Armor head = new Armor("Monki Hear", 1, ItemSlot.Head, ArmorType.Mail, new(1, 2, 1, 0, 0, 0));
            Armor chest = new Armor("Monki See", 1, ItemSlot.Chest, ArmorType.Mail, new(1, 1, 1, 0, 0, 0));
            Armor legs = new Armor("Monki Do", 1, ItemSlot.Legs, ArmorType.Mail, new(1, 1, 1, 0, 0, 0));
            double expectedNoWeaponDamage = 2.22;

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
        public void When_DisplayingRangerInformation_Expect_CorrectInfo()
        {
            //Arrange
            var hero = new Ranger("Val");
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