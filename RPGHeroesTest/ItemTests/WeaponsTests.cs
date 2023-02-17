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
            string expectedName = "I SMASH YESYES";
            var weapon = new Weapons(expectedName, 3, WeaponType.Hammers, 15);

            //Act
            string actualName = weapon.ItemName;

            //Assert
            Assert.Equal(expectedName, actualName);
        }
        [Fact]
        public void When_CreatingNewWeapon_Expect_CorrectRequiredLevel()
        {
            //Arrange
            var weapon = new Weapons("I SMASH YESYES", 3, WeaponType.Hammers, 15);
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
            var weapon = new Weapons("I SMASH YESYES", 3, WeaponType.Hammers, 15);
            ItemSlot expectedItemSlot = ItemSlot.Weapon;

            //Act
            ItemSlot actualItemSlot = weapon.ItemSlot;

            //Assert
            Assert.Equal(expectedItemSlot, actualItemSlot);
        }
        [Fact]
        public void When_CreatingNewWeapon_Expect_CorrectWeaponType()
        {
            //Arrange
            var weapon = new Weapons("I SMASH YESYES", 3, WeaponType.Hammers, 15);
            WeaponType expectedWeaponType = WeaponType.Hammers;

            //Act
            WeaponType actualWeaponType = weapon.WeaponType;

            //Assert
            Assert.Equal(expectedWeaponType, actualWeaponType);
        }
        [Fact]
        public void When_CreatingNewWeapon_Expect_CorrectWeaponDamage()
        {
            //Arrange
            var weapon = new Weapons("I SMASH YESYES", 3, WeaponType.Hammers, 15);
            int expectedWeaponDamage = 15;

            //Act
            int actualWeaponDamage = weapon.WeaponDamage;

            //Assert
            Assert.Equal(expectedWeaponDamage, actualWeaponDamage);
        }
    }
}
