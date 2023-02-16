using RPGHeroes.Item;
using RPGHeroes.Item.Equipment;

namespace RPGHeroesTest.ItemTests
{
    public class WeaponsTests
    {
        [Fact]
        public void When_CreatingNewWeapon_Expect_CorrectName()
        {
            //Arrange
            var weapon = new Weapons("I SMASH YESYES", 3, weaponType.Hammers, 15);
            string expectedName = "I SMASH YESYES";

            //Act
            string actualName = weapon.ItemName;

            //Assert
            Assert.Equal(expectedName, actualName);
        }
        [Fact]
        public void When_CreatingNewWeapon_Expect_CorrectRequiredLevel()
        {
            //Arrange
            var weapon = new Weapons("I SMASH YESYES", 3, weaponType.Hammers, 15);
            int expectedRequiredLevel = 3;

            //Act
            int actualRequiredLevel = weapon.RequiredLevel;

            //Assert
            Assert.Equal(expectedRequiredLevel, actualRequiredLevel);
        }
        [Fact]
        public void When_CreatingNewWeapon_Expect_CorrectItemSlot()
        {
            //Arrange
            var weapon = new Weapons("I SMASH YESYES", 3, weaponType.Hammers, 15);
            itemSlot expectedItemSlot = itemSlot.Weapon;

            //Act
            itemSlot actualItemSlot = weapon.ItemSlot;

            //Assert
            Assert.Equal(expectedItemSlot, actualItemSlot);
        }
        [Fact]
        public void When_CreatingNewWeapon_Expect_CorrectWeaponType()
        {
            //Arrange
            var weapon = new Weapons("I SMASH YESYES", 3, weaponType.Hammers, 15);
            weaponType expectedWeaponType = weaponType.Hammers;

            //Act
            weaponType actualWeaponType = weapon.WeaponType;

            //Assert
            Assert.Equal(expectedWeaponType, actualWeaponType);
        }
        [Fact]
        public void When_CreatingNewWeapon_Expect_CorrectWeaponDamage()
        {
            //Arrange
            var weapon = new Weapons("I SMASH YESYES", 3, weaponType.Hammers, 15);
            int expectedWeaponDamage = 15;

            //Act
            int actualWeaponDamage = weapon.WeaponDamage;

            //Assert
            Assert.Equal(expectedWeaponDamage, actualWeaponDamage);
        }
    }
}
