using RPGHeroes.Hero;
using RPGHeroes.Hero.RPG_Classes;
using RPGHeroes.Item;
using RPGHeroes.Item.Equipment;

namespace RPGHeroesTest.ItemTests
{
    public class ArmorTests
    {
        [Fact]
        public void When_CreatingNewArmor_Expect_CorrectName()
        {
            //Arrange
            string expectedName = "I PROTEC!";
            var armor = new Armor(expectedName, 3, itemSlot.Chest, armorType.Plate, new(95, 10, 1, 0, 0, 0));

            //Act
            string actualName = armor.ItemName;

            //Assert
            Assert.Equal(expectedName, actualName);
        }
        [Fact]
        public void When_CreatingNewArmor_Expect_CorrectRequiredLevel()
        {
            //Arrange
            var armor = new Armor("I PROTEC!", 3, itemSlot.Chest, armorType.Plate, new(95, 10, 1, 0, 0, 0));
            int expectedRequiredLevel = 3;

            //Act
            int actualRequiredLevel = armor.RequiredLevel;

            //Assert
            Assert.Equal(expectedRequiredLevel, actualRequiredLevel);
        }
        [Fact]
        public void When_CreatingNewArmor_Expect_CorrectItemSlot()
        {
            //Arrange
            var armor = new Armor("I PROTEC!", 3, itemSlot.Chest, armorType.Plate, new(95, 10, 1, 0, 0, 0));
            itemSlot expectedItemSlot = itemSlot.Chest;

            //Act
            itemSlot actualItemSlot = armor.ItemSlot;

            //Assert
            Assert.Equal(expectedItemSlot, actualItemSlot);
        }
        [Fact]
        public void When_CreatingNewArmor_Expect_CorrectArmorType()
        {
            //Arrange
            var armor = new Armor("I PROTEC!", 3, itemSlot.Chest, armorType.Plate, new(95, 10, 1, 0, 0, 0));
            armorType expectedArmorType = armorType.Plate;

            //Act
            armorType actualArmorType = armor.ArmorType;

            //Assert
            Assert.Equal(expectedArmorType, actualArmorType);
        }
        [Fact]
        public void When_CreatingNewArmor_Expect_CorrectArmorAttributes()
        {
            //Arrange
            var armor = new Armor("I PROTEC!", 3, itemSlot.Chest, armorType.Plate, new(95, 10, 1, 0, 0, 0));
            HeroAttribute expectedArmorAttributes = new(95, 10, 1, 0, 0, 0);

            //Act
            HeroAttribute actualArmorAttributes = armor.ArmorAttributes;

            //Assert
            Assert.Equivalent(expectedArmorAttributes, actualArmorAttributes);
        }
    }
}
