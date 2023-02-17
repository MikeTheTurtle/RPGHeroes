using RPGHeroes.Hero;
using RPGHeroes.Hero.RPG_Classes;
using RPGHeroes.Item.Equipment;

namespace RPGHeroesTest.HeroTests.RPGClassesTests
{
    public class MageTests
    {
        [Fact]
        public void When_CreatingNewMage_Expect_CorrectName()
        {
            //Arrange
            string expectedName = "Alice";
            var hero = new Mage(expectedName);

            //Act
            string actualName = hero.HeroName;

            //Assert
            Assert.Equal(expectedName, actualName);
        }

        [Fact]
        public void When_CreatingNewMage_Expect_CorrectLevel()
        {
            //Arrange
            var hero = new Mage("Alice");
            int expectedLevel = 1;

            //Act
            int actualLevel = hero.HeroLevel;

            //Assert
            Assert.Equal(expectedLevel, actualLevel);
        }

        [Fact]
        public void When_CreatingNewMage_Expect_CorrectAttributes()
        {
            //Arrange
            var hero = new Mage("Alice");
            HeroAttribute expectedAttributes = new(1, 1, 8, 1, 1, 5);

            //Act
            HeroAttribute actualAttributes = hero.HeroLevelAttributes;

            //Assert
            Assert.Equivalent(expectedAttributes, actualAttributes);
        }

        [Fact]
        public void When_GainingOneLevel_Expect_CorrectAttributeIncreases()
        {
            //Arrange
            var hero = new Mage("Alice");
            HeroAttribute levelOneAttributes = hero.HeroLevelAttributes;
            HeroAttribute expectedLevelTwoAttributes = new(levelOneAttributes.Strength + 1, levelOneAttributes.Dexterity + 1, levelOneAttributes.Intelligence + 5, 1, 1, 5);

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
            var hero = new Mage("Alice");
            Weapons weapon = new Weapons("I BLAST HAIHAI", 1, WeaponType.Staves, 15);
            int expectedRequiredLevel = 1;

            //Act
            hero.EquipWeapon(weapon);
            int actualRequiredLevel = hero.HeroEquippedWeapon.RequiredLevel;

            //Assert
            Assert.Equal(expectedRequiredLevel, actualRequiredLevel);
        }

        [Fact]
        public void When_EquippingStaves_Expect_CorrectWeaponType()
        {
            //Arrange
            var hero = new Mage("Alice");
            Weapons weapon = new Weapons("I BLAST HAIHAI", 1, WeaponType.Staves, 15);
            WeaponType expectedEquippableWeaponType = WeaponType.Staves;

            //Act
            hero.EquipWeapon(weapon);
            WeaponType actualEquippedWeaponType = hero.HeroEquippedWeapon.WeaponType;

            //Assert
            Assert.Equal(expectedEquippableWeaponType, actualEquippedWeaponType);
        }

        [Fact]
        public void When_EquippingCloth_Expect_CorrectArmorType()
        {
            //Arrange
            var hero = new Mage("Alice");
            Armor armor = new Armor("PLZ STAB ME", 1, ItemSlot.Legs, ArmorType.Cloth, new(1, 1, 1, 0, 0, 0));
            ArmorType expectedEquippableArmorType = ArmorType.Cloth;

            //Act
            hero.EquipArmor(armor);
            ArmorType actualEquippedArmorType = hero.HeroEquippedArmor[ItemSlot.Legs].ArmorType;

            //Assert
            Assert.Equal(expectedEquippableArmorType, actualEquippedArmorType);
        }

        [Fact]
        public void When_CalculatingTotalAttributesWithoutArmor_Expect_CorrectAttributes()
        {
            //Arrange
            var hero = new Mage("Alice");
            HeroAttribute expectedAttributes = new(1, 1, 8, 1, 1, 5);

            //Act
            HeroAttribute actualAttributes = hero.CalculateTotalAttributes();

            //Assert
            Assert.Equivalent(expectedAttributes, actualAttributes);
        }

        [Fact]
        public void When_CalculatingTotalAttributesWithOneArmorPiece_Expect_CorrectAttributes()
        {
            //Arrange
            var hero = new Mage("Alice");
            Armor head = new Armor("Monki Hear", 1, ItemSlot.Head, ArmorType.Cloth, new(1, 1, 1, 0, 0, 0));
            HeroAttribute expectedAttributes = new(2, 2, 9, 1, 1, 5);

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
            var hero = new Mage("Alice");
            Armor head = new Armor("Monki Hear", 1, ItemSlot.Head, ArmorType.Cloth, new(1, 1, 1, 0, 0, 0));
            Armor chest = new Armor("Monki See", 1, ItemSlot.Chest, ArmorType.Cloth, new(1, 1, 1, 0, 0, 0));
            HeroAttribute expectedAttributes = new(3, 3, 10, 1, 1, 5);

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
            var hero = new Mage("Alice");
            Armor head = new Armor("Monki Hear", 1, ItemSlot.Head, ArmorType.Cloth, new(1, 1, 1, 0, 0, 0));
            Armor headTwo = new Armor("Monki See", 1, ItemSlot.Head, ArmorType.Cloth, new(3, 3, 3, 0, 0, 0));
            HeroAttribute expectedAttributes = new(4, 4, 11, 1, 1, 5);

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
            var hero = new Mage("Alice");
            double expectedNoWeaponDamage = 1.08;

            //Act
            double actualNoWeaponDamage = hero.CalculateDamage();

            //Assert
            Assert.Equal(expectedNoWeaponDamage, actualNoWeaponDamage);
        }


        [Fact]
        public void When_CalculatingLevelOneDamageWithWeapon_Expect_CorrectDamage()
        {
            //Arrange
            var hero = new Mage("Alice");
            Weapons weapon = new Weapons("I BLAST HAIHAI", 1, WeaponType.Staves, 2);
            double expectedWeaponDamage = 2.16;

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
            var hero = new Mage("Alice");
            Weapons weapon = new Weapons("I BLAST HAIHAI", 1, WeaponType.Staves, 2);
            Weapons weaponTwo = new Weapons("I BLASTIER HAIHAIHAI", 1, WeaponType.Staves, 3);
            double expectedNoWeaponDamage = 3.24;

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
            var hero = new Mage("Alice");
            Weapons weapon = new Weapons("I BLAST HAIHAI", 1, WeaponType.Staves, 2);
            Armor head = new Armor("Monki Hear", 1, ItemSlot.Head, ArmorType.Cloth, new(1, 1, 1, 0, 0, 0));
            Armor chest = new Armor("Monki See", 1, ItemSlot.Chest, ArmorType.Cloth, new(1, 1, 1, 0, 0, 0));
            Armor legs = new Armor("Monki Do", 1, ItemSlot.Legs, ArmorType.Cloth, new(1, 1, 1, 0, 0, 0));
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
        public void When_DisplayingMageInformation_Expect_CorrectName()
        {
            //Arrange
            var hero = new Mage("Alice");
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